using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica;
using System.IO;

namespace App_Portomadero
{
    public partial class fmrProducto : Form
    {
        int dato;
        string product;
        string usuario;
        string rol;
        public fmrProducto(int entrada,string nombre,string user,string role)
        {
            InitializeComponent();
            dato = entrada;
            product = nombre;
            usuario = user;
            rol = role;
        }
        private void btnCargar_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Title = "Selecciona una imagen";
            abrir.Filter = "PNG |*.png| JPG |*.jpg";
            if(abrir.ShowDialog() == DialogResult.OK)
            {
                tbRuta.Text = abrir.FileName.ToString();
                pbImagen.ImageLocation = abrir.FileName;
                pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            }
        }

        private void fmrProducto_Load(object sender, EventArgs e)
        {
            tbNombre.Focus();
            cbUnidad.Items.Add("");
            cbUnidad.Items.Add("und");
            cbUnidad.Items.Add("kg");
            cbUnidad.Items.Add("ml");
            cbUnidad.Items.Add("mts");
            clsProducto producto = new clsProducto();
            DataTable data = new DataTable();
            data = producto.cargarCategorias();
            cbCategoria.Items.Add("");
            for(int fila = 0; fila < data.Rows.Count; fila++)
            {
                cbCategoria.Items.Add(data.Rows[fila][0].ToString());
            }
            data = producto.cargarCentroCostos();
            for (int fila = 0; fila < data.Rows.Count; fila++)
            {
                cbCentro.Items.Add(data.Rows[fila][0].ToString());
            }
            if (dato == 0)
            {
                btnBorrar.Visible = false;
                tbNombre.Enabled = true;
            }
            else
            {
                try
                {
                    btnBorrar.Visible = true;
                    tbNombre.Enabled = false;
                    data = producto.cargarDatos(product);
                    dato = int.Parse(data.Rows[0][0].ToString());
                    tbNombre.Text = product;
                    cbCategoria.Text = data.Rows[0][2].ToString();
                    pbImagen.ImageLocation = data.Rows[0][3].ToString();
                    pbImagen.SizeMode = PictureBoxSizeMode.StretchImage;
                    tbRuta.Text = data.Rows[0][3].ToString();
                    tbCompra.Text = data.Rows[0][4].ToString();
                    tbVenta.Text = data.Rows[0][5].ToString();
                    tbCantidad.Text = data.Rows[0][6].ToString();
                    cbUnidad.Text = data.Rows[0][7].ToString();
                    cbCentro.Text = data.Rows[0][9].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo cargar el producto " + ex);
                    this.Close();
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text != "" & cbCategoria.Text != "" & tbCompra.Text != "" & tbVenta.Text != "" & tbCantidad.Text != "" & cbUnidad.Text != "")
            {
                if(float.TryParse(tbCompra.Text,out _) & float.TryParse(tbVenta.Text, out _) & float.TryParse(tbCantidad.Text,out _))
                {
                    if (dato == 0)
                    {
                        try
                        {
                            clsProducto producto = new clsProducto();
                            producto.Pd_Nombre = tbNombre.Text;
                            producto.Pd_Categoria = cbCategoria.Text;
                            if (tbRuta.Text.Length == 0)
                            {
                                string nombreImagen = "Producto-sin-imagen.jpg"; // Reemplaza con el nombre de tu imagen
                                string rutaImagen = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nombreImagen);
                                producto.Pd_Foto = rutaImagen;
                            }
                            else
                            {
                                producto.Pd_Foto = tbRuta.Text;
                            }
                            producto.Pd_Costo = tbCompra.Text;
                            producto.Pd_Precio = tbVenta.Text;
                            producto.Pd_Cantidad = tbCantidad.Text;
                            producto.Pd_Unidad = cbUnidad.Text;
                            producto.Pd_Usuario = usuario;
                            producto.Pd_CentroCostos = cbCentro.Text;
                            producto.agregarProducto();
                            MessageBox.Show("El producto fue agregado exitosamente");
                            Limpiar();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("no se pudo agregar el producto " + ex);
                        }
                    }
                    else
                    {
                        clsProducto producto = new clsProducto();
                        producto.Pd_Nombre = tbNombre.Text;
                        producto.Pd_Categoria = cbCategoria.Text;
                        producto.Pd_Foto = tbRuta.Text;
                        producto.Pd_Costo = tbCompra.Text;
                        producto.Pd_Precio = tbVenta.Text;
                        producto.Pd_Cantidad = tbCantidad.Text;
                        producto.Pd_Unidad = cbUnidad.Text;
                        producto.Pd_Usuario = usuario;
                        producto.Pd_CentroCostos = cbCentro.Text;
                        producto.editarProducto(dato);
                        MessageBox.Show("El producto fue editado correctamente");
                        Limpiar();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Los campos de costo, precio y/o cantidad no son numéricos");
                }
            }
            else
            {
                MessageBox.Show("Faltan datos por ingresar");
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseas eliminar este producto?", "CONFIRMACION", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(result == DialogResult.Yes)
            {
                if(rol == "Administrador")
                {
                    clsProducto producto = new clsProducto();
                    producto.borrarProducto(dato);
                    MessageBox.Show("El producto ha sido eliminado");
                    Close();
                }
                else
                {
                    MessageBox.Show("Solo los administradores pueden eliminar un producto");
                }
            }
        }
        private void Limpiar()
        {
            tbNombre.Text = "";
            tbRuta.Text = "";
            tbCompra.Text = "";
            tbVenta.Text = "";
            tbCantidad.Text = "";
            cbCategoria.SelectedIndex = 0;
            cbUnidad.SelectedIndex = 0;
            pbImagen.Image = null;
            cbCentro.SelectedIndex = 0;
        }
    }
}
