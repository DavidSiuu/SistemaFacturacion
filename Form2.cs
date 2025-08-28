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

        }

        private void eMPLEADOToolStripMenuItem_Click(object sender, EventArgs e)
        {

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

        }

        private void buttomLeftSession_Click(object sender, EventArgs e)
        {

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
    }
}
