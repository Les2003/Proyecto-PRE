using System;
using iText.IO.Font;
using iText.IO.Image;
using iText.Kernel.Colors;
using iText.Kernel.Font;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Proyecto_3
{
    public partial class Agenda : Form
    { 
        public Agenda()
        {
            InitializeComponent();
        }

        private void agendaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.agendaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.agendaDataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'agendaDataSet.Agenda' Puede moverla o quitarla según sea necesario.
            this.agendaTableAdapter.Fill(this.agendaDataSet.Agenda);

        }

        private void nombreTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 regreso = new Form1();
            regreso.Show();
        }

        private void hora_de_reservaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
        private void pdf_Click(object sender, EventArgs e)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\DocumentosPDF\";
            var exportaPDF = Path.Combine(path, "Documento.pdf");
            using (var writer = new PdfWriter(exportaPDF))
            {
                using (var pdf = new PdfDocument(writer))
                {
                    var doc = new Document(pdf, iText.Kernel.Geom.PageSize.A4);
                    //margenes de pdf
                    doc.SetMargins(90, 0, 0, 0);

                    string nombreEmpresa = "Don Bosco Airlines";
                    string direccionSucursal = "El Salvador";

                    PdfFont boldFont = PdfFontFactory.CreateFont();
                    iText.Kernel.Colors.Color colorWhite = new DeviceRgb(255, 255, 255);
                    iText.Kernel.Colors.Color colorNegro = new DeviceRgb(0, 0, 0);
                    iText.Kernel.Colors.Color colorAzul = new DeviceRgb(0, 92, 226);

                    Paragraph parrafo0 =
                      new Paragraph("Comprobante de reserva de vuelo")
                               .SetFontSize(32)
                               .SetMargins(0, 0, 0, 0)
                               .SetFontColor(colorNegro)
                               .SetFont(boldFont)
                               .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER)
                               .SetTextAlignment(TextAlignment.CENTER);
                    doc.Add(parrafo0);

                    Paragraph parrafo1 =
                    new Paragraph("FECHA CREACIÓN: " + DateTime.Now + "\n").SetFontSize(12)
                      .Add("\n" + nombreEmpresa + " \n").SetFontSize(12)
                      .Add("DIRECCIÓN: " + direccionSucursal + "\n").SetFontSize(12)
                      .SetFontSize(12)
                               .SetMargins(0, 0, 0, 0)
                               .SetFontColor(colorAzul)
                               .SetFont(boldFont)
                               .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER)
                               .SetTextAlignment(TextAlignment.CENTER);
                    doc.Add(parrafo1).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);

                    Paragraph parrafo2 =
                      new Paragraph("\nEstimado cliente su transacción fue exitosa, se adjuntaron los siguientes datos:").SetFontSize(12)
                      .Add("\n\n\nNombre:" + nombreTextBox.Text.ToString())
                      .Add("\nApellido:" + apellidoTextBox.Text.ToString())
                      .Add("\nTelefono:" + telefónoTextBox.Text.ToString())
                      .Add("\nLugar de destino:" + lugar__de_destinoTextBox.Text.ToString())
                      .Add("\nLugar de abordaje:" + lugar_de_abordajeTextBox.Text.ToString())
                      .SetFontSize(12)
                               .SetMargins(0, 0, 0, 0)
                               .SetFontColor(colorNegro)
                               .SetFont(boldFont)
                               .SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER)
                               .SetTextAlignment(TextAlignment.CENTER);
                    doc.Add(parrafo2).SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                }
            }
            try
            {

                if (File.Exists(path + "Document.pdf"))
                {
                    Process.Start(path + "Document.pdf");// ABRO EL ARCHIVO 
                }

            }
            catch (FileNotFoundException a)
            {


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fin fi = new Fin();
            fi.Show();
        }
    }
}
