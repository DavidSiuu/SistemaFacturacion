using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRACTICA_AEAE_2
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            UserControlInicio inicio = new UserControlInicio();
            inicio.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(inicio);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       

        private void fACTURASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            UserControlFacturas facturas = new UserControlFacturas();
            facturas.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(facturas);
        }

        private void cLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Clic en Clientes detectado");

            panelContenido.Controls.Clear();

            UserControlClientes clientes = new UserControlClientes();
            clientes.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(clientes);
        }


        private void pRODUCTOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            UserControlProductos productos = new UserControlProductos();
            productos.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(productos);
        }

        private void iNFORMESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            UserControlInforme informe = new UserControlInforme();
            informe.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(informe);
        }

        private void eMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            UserControlEmpleados empleados = new UserControlEmpleados();
            empleados.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(empleados);
        }

        private void sEGURIDADToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            UserControlSeguridad seguridad = new UserControlSeguridad();
            seguridad.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(seguridad);
        }

        private void aYUDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            UserControlAyuda ayuda = new UserControlAyuda();
            ayuda.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(ayuda);
        }

        private void buttomLeftSession_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show(
                "¿Estás seguro de que deseas cerrar sesión?",
                "Cerrar sesión",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                FrmLogin loginForm = new FrmLogin();
                loginForm.Show();

                this.Close();
            }
        }



        private void panelContenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iNICIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            UserControlInicio inicio = new UserControlInicio();
            inicio.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(inicio);
        }

     private void buttonExitApplication_Click_1(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "¿Estás seguro de que deseas salir de la aplicación?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void aCERCADEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelContenido.Controls.Clear();

            UserControlAcercaDe acercaDe = new UserControlAcercaDe();
            acercaDe.Dock = DockStyle.Fill;

            panelContenido.Controls.Add(acercaDe);
        }
    }
}
