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
    public partial class UserControlSeguridad : UserControl
    {
        public UserControlSeguridad()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.UserSeguridad_Load);
        }

        private void CargarUsuarios()
        {
            string connectionString = "Server=DESKTOP-5EQEKKJ\\SQLEXPRESS;Database=formulario;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT id, login FROM login";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    comboBoxUsuarios.DisplayMember = "login";
                    comboBoxUsuarios.ValueMember = "id";
                    comboBoxUsuarios.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar usuarios: " + ex.Message);
                }
            }
        }

        private void UserSeguridad_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CargarDatosUsuario(int id)
        {
            string connectionString = "Server=DESKTOP-5EQEKKJ\\SQLEXPRESS;Database=formulario;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT login, password FROM login WHERE id = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@id", id);

                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        textBoxUsuario.Text = reader["login"].ToString();
                        textBoxPassword.Text = reader["password"].ToString();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener datos del usuario: " + ex.Message);
                }
            }
        }


        private void comboBoxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxUsuarios.SelectedValue != null)
            {
                int idUsuario = Convert.ToInt32(comboBoxUsuarios.SelectedValue);
                CargarDatosUsuario(idUsuario);
            }
        }

        private void textBoxUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private bool EsPasswordValida(string password)
        {
            if (password.Length < 7)
                return false;

            string especiales = "!@#$%^&*()_+-=[]{}|;:'\",.<>?/";
            return password.Any(c => especiales.Contains(c));
        }


        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (comboBoxUsuarios.SelectedValue == null)
            {
                MessageBox.Show("Selecciona un usuario para actualizar");
                return;
            }

            int idUsuario = Convert.ToInt32(comboBoxUsuarios.SelectedValue);
            string nuevoLogin = textBoxUsuario.Text.Trim();
            string nuevaPassword = textBoxPassword.Text.Trim();

            if (string.IsNullOrEmpty(nuevoLogin) || string.IsNullOrEmpty(nuevaPassword))
            {
                MessageBox.Show("El usuario y la contraseña no pueden estar vacíos");
                return;
            }

            if (!EsPasswordValida(nuevaPassword))
            {
                MessageBox.Show("La contraseña debe tener al menos 7 caracteres y un carácter especial.");
                return;
            }

            string connectionString = "Server=DESKTOP-5EQEKKJ\\SQLEXPRESS;Database=formulario;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = "UPDATE login SET login = @login, password = @password WHERE id = @id";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@login", nuevoLogin);
                    command.Parameters.AddWithValue("@password", nuevaPassword);
                    command.Parameters.AddWithValue("@id", idUsuario);

                    int filasAfectadas = command.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Usuario actualizado correctamente");

                        CargarUsuarios();

                        comboBoxUsuarios.SelectedValue = idUsuario;
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el usuario");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar usuario: " + ex.Message);
                }
            }
        }

        private void UserControlSeguridad_Load(object sender, EventArgs e)
        {

        }
    }
}
