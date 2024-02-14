using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks.Printing;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using System.Drawing.Printing;

namespace App_Portomadero
{
    public partial class fmrImprimir : Form
    {
        private PrintDocument printDocument = new PrintDocument();
        public fmrImprimir(string cliente, string vendedor,string NumFac, DataGridView dataGrid, string total, string pago, string cambio)
        {
            InitializeComponent();
            lbNomCliente.Text = cliente;
            lbNomVendedor.Text = vendedor;
            lbNumFac.Text = NumFac;
            lbPagar.Text = total;
            lbCliente.Text = pago;
            lbCambio.Text = cambio;
            DateTime time = DateTime.Now;
            lbFecha.Text = time.ToLongDateString();
            lbHora.Text = time.ToLongTimeString();
            for (int fila = 0; fila < dataGrid.Rows.Count; fila++)
            {
                dgvFactura.Rows.Add();
                dgvFactura.Rows[fila].Cells[0].Value = dataGrid.Rows[fila].Cells[0].Value;
                dgvFactura.Rows[fila].Cells[1].Value = dataGrid.Rows[fila].Cells[1].Value;
                dgvFactura.Rows[fila].Cells[2].Value = dataGrid.Rows[fila].Cells[2].Value;
                dgvFactura.Rows[fila].Cells[3].Value = dataGrid.Rows[fila].Cells[3].Value;
            }
            pictureBox1.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            PrintForm printForm = new PrintForm();
            printForm.Form = this;
            printForm.PrinterSettings.DefaultPageSettings.Landscape = false;
            printForm.PrinterSettings.DefaultPageSettings.Color = false;
            printForm.PrinterSettings.DefaultPageSettings.Margins.Left = 0;
            printForm.PrinterSettings.DefaultPageSettings.Margins.Top = 0;
            printForm.PrinterSettings.DefaultPageSettings.PrinterResolution =  new PrinterResolution { Kind = PrinterResolutionKind.High };
            printForm.PrinterSettings.DefaultPageSettings.PaperSize = new PaperSize("POS",420,780);
            printForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview;
            printForm.Print(this, PrintForm.PrintOption.ClientAreaOnly);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Bitmap CaptureForm()
        {
            // Captura el contenido completo del formulario
            Bitmap screenshot = new Bitmap(400, 750);
            this.DrawToBitmap(screenshot, new System.Drawing.Rectangle(0, 0, this.Width, this.Height));
            return screenshot;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Captura el contenido del formulario como una imagen (screenshot)
            Bitmap screenshot = CaptureForm();

            // Cuadro de diálogo para seleccionar la ubicación y el nombre del archivo PDF
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Archivo PDF|*.pdf";
            saveFileDialog.Title = "Guardar como PDF";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string rutaPDF = saveFileDialog.FileName;

                using (FileStream fs = new FileStream(rutaPDF, FileMode.Create))
                {
                    Document doc = new Document(new iTextSharp.text.Rectangle(screenshot.Width, screenshot.Height));
                    PdfWriter.GetInstance(doc, fs);
                    doc.Open();

                    // Agregar la captura de pantalla al PDF
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(screenshot, BaseColor.WHITE);
                    doc.Add(img);

                    doc.Close();
                }

                MessageBox.Show("El archivo PDF se ha guardado con éxito.");
            }
        }

        private void fmrImprimir_Load(object sender, EventArgs e)
        {
            dgvFactura.ClearSelection();
            dgvFactura.Enabled = false;
        }
    }
}
