using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_AEAE_2
{
    public partial class UserControlFacturas : UserControl
    {
        public UserControlFacturas()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.UserControlFacturas_Load);
        }

        private void UserControlFacturas_Load(object sender, EventArgs e)
        {
            ConfigurarColumnas();
            CargarFacturas();
        }

        private void ConfigurarColumnas()
        {
            dataGridViewFactura.Columns.Clear();

            dataGridViewFactura.Columns.Add("numeroFactura", "Número Factura");

            DataGridViewComboBoxColumn comboCliente = new DataGridViewComboBoxColumn();
            comboCliente.Name = "cliente";
            comboCliente.HeaderText = "Cliente";
            comboCliente.DataSource = ObtenerClientes();
            comboCliente.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            dataGridViewFactura.Columns.Add(comboCliente);

            DataGridViewComboBoxColumn comboEmpleado = new DataGridViewComboBoxColumn();
            comboEmpleado.Name = "empleado";
            comboEmpleado.HeaderText = "Empleado";
            comboEmpleado.DataSource = ObtenerEmpleados();
            comboEmpleado.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            dataGridViewFactura.Columns.Add(comboEmpleado);

            dataGridViewFactura.Columns.Add("descuento", "Descuento");
            dataGridViewFactura.Columns.Add("fechaRegistro", "Fecha Registro");

            DataGridViewComboBoxColumn comboEstado = new DataGridViewComboBoxColumn();
            comboEstado.Name = "estadoFactura";
            comboEstado.HeaderText = "Estado";
            comboEstado.Items.AddRange("ACTIVO", "CERRADO");
            comboEstado.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            dataGridViewFactura.Columns.Add(comboEstado);

            dataGridViewFactura.Columns.Add("totalIva", "Total IVA");
            dataGridViewFactura.Columns.Add("totalFactura", "Total Factura");
        }


        private List<string> ObtenerClientes()
        {
            List<string> clientes = new List<string>();
            string query = "SELECT NombreCliente FROM Clientes";
            string connectionString = "Server=DESKTOP-5EQEKKJ\\SQLEXPRESS;Database=formulario;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    clientes.Add(reader["NombreCliente"].ToString());
                }
            }

            return clientes;
        }

        private List<string> ObtenerEmpleados()
        {
            List<string> empleados = new List<string>();
            string query = "SELECT nombreEmpleado FROM empleados";
            string connectionString = "Server=DESKTOP-5EQEKKJ\\SQLEXPRESS;Database=formulario;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    empleados.Add(reader["nombreEmpleado"].ToString());
                }
            }

            return empleados;
        }


        private void CargarFacturas()
        {
            string connectionString = "Server=DESKTOP-5EQEKKJ\\SQLEXPRESS;Database=formulario;Trusted_Connection=True;";
            string query = "SELECT numeroFactura, cliente, empleado, descuento, fechaRegistro, estadoFactura, totalIva, totalFactura FROM facturas";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                dataGridViewFactura.Rows.Clear();

                while (reader.Read())
                {
                    dataGridViewFactura.Rows.Add(
                        reader["numeroFactura"].ToString(),
                        reader["cliente"].ToString(),
                        reader["empleado"].ToString(),
                        reader["descuento"].ToString(),
                        Convert.ToDateTime(reader["fechaRegistro"]).ToString("yyyy-MM-dd"),
                        reader["estadoFactura"].ToString(),
                        reader["totalIva"].ToString(),
                        reader["totalFactura"].ToString()
                    );
                }
            }
        }

        private void dataGridViewFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewFactura.Columns[e.ColumnIndex].Name == "descuento" ||
                dataGridViewFactura.Columns[e.ColumnIndex].Name == "totalIva")
            {
                DataGridViewRow row = dataGridViewFactura.Rows[e.RowIndex];

                string descuentoStr = row.Cells["descuento"].Value?.ToString();
                string ivaStr = row.Cells["totalIva"].Value?.ToString();
                string subtotalStr = row.Cells["totalFactura"].Value?.ToString();

                if (string.IsNullOrWhiteSpace(subtotalStr))
                {
                    MessageBox.Show("Por favor, ingrese un valor válido en 'Total Factura' antes de calcular");
                    return;
                }

                if (!decimal.TryParse(subtotalStr, out decimal subtotal) || subtotal < 0)
                {
                    MessageBox.Show("El Total Factura debe ser un número positivo");
                    return;
                }

                decimal descuento = 0;
                if (!string.IsNullOrWhiteSpace(descuentoStr))
                {
                    if (!decimal.TryParse(descuentoStr, out descuento) || descuento < 0)
                    {
                        MessageBox.Show("El descuento debe ser un número positivo o estar vacío");
                        return;
                    }
                }

                decimal iva = 0;
                if (!string.IsNullOrWhiteSpace(ivaStr))
                {
                    if (!decimal.TryParse(ivaStr, out iva) || iva < 0)
                    {
                        MessageBox.Show("El IVA debe ser un número positivo o estar vacío");
                        return;
                    }
                }

                decimal total = subtotal - (subtotal * (descuento / 100)) + iva;
                row.Cells["totalFactura"].Value = total.ToString("F2");
            }
        }


        private void btnEliminar_Click(object sender, EventArgs e)
        {
         
            if (dataGridViewFactura.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione una factura para eliminar");
                return;
            }

            DataGridViewRow selectedRow = dataGridViewFactura.SelectedRows[0];
            string numeroFactura = selectedRow.Cells["numeroFactura"].Value?.ToString();

            if (string.IsNullOrEmpty(numeroFactura))
            {
                MessageBox.Show("No se pudo obtener el número de factura seleccionado");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar esta factura?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            string connectionString = "Server=DESKTOP-5EQEKKJ\\SQLEXPRESS;Database=formulario;Trusted_Connection=True;";
            string query = "DELETE FROM facturas WHERE numeroFactura = @numeroFactura";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@numeroFactura", numeroFactura);
                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Factura eliminada correctamente");
                        CargarFacturas();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la factura en la base de datos");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar factura: " + ex.Message);
            }
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewFactura.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una factura para editar");
                return;
            }

            DataGridViewRow row = dataGridViewFactura.SelectedRows[0];

            string numeroFactura = row.Cells["numeroFactura"].Value?.ToString();
            string cliente = row.Cells["cliente"].Value?.ToString();
            string empleado = row.Cells["empleado"].Value?.ToString();
            string estadoFactura = row.Cells["estadoFactura"].Value?.ToString();
            string fechaCampo = row.Cells["fechaRegistro"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(numeroFactura) || string.IsNullOrWhiteSpace(cliente) ||
                string.IsNullOrWhiteSpace(empleado) || string.IsNullOrWhiteSpace(estadoFactura))
            {
                MessageBox.Show("Los campos Número Factura, Cliente, Empleado, Estado y Total Factura son obligatorios");
                return;
            }

            if (!string.IsNullOrWhiteSpace(fechaCampo))
            {
                MessageBox.Show("La fecha de registro se asigna automáticamente al editar. No es necesario ingresarla");
            }

            decimal descuento = 0;
            if (!string.IsNullOrWhiteSpace(row.Cells["descuento"].Value?.ToString()))
            {
                if (!decimal.TryParse(row.Cells["descuento"].Value.ToString(), out descuento) || descuento < 0)
                {
                    MessageBox.Show("El descuento debe ser un número positivo o estar vacío");
                    return;
                }
            }

            decimal totalIva = 0;
            if (!string.IsNullOrWhiteSpace(row.Cells["totalIva"].Value?.ToString()))
            {
                if (!decimal.TryParse(row.Cells["totalIva"].Value.ToString(), out totalIva) || totalIva < 0)
                {
                    MessageBox.Show("El IVA debe ser un número positivo o estar vacío");
                    return;
                }
            }

            if (!decimal.TryParse(row.Cells["totalFactura"].Value?.ToString(), out decimal subtotal) || subtotal < 0)
            {
                MessageBox.Show("El Total Factura debe ser un número positivo y no puede estar vacío");
                return;
            }


            decimal totalFactura = subtotal - (subtotal * descuento / 100) + totalIva;
            string fechaRegistro = DateTime.Now.Date.ToString("yyyy-MM-dd");

            string connectionString = "Server=DESKTOP-5EQEKKJ\\SQLEXPRESS;Database=formulario;Trusted_Connection=True;";
            string query = @"UPDATE facturas SET 
        cliente = @cliente,
        empleado = @empleado,
        descuento = @descuento,
        fechaRegistro = @fechaRegistro,
        estadoFactura = @estadoFactura,
        totalIva = @totalIva,
        totalFactura = @totalFactura
    WHERE numeroFactura = @numeroFactura";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@cliente", cliente);
                    command.Parameters.AddWithValue("@empleado", empleado);
                    command.Parameters.AddWithValue("@descuento", descuento);
                    command.Parameters.AddWithValue("@fechaRegistro", fechaRegistro);
                    command.Parameters.AddWithValue("@estadoFactura", estadoFactura);
                    command.Parameters.AddWithValue("@totalIva", totalIva);
                    command.Parameters.AddWithValue("@totalFactura", totalFactura);
                    command.Parameters.AddWithValue("@numeroFactura", numeroFactura);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Factura actualizada correctamente");
                        CargarFacturas();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró la factura");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar factura: " + ex.Message);
            }
        }



        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dataGridViewFactura.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para agregar como nueva factura");
                return;
            }

            DataGridViewRow row = dataGridViewFactura.SelectedRows[0];

            string numeroFactura = row.Cells["numeroFactura"].Value?.ToString();
            string cliente = row.Cells["cliente"].Value?.ToString();
            string empleado = row.Cells["empleado"].Value?.ToString();
            string estadoFactura = row.Cells["estadoFactura"].Value?.ToString();
            string fechaCampo = row.Cells["fechaRegistro"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(numeroFactura) || string.IsNullOrWhiteSpace(cliente) ||
                string.IsNullOrWhiteSpace(empleado) || string.IsNullOrWhiteSpace(estadoFactura))
            {
                MessageBox.Show("Los campos Número Factura, Cliente, Empleado, Estado y Total Factura son obligatorios");
                return;
            }

            if (!string.IsNullOrWhiteSpace(fechaCampo))
            {
                MessageBox.Show("La fecha de registro se asigna automáticamente. No es necesario ingresarla");
            }

            decimal descuento = 0;
            if (!string.IsNullOrWhiteSpace(row.Cells["descuento"].Value?.ToString()))
            {
                if (!decimal.TryParse(row.Cells["descuento"].Value.ToString(), out descuento) || descuento < 0)
                {
                    MessageBox.Show("El descuento debe ser un número positivo o estar vacío");
                    return;
                }
            }

            decimal totalIva = 0;
            if (!string.IsNullOrWhiteSpace(row.Cells["totalIva"].Value?.ToString()))
            {
                if (!decimal.TryParse(row.Cells["totalIva"].Value.ToString(), out totalIva) || totalIva < 0)
                {
                    MessageBox.Show("El IVA debe ser un número positivo o estar vacío");
                    return;
                }
            }

            if (!decimal.TryParse(row.Cells["totalFactura"].Value?.ToString(), out decimal subtotal) || subtotal < 0)
            {
                MessageBox.Show("El Total Factura debe ser un número positivo y no puede estar vacío");
                return;
            }


            decimal totalFactura = subtotal - (subtotal * descuento / 100) + totalIva;
            string fechaRegistro = DateTime.Now.Date.ToString("yyyy-MM-dd");

            string connectionString = "Server=DESKTOP-5EQEKKJ\\SQLEXPRESS;Database=formulario;Trusted_Connection=True;";
            string query = @"INSERT INTO facturas 
    (numeroFactura, cliente, empleado, descuento, fechaRegistro, estadoFactura, totalIva, totalFactura)
    VALUES (@numeroFactura, @cliente, @empleado, @descuento, @fechaRegistro, @estadoFactura, @totalIva, @totalFactura)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@numeroFactura", numeroFactura);
                    command.Parameters.AddWithValue("@cliente", cliente);
                    command.Parameters.AddWithValue("@empleado", empleado);
                    command.Parameters.AddWithValue("@descuento", descuento);
                    command.Parameters.AddWithValue("@fechaRegistro", fechaRegistro);
                    command.Parameters.AddWithValue("@estadoFactura", estadoFactura);
                    command.Parameters.AddWithValue("@totalIva", totalIva);
                    command.Parameters.AddWithValue("@totalFactura", totalFactura);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Factura agregada correctamente");
                    CargarFacturas();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar factura: " + ex.Message);
            }
        }


        private void UserControlFacturas_Load_1(object sender, EventArgs e)
        {

        }
    }
}
