using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Portomadero
{
    public partial class fmrModificarMesa : Form
    {
        Button boton;
        string ruta;
        fmrMesas principal;
        public fmrModificarMesa(Button button, string imagen, fmrMesas form)
        {
            InitializeComponent();
            boton = button;
            ruta = imagen;
            principal = form;
        }

        private void fmrModificarMesa_Load(object sender, EventArgs e)
        {
            txtNombre.Text = boton.Text;
            pbImagen.ImageLocation = ruta;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Title = "Selecciona una imagen";
            abrir.Filter = "PNG |*.png| JPG |*.jpg";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                principal.nuevaRuta = abrir.FileName.ToString();
                pbImagen.ImageLocation = abrir.FileName;
                pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            boton.BackgroundImage = Image.FromFile(principal.nuevaRuta);
            boton.Text = txtNombre.Text;
            this.Close();
        }
    }
}
