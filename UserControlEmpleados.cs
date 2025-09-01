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
    public partial class UserControlEmpleados : UserControl
    {
        public UserControlEmpleados()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.UserControlEmpleados_Load);
        }

        private void ConfigurarColumnas()
        {
            dataGridViewEmpleados.Columns.Clear();

            dataGridViewEmpleados.Columns.Add("nombreEmpleado", "Nombre");
            dataGridViewEmpleados.Columns.Add("documento", "Documento");
            dataGridViewEmpleados.Columns.Add("direccion", "Dirección");
            dataGridViewEmpleados.Columns.Add("telefono", "Teléfono");
            dataGridViewEmpleados.Columns.Add("email", "Email");

            DataGridViewComboBoxColumn comboRol = new DataGridViewComboBoxColumn();
            comboRol.Name = "rol";
            comboRol.HeaderText = "Rol";
            comboRol.Items.AddRange("Gerente", "Asesor", "Vendedor", "Administrativo", "Logística");
            comboRol.DisplayStyle = DataGridViewComboBoxDisplayStyle.DropDownButton;
            dataGridViewEmpleados.Columns.Add(comboRol);

            dataGridViewEmpleados.Columns.Add("fechaIngreso", "Fecha Ingreso");
            dataGridViewEmpleados.Columns.Add("fechaRetiro", "Fecha Retiro");
        }


        private void CargarEmpleados()
        {
            string connectionString = "Server=DESKTOP-5EQEKKJ\\SQLEXPRESS;Database=formulario;Trusted_Connection=True;";
            string query = "SELECT  nombreEmpleado, documento, direccion, telefono, email, rol, fechaIngreso, fechaRetiro FROM empleados";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                dataGridViewEmpleados.Rows.Clear();

                while (reader.Read())
                {
                    dataGridViewEmpleados.Rows.Add(
                        reader["nombreEmpleado"].ToString(),
                        reader["documento"].ToString(),
                        reader["direccion"].ToString(),
                        reader["telefono"].ToString(),
                        reader["email"].ToString(),
                        reader["rol"].ToString(),
                        reader["fechaIngreso"].ToString(),
                        reader["fechaRetiro"].ToString()
                    );
                }
            }
        }

        private void UserControlEmpleados_Load(object sender, EventArgs e)
        {
            ConfigurarColumnas();
            CargarEmpleados();
        }

        private void dataGridViewEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione una fila para agregar como nuevo empleado");
                return;
            }

            DataGridViewRow row = dataGridViewEmpleados.SelectedRows[0];

            string nombre = row.Cells["nombreEmpleado"].Value?.ToString();
            string documento = row.Cells["documento"].Value?.ToString();
            string direccion = row.Cells["direccion"].Value?.ToString();
            string telefono = row.Cells["telefono"].Value?.ToString();
            string email = row.Cells["email"].Value?.ToString();
            string rol = row.Cells["rol"].Value?.ToString();
            string fechaIngreso = DateTime.Now.Date.ToString("yyyy-MM-dd");
            string fechaRetiro = row.Cells["fechaRetiro"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(documento) ||
                string.IsNullOrWhiteSpace(direccion) || string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(rol))
            {
                MessageBox.Show("Todos los campos excepto Fecha ingreso y Fecha Retiro son obligatorios");
                return;
            }

            if (!direccion.Contains("#"))
            {
                MessageBox.Show("La dirección debe contener el carácter '#' (Ejemplo: Calle 10 #15-20)");
                return;
            }

            if (documento.Length < 7)
            {
                MessageBox.Show("El documento debe tener al menos 7 caracteres");
                return;
            }

            if (telefono.Length > 11)
            {
                MessageBox.Show("El teléfono debe tener máximo 11 caracteres");
                return;
            }

            if (!telefono.All(char.IsDigit))
            {
                MessageBox.Show("El teléfono debe contener solo números");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El email no tiene un formato válido");
                return;
            }

            if (!string.IsNullOrWhiteSpace(fechaRetiro))
            {
                if (DateTime.TryParseExact(fechaRetiro, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime fechaRetiroParsed))
                {
                    DateTime fechaIngresoParsed = DateTime.Now.Date;
                    if (fechaRetiroParsed < fechaIngresoParsed)
                    {
                        MessageBox.Show("La fecha de retiro no puede ser menor que la fecha de ingreso");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Formato de fecha no válido. Use el formato yyyy-MM-dd (Ejemplo: 2025-08-31)");
                    return;
                }
            }





            string connectionString = "Server=DESKTOP-5EQEKKJ\\SQLEXPRESS;Database=formulario;Trusted_Connection=True;";
            string query = @"INSERT INTO empleados 
            (nombreEmpleado, documento, direccion, telefono, email, rol, fechaIngreso, fechaRetiro)
            VALUES (@nombre, @documento, @direccion, @telefono, @email, @rol, @fechaIngreso, @fechaRetiro)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@documento", documento);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@rol", rol);
                    command.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);
                    command.Parameters.AddWithValue("@fechaRetiro", string.IsNullOrWhiteSpace(fechaRetiro) ? (object)DBNull.Value : fechaRetiro);

                    connection.Open();
                    command.ExecuteNonQuery();
                    MessageBox.Show("Empleado agregado correctamente");
                    CargarEmpleados();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar empleado: " + ex.Message);
            }
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un empleado para eliminar");
                return;
            }

            DataGridViewRow row = dataGridViewEmpleados.SelectedRows[0];
            string documento = row.Cells["documento"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(documento))
            {
                MessageBox.Show("No se pudo obtener el documento del empleado");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar este empleado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            string connectionString = "Server=DESKTOP-5EQEKKJ\\SQLEXPRESS;Database=formulario;Trusted_Connection=True;";
            string query = "DELETE FROM empleados WHERE documento = @documento";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@documento", documento);
                    connection.Open();

                    int rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Empleado eliminado correctamente");
                        CargarEmpleados();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el empleado en la base de datos");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar empleado: " + ex.Message);
            }
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewEmpleados.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un empleado para editar.");
                return;
            }

            DataGridViewRow row = dataGridViewEmpleados.SelectedRows[0];

            string nombre = row.Cells["nombreEmpleado"].Value?.ToString();
            string documento = row.Cells["documento"].Value?.ToString();
            string direccion = row.Cells["direccion"].Value?.ToString();
            string telefono = row.Cells["telefono"].Value?.ToString();
            string email = row.Cells["email"].Value?.ToString();
            string rol = row.Cells["rol"].Value?.ToString();
            string fechaIngreso = DateTime.Now.Date.ToString("yyyy-MM-dd");
            string fechaRetiro = row.Cells["fechaRetiro"].Value?.ToString();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(documento) ||
                string.IsNullOrWhiteSpace(direccion) || string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(rol))
            {
                MessageBox.Show("Todos los campos excepto Fecha Retiro son obligatorios");
                return;
            }

            if (!direccion.Contains("#"))
            {
                MessageBox.Show("La dirección debe contener el carácter '#' (Ejemplo: Calle 10 #15-20)");
                return;
            }

            if (documento.Length < 7)
            {
                MessageBox.Show("El documento debe tener al menos 7 caracteres");
                return;
            }

            if (telefono.Length > 11)
            {
                MessageBox.Show("El teléfono debe tener máximo 11 caracteres");
                return;
            }

            if (!telefono.All(char.IsDigit))
            {
                MessageBox.Show("El teléfono debe contener solo números");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El email no tiene un formato válido");
                return;
            }


            if (!string.IsNullOrWhiteSpace(fechaRetiro))
            {
                if (DateTime.TryParseExact(fechaRetiro, "yyyy-MM-dd", null, System.Globalization.DateTimeStyles.None, out DateTime fechaRetiroParsed))
                {
                    DateTime fechaIngresoParsed = DateTime.Now.Date;
                    if (fechaRetiroParsed < fechaIngresoParsed)
                    {
                        MessageBox.Show("La fecha de retiro no puede ser menor que la fecha de ingreso");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Formato de fecha no válido. Use el formato yyyy-MM-dd (Ejemplo: 2025-08-31)");
                    return;
                }
            }




            string connectionString = "Server=DESKTOP-5EQEKKJ\\SQLEXPRESS;Database=formulario;Trusted_Connection=True;";
            string query = @"UPDATE empleados SET 
                nombreEmpleado = @nombre,
                direccion = @direccion,
                telefono = @telefono,
                email = @email,
                rol = @rol,
                fechaIngreso = @fechaIngreso,
                fechaRetiro = @fechaRetiro
                WHERE documento = @documento";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@documento", documento);
                    command.Parameters.AddWithValue("@direccion", direccion);
                    command.Parameters.AddWithValue("@telefono", telefono);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@rol", rol);
                    command.Parameters.AddWithValue("@fechaIngreso", fechaIngreso);
                    command.Parameters.AddWithValue("@fechaRetiro", string.IsNullOrWhiteSpace(fechaRetiro) ? (object)DBNull.Value : fechaRetiro);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Empleado actualizado correctamente");
                        CargarEmpleados();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el empleado");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al editar empleado: " + ex.Message);
            }
        }


    }
}
