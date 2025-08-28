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
    public partial class UserControlClientes : UserControl
    {
        public UserControlClientes()
        {
            InitializeComponent();
        }

        private void CargarClientes()
        {
            string connectionString = "Server=DESKTOP-5EQEKKJ\\SQLEXPRESS;Database=formulario;Trusted_Connection=True;";
            string query = "SELECT NombreCliente, Documento, Direccion, Telefono, Email FROM Clientes";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                dataGridViewClientes.Rows.Clear();

                while (reader.Read())
                {
                    dataGridViewClientes.Rows.Add(
                        reader["NombreCliente"].ToString(),
                        reader["Documento"].ToString(),
                        reader["Direccion"].ToString(),
                        reader["Telefono"].ToString(),
                        reader["Email"].ToString()
                    );
                }
            }
        }



        private void UserControlClientes_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridViewClientes.Rows[e.RowIndex];

               
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int lastRowIndex = dataGridViewClientes.Rows.Count - 2; // Fila con datos (la penúltima)
            if (lastRowIndex < 0)
            {
                MessageBox.Show("No hay datos para agregar");
                return;
            }

            DataGridViewRow lastRow = dataGridViewClientes.Rows[lastRowIndex];

            // Extraer valores
            string nombre = lastRow.Cells[0].Value?.ToString().Trim();
            string documento = lastRow.Cells[1].Value?.ToString().Trim();
            string direccion = lastRow.Cells[2].Value?.ToString().Trim();
            string telefono = lastRow.Cells[3].Value?.ToString().Trim();
            string email = lastRow.Cells[4].Value?.ToString().Trim();

            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(documento) ||
                string.IsNullOrWhiteSpace(direccion) ||
                string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Todos los campos deben estar completos");
                return;
            }

            // Validación: nombre solo letras y espacios
            if (!System.Text.RegularExpressions.Regex.IsMatch(nombre, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                MessageBox.Show("El nombre solo debe contener letras y espacios");
                return;
            }

            // Validación: documento letras y números, sin espacios ni caracteres especiales
            if (!System.Text.RegularExpressions.Regex.IsMatch(documento, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("El documento solo debe contener letras y números, sin espacios ni símbolos");
                return;
            }

            // Validación: dirección debe contener al menos un '#'
            if (!direccion.Contains("#"))
            {
                MessageBox.Show("La dirección debe contener un carácter '#' (ejemplo: Calle 5 #12-34)");
                return;
            }

            // Validación: teléfono debe contener solo números, máximo 11 dígitos
            if (!System.Text.RegularExpressions.Regex.IsMatch(telefono, @"^\d{1,11}$"))
            {
                MessageBox.Show("El teléfono debe contener solo números (máximo 11 dígitos)");
                return;
            }

            // Validación: email básico
            if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El correo electrónico no es válido");
                return;
            }

            // Insertar en la base de datos
            string connectionString = "Server=DESKTOP-5EQEKKJ\\SQLEXPRESS;Database=formulario;Trusted_Connection=True;";
            string query = "INSERT INTO Clientes (NombreCliente, Documento, Direccion, Telefono, Email) " +
                           "VALUES (@NombreCliente, @Documento, @Direccion, @Telefono, @Email)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NombreCliente", nombre);
                    command.Parameters.AddWithValue("@Documento", documento);
                    command.Parameters.AddWithValue("@Direccion", direccion);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Email", email);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Cliente agregado correctamente");
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar cliente: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un cliente para eliminar.");
                return;
            }

            DataGridViewRow selectedRow = dataGridViewClientes.SelectedRows[0];

            string documento = selectedRow.Cells[1].Value?.ToString(); // Asumiendo que el documento está en la columna 1

            if (string.IsNullOrEmpty(documento))
            {
                MessageBox.Show("No se pudo obtener el documento del cliente seleccionado.");
                return;
            }

            DialogResult confirm = MessageBox.Show(
                "¿Estás seguro de que deseas eliminar este cliente?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm != DialogResult.Yes)
                return;

            string connectionString = "Server=DESKTOP-5EQEKKJ\\SQLEXPRESS;Database=formulario;Trusted_Connection=True;";
            string query = "DELETE FROM Clientes WHERE Documento = @Documento";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Documento", documento);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cliente eliminado correctamente.");
                        CargarClientes();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el cliente en la base de datos.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar cliente: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.SelectedRows.Count == 0)
            {
                MessageBox.Show("Por favor, seleccione un cliente para editar.");
                return;
            }

            DataGridViewRow selectedRow = dataGridViewClientes.SelectedRows[0];

            // Extraer valores modificados
            string nombre = selectedRow.Cells[0].Value?.ToString().Trim();
            string documentoNuevo = selectedRow.Cells[1].Value?.ToString().Trim();
            string direccion = selectedRow.Cells[2].Value?.ToString().Trim();
            string telefono = selectedRow.Cells[3].Value?.ToString().Trim();
            string email = selectedRow.Cells[4].Value?.ToString().Trim();

            // Validar campos vacíos
            if (string.IsNullOrWhiteSpace(nombre) ||
                string.IsNullOrWhiteSpace(documentoNuevo) ||
                string.IsNullOrWhiteSpace(direccion) ||
                string.IsNullOrWhiteSpace(telefono) ||
                string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Todos los campos deben estar completos.");
                return;
            }

            // Validación: nombre solo letras y espacios
            if (!System.Text.RegularExpressions.Regex.IsMatch(nombre, @"^[a-zA-ZáéíóúÁÉÍÓÚñÑ\s]+$"))
            {
                MessageBox.Show("El nombre solo debe contener letras y espacios.");
                return;
            }

            // Validación: documento letras y números, sin espacios ni símbolos
            if (!System.Text.RegularExpressions.Regex.IsMatch(documentoNuevo, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("El documento solo debe contener letras y números, sin espacios ni símbolos.");
                return;
            }

            // Validación: dirección debe contener al menos un '#'
            if (!direccion.Contains("#"))
            {
                MessageBox.Show("La dirección debe contener un carácter '#' (ejemplo: Calle 5 #12-34).");
                return;
            }

            // Validación: teléfono solo números, máximo 11 dígitos
            if (!System.Text.RegularExpressions.Regex.IsMatch(telefono, @"^\d{1,11}$"))
            {
                MessageBox.Show("El teléfono debe contener solo números (máximo 11 dígitos).");
                return;
            }

            // Validación: email básico
            if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("El correo electrónico no es válido.");
                return;
            }

            // Obtener el documento original para saber a quién actualizar
            string documentoOriginal = selectedRow.Cells[1].Value?.ToString();

            string connectionString = "Server=DESKTOP-5EQEKKJ\\SQLEXPRESS;Database=formulario;Trusted_Connection=True;";
            string query = "UPDATE Clientes SET NombreCliente = @NombreCliente, Documento = @DocumentoNuevo, " +
                           "Direccion = @Direccion, Telefono = @Telefono, Email = @Email " +
                           "WHERE Documento = @DocumentoOriginal";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NombreCliente", nombre);
                    command.Parameters.AddWithValue("@DocumentoNuevo", documentoNuevo);
                    command.Parameters.AddWithValue("@Direccion", direccion);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@DocumentoOriginal", documentoOriginal);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Cliente actualizado correctamente.");
                        CargarClientes();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el cliente para actualizar.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar cliente: " + ex.Message);
            }
        }

    }
}
