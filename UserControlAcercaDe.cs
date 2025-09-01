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
    public partial class UserControlAcercaDe : UserControl
    {
        public UserControlAcercaDe()
        {
            InitializeComponent();

            textBoxAutores.Text =
                "- Durley Steven Lopez Padierna\r\n" +
                "- Kassandra Cardona\r\n" +
                "- Juan David Castañeda Jaramillo\r\n" +
                "- David Meneses\r\n";

            textBoxNombrePrograma.Text =
                "SISTEMA FACTURACIÓN";

            textBoxNombreU.Text =
                "INSTITUCIÓN UNIVERSITARIA PASCUAL BRAVO";
        }

        private void textBoxAutores_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombrePrograma_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNombreU_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
