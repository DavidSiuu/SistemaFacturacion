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
    public partial class UserControlProductos : UserControl
    {
        public UserControlProductos()
        {
            InitializeComponent();
            this.Load += UserControlProductos_Load;
        }

        private void CargarProductos()
        {
            string connectionString = "Server=DESKTOP-5EQEKKJ\\SQLEXPRESS;Database=formulario;Trusted_Connection=True;";
            string query = "SELECT nombreProducto, codigo, precio, cantidad, categoria, descripcion FROM productos";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                dataGridView1.Rows.Clear();

                while (reader.Read())
                {
                    dataGridView1.Rows.Add(
                        reader["nombreProducto"].ToString(),
                        reader["codigo"].ToString(),
                        reader["precio"].ToString(),
                        reader["cantidad"].ToString(),
                        reader["categoria"].ToString(),
                        reader["descripcion"].ToString()
                    );
                }
            }
        }


        private void UserControlProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];


            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int lastRowIndex = dataGridView1.Rows.Count - 2; 

            if (lastRowIndex < 0)
            {
                MessageBox.Show("No hay datos para agregar");
                return;
            }

            DataGridViewRow lastRow = dataGridView1.Rows[lastRowIndex];

            // Extraer valores
            string nombreProducto = lastRow.Cells[0].Value?.ToString().Trim();
            string codigo = lastRow.Cells[1].Value?.ToString().Trim();
            string precioStr = lastRow.Cells[2].Value?.ToString().Trim();
            string cantidadStr = lastRow.Cells[3].Value?.ToString().Trim();
            string categoria = lastRow.Cells[4].Value?.ToString().Trim();
            string descripcion = lastRow.Cells[5].Value?.ToString().Trim();

            // Validaciones
            if (string.IsNullOrWhiteSpace(nombreProducto) ||
                string.IsNullOrWhiteSpace(codigo) ||
                string.IsNullOrWhiteSpace(precioStr) ||
                string.IsNullOrWhiteSpace(cantidadStr) ||
                string.IsNullOrWhiteSpace(categoria) ||
                string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("Todos los campos deben estar completos");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(nombreProducto, @"^[\w\sáéíóúÁÉÍÓÚñÑ]+$"))
            {
                MessageBox.Show("El nombre del producto contiene caracteres no válidos");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(codigo, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("El código debe contener solo letras y números, sin símbolos ni espacios");
                return;
            }

            if (!decimal.TryParse(precioStr, out decimal precio) || precio < 0)
            {
                MessageBox.Show("El precio debe ser un número decimal válido y positivo");
                return;
            }

            if (!int.TryParse(cantidadStr, out int cantidad) || cantidad < 0)
            {
                MessageBox.Show("La cantidad debe ser un número entero válido y positivo");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(categoria, @"^[\w\sáéíóúÁÉÍÓÚñÑ]+$"))
            {
                MessageBox.Show("La categoría contiene caracteres no válidos");
                return;
            }

            if (descripcion.Length > 1000)
            {
                MessageBox.Show("La descripción es demasiado larga");
                return;
            }

            string connectionString = "Server=DESKTOP-5EQEKKJ\\SQLEXPRESS;Database=formulario;Trusted_Connection=True;";
            string query = "INSERT INTO productos (nombreProducto, codigo, precio, cantidad, categoria, descripcion) " +
                           "VALUES (@nombreProducto, @codigo, @precio, @cantidad, @categoria, @descripcion)";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@nombreProducto", nombreProducto);
                    command.Parameters.AddWithValue("@codigo", codigo);
                    command.Parameters.AddWithValue("@precio", precio);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.Parameters.AddWithValue("@categoria", categoria);
                    command.Parameters.AddWithValue("@descripcion", descripcion);

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show("Producto agregado correctamente");
                CargarProductos();
            }
            catch (SqlException ex) when (ex.Number == 2627) 
            {
                MessageBox.Show("El código del producto ya existe. Debe ser único");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Selecciona un producto para editar");
                return;
            }

            DataGridViewRow row = dataGridView1.CurrentRow;

            string nombreProducto = row.Cells[0].Value?.ToString().Trim();
            string codigo = row.Cells[1].Value?.ToString().Trim();
            string precioStr = row.Cells[2].Value?.ToString().Trim();
            string cantidadStr = row.Cells[3].Value?.ToString().Trim();
            string categoria = row.Cells[4].Value?.ToString().Trim();
            string descripcion = row.Cells[5].Value?.ToString().Trim();

            if (string.IsNullOrWhiteSpace(nombreProducto) ||
                string.IsNullOrWhiteSpace(codigo) ||
                string.IsNullOrWhiteSpace(precioStr) ||
                string.IsNullOrWhiteSpace(cantidadStr) ||
                string.IsNullOrWhiteSpace(categoria) ||
                string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("Todos los campos deben estar completos");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(nombreProducto, @"^[\w\sáéíóúÁÉÍÓÚñÑ]+$"))
            {
                MessageBox.Show("El nombre del producto contiene caracteres no válidos");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(codigo, @"^[a-zA-Z0-9]+$"))
            {
                MessageBox.Show("El código debe contener solo letras y números, sin símbolos ni espacios");
                return;
            }

            if (!decimal.TryParse(precioStr, out decimal precio) || precio < 0)
            {
                MessageBox.Show("El precio debe ser un número decimal válido y positivo");
                return;


                if (!int.TryParse(cantidadStr, out int cantidad) || cantidad < 0)
                {
                    MessageBox.Show("La cantidad debe ser un número entero válido y positivo");
                    return;
                }

                if (!System.Text.RegularExpressions.Regex.IsMatch(categoria, @"^[\w\sáéíóúÁÉÍÓÚñÑ]+$"))
                {
                    MessageBox.Show("La categoría contiene caracteres no válidos");
                    return;
                }

                if (descripcion.Length > 1000)
                {
                    MessageBox.Show("La descripción es demasiado larga");
                    return;
                }

                string connectionString = "Server=DESKTOP-5EQEKKJ\\SQLEXPRESS;Database=formulario;Trusted_Connection=True;";
                string query = @"UPDATE productos 
                     SET nombreProducto = @nombreProducto, precio = @precio, cantidad = @cantidad, 
                         categoria = @categoria, descripcion = @descripcion
                     WHERE codigo = @codigo";

                try
                {
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@nombreProducto", nombreProducto);
                        command.Parameters.AddWithValue("@precio", precio);
                        command.Parameters.AddWithValue("@cantidad", cantidad);
                        command.Parameters.AddWithValue("@categoria", categoria);
                        command.Parameters.AddWithValue("@descripcion", descripcion);
                        command.Parameters.AddWithValue("@codigo", codigo);

                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Producto actualizado correctamente");
                            CargarProductos();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el producto para actualizar");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar producto: " + ex.Message);
                }
            }
        }



        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null || dataGridView1.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Selecciona un producto para eliminar");
                return;
            }

            DataGridViewRow row = dataGridView1.CurrentRow;
            string codigo = row.Cells[1].Value?.ToString().Trim();

            if (string.IsNullOrWhiteSpace(codigo))
            {
                MessageBox.Show("Código del producto no válido");
                return;
            }

            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este producto?",
                                                  "Confirmar eliminación",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                return;

            string connectionString = "Server=DESKTOP-5EQEKKJ\\SQLEXPRESS;Database=formulario;Trusted_Connection=True;";
            string query = "DELETE FROM productos WHERE codigo = @codigo";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@codigo", codigo);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Producto eliminado correctamente");
                        CargarProductos();
                    }
                    else
                    {
                        MessageBox.Show("No se encontró el producto para eliminar");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar producto: " + ex.Message);
            }
        }

        private void UserControlProductos_Load_1(object sender, EventArgs e)
        {

        }
    }
}
