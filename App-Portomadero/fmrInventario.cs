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
using Capa_Logica;

namespace App_Portomadero
{
    public partial class fmrInventario : Form
    {
        string usuario;
        public fmrInventario(string user)
        {
            InitializeComponent();
            usuario = user;
        }
        private Bitmap CaptureForm()
        {
            // Captura el contenido completo del formulario
            Bitmap screenshot = new Bitmap(750, 850);
            this.DrawToBitmap(screenshot, new System.Drawing.Rectangle(0, 0, this.Width, this.Height));
            return screenshot;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
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
                clsInventario inventario = new clsInventario();
                for(int fila = 0; fila < dgvInventario.Rows.Count; fila++)
                {
                    inventario.Pd_Item = dgvInventario.Rows[fila].Cells[0].Value.ToString();
                    inventario.Pd_Cantidad = dgvInventario.Rows[fila].Cells[2].Value.ToString();
                    inventario.actualizarItem();
                }
                fmrInventario_Load(sender, e);
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmrInventario_Load(object sender, EventArgs e)
        {
            dgvInventario.Rows.Clear();
            lbUsuario.Text = usuario;
            DataTable data = new DataTable();
            clsInventario inventario = new clsInventario();
            data = inventario.cargarInventario();
            for(int fila = 0; fila < data.Rows.Count; fila++)
            {
                dgvInventario.Rows.Add();
                dgvInventario.Rows[fila].Cells[0].Value = data.Rows[fila][0].ToString();
                dgvInventario.Rows[fila].Cells[1].Value = data.Rows[fila][1].ToString();
                dgvInventario.Rows[fila].Cells[2].Value = "";
            }
        }
    }
}
