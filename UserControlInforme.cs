using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PRACTICA_AEAE_2
{
    public partial class UserControlInforme : UserControl
    {
        public UserControlInforme()
        {
            InitializeComponent();
        }

        private void UserControlInforme_Load(object sender, EventArgs e)
        {
          
            comboBoxtTiposInforme.Items.Clear();
            comboBoxtTiposInforme.Items.Add("Seleccione un tipo de informe...");
            comboBoxtTiposInforme.Items.Add("Usuarios Registrados");
            comboBoxtTiposInforme.Items.Add("Clientes");
            comboBoxtTiposInforme.Items.Add("Productos");
            comboBoxtTiposInforme.Items.Add("Empleados");
            comboBoxtTiposInforme.Items.Add("Facturas");
            comboBoxtTiposInforme.Items.Add("TODO");

            comboBoxtTiposInforme.SelectedIndex = 0;

            buttonGenerarInforme.Enabled = false;
        }

      

        private void buttonGenerarInforme_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-5EQEKKJ\\SQLEXPRESS;Database=formulario;Trusted_Connection=True;";
            string seleccion = comboBoxtTiposInforme.SelectedItem.ToString();

            string fileName = $"Informe_{DateTime.Now:yyyyMMdd_HHmmss}.pdf";
            string outputPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

            try
            {
                using (FileStream fs = new FileStream(outputPath, FileMode.Create, FileAccess.Write, FileShare.None))
                using (Document doc = new Document(PageSize.A4))
                {
                    PdfWriter writer = PdfWriter.GetInstance(doc, fs);
                    doc.Open();

                    doc.Add(new Paragraph("INFORME GENERADO"));
                    doc.Add(new Paragraph("Fecha: " + DateTime.Now.ToString("dd/MM/yyyy")));
                    doc.Add(new Paragraph("\n"));

                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();

                        switch (seleccion)
                        {
                            case "Usuarios Registrados":
                                AgregarTablaPDF(doc, conn, "Usuarios Registrados", "SELECT login, password FROM Login");
                                break;
                            case "Clientes":
                                AgregarTablaPDF(doc, conn, "Clientes", "SELECT NombreCliente, Documento, Direccion, Telefono, Email FROM Clientes");
                                break;
                            case "Productos":
                                AgregarTablaPDF(doc, conn, "Productos", "SELECT nombreProducto, codigo, precio, cantidad, categoria, descripcion FROM Productos");
                                break;
                            case "Empleados":
                                AgregarTablaPDF(doc, conn, "Empleados", "SELECT nombreEmpleado, documento, direccion, telefono, email, rol, fechaIngreso, fechaRetiro FROM Empleados");
                                break;
                            case "Facturas":
                                AgregarTablaPDF(doc, conn, "Facturas", "SELECT numeroFactura, cliente, empleado, descuento, fechaRegistro, estadoFactura, totalIva, totalFactura FROM Facturas");
                                break;
                            case "TODO":
                                AgregarTablaPDF(doc, conn, "Usuarios Registrados", "SELECT login, password FROM Login");
                                AgregarTablaPDF(doc, conn, "Clientes", "SELECT NombreCliente, Documento, Direccion, Telefono, Email FROM Clientes");
                                AgregarTablaPDF(doc, conn, "Productos", "SELECT nombreProducto, codigo, precio, cantidad, categoria, descripcion FROM Productos");
                                AgregarTablaPDF(doc, conn, "Empleados", "SELECT nombreEmpleado, documento, direccion, telefono, email, rol, fechaIngreso, fechaRetiro FROM Empleados");
                                AgregarTablaPDF(doc, conn, "Facturas", "SELECT numeroFactura, cliente, empleado, descuento, fechaRegistro, estadoFactura, totalIva, totalFactura FROM Facturas");
                                break;
                        }

                        conn.Close();
                    }

                    doc.Close();
                }

                MessageBox.Show($"Informe generado correctamente en:\n{outputPath}", "Informe PDF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                System.Diagnostics.Process.Start(outputPath); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al generar el PDF:\n" + ex.Message);
            }
        }


        private void AgregarTablaPDF(Document doc, SqlConnection conn, string titulo, string query)
        {
            Paragraph tituloParrafo = new Paragraph($"{titulo.ToUpper()}", FontFactory.GetFont("Arial", 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK));
            tituloParrafo.SpacingBefore = 20f;
            tituloParrafo.SpacingAfter = 10f;
            doc.Add(tituloParrafo);

            using (SqlCommand cmd = new SqlCommand(query, conn))
            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                PdfPTable table = new PdfPTable(reader.FieldCount);
                table.WidthPercentage = 100;
                table.SpacingAfter = 20f;

                Font fontHeader = FontFactory.GetFont("Arial", 10, iTextSharp.text.Font.BOLD, BaseColor.WHITE);
                Font fontCell = FontFactory.GetFont("Arial", 9, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                for (int i = 0; i < reader.FieldCount; i++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(reader.GetName(i), fontHeader))
                    {
                        BackgroundColor = new BaseColor(106, 64, 64), 
                        HorizontalAlignment = Element.ALIGN_CENTER,
                        Padding = 5
                    };
                    table.AddCell(cell);
                }

                while (reader.Read())
                {
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(reader[i]?.ToString(), fontCell))
                        {
                            Padding = 4,
                            HorizontalAlignment = Element.ALIGN_CENTER
                        };
                        table.AddCell(cell);
                    }
                }

                doc.Add(table);
            }
        }

        private void comboBoxtTiposInforme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxtTiposInforme.SelectedIndex > 0)
            {
                buttonGenerarInforme.Enabled = true;
            }
            else
            {
                buttonGenerarInforme.Enabled = false;
            }
        }

        private void buttonGenerarInformeExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
