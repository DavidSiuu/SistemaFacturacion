using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PRACTICA_AEAE_2
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxLoginPassword.PasswordChar = '*';
            btnVerPassword.BringToFront();
        }


        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLoginPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelLoginPassword_Click(object sender, EventArgs e)
        {

        }

        private bool EsPasswordValida(string password)
        {
            if (password.Length < 7)
                return false;

            string especiales = "!@#$%^&*()_+-=[]{}|;:'\",.<>?/";
            bool contieneEspecial = password.Any(c => especiales.Contains(c));

            return contieneEspecial;
        }

        private void buttonEnterUser_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-5EQEKKJ\\SQLEXPRESS;Database=formulario;Trusted_Connection=True;";

            string user = textBoxLogin.Text;
            string pass = textBoxLoginPassword.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Por favor, complete ambos campos");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string checkUserQuery = "SELECT COUNT(*) FROM login WHERE login = @login";
                    SqlCommand checkUserCmd = new SqlCommand(checkUserQuery, connection);
                    checkUserCmd.Parameters.AddWithValue("@login", user);

                    int userExists = (int)checkUserCmd.ExecuteScalar();

                    if (userExists == 0)
                    {
                        MessageBox.Show("USUARIO NO ENCONTRADO, por favor regístrese");
                        return;
                    }

                    string query = "SELECT COUNT(*) FROM login WHERE login = @login AND password = @password";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@login", user);
                    cmd.Parameters.AddWithValue("@password", pass);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("¡Inicio de sesión exitoso!");

                        Inicio ventanaInicio = new Inicio();
                        ventanaInicio.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrectos.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }






        private void buttonRegistrerUser_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-5EQEKKJ\\SQLEXPRESS;Database=formulario;Trusted_Connection=True;";

            string user = textBoxLogin.Text;
            string pass = textBoxLoginPassword.Text;

            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                MessageBox.Show("Por favor, complete ambos campos");
                return;
            }

            if (!EsPasswordValida(pass))
            {
                MessageBox.Show("La contraseña debe tener al menos 7 caracteres y un carácter especial");
                return;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string checkQuery = "SELECT COUNT(*) FROM login WHERE login = @login";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, connection);
                    checkCmd.Parameters.AddWithValue("@login", user);

                    int exists = (int)checkCmd.ExecuteScalar();

                    if (exists > 0)
                    {
                        MessageBox.Show("El usuario ya está registrado, por favor inicie sesión");
                    }
                    else
                    {
                        string insertQuery = "INSERT INTO login (login, password) VALUES (@login, @password)";
                        SqlCommand insertCmd = new SqlCommand(insertQuery, connection);
                        insertCmd.Parameters.AddWithValue("@login", user);
                        insertCmd.Parameters.AddWithValue("@password", pass);

                        int rowsInserted = insertCmd.ExecuteNonQuery();

                        if (rowsInserted > 0)
                        {
                            MessageBox.Show("Usuario registrado exitosamente");

                            Inicio ventanaInicio = new Inicio();
                            ventanaInicio.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo registrar el usuario");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }


        private void btnVerPassword_Click(object sender, EventArgs e)
        {
            if (textBoxLoginPassword.PasswordChar == '*')
            {
                btnNoVerPassword.BringToFront(); 
                textBoxLoginPassword.PasswordChar = '\0'; 
            }
        }

        private void btnNoVerPassword_Click(object sender, EventArgs e)
        {
            if (textBoxLoginPassword.PasswordChar == '\0')
            {
                btnVerPassword.BringToFront(); 
                textBoxLoginPassword.PasswordChar = '*'; 
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
