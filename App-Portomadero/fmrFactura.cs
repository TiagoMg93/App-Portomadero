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
using System.Drawing.Printing;
using System.IO;
using Capa_Logica;

namespace App_Portomadero
{
    public partial class fmrFactura : Form
    {
        string usuario;
        DataGridView view = null;
        string identificador = "";
        public fmrFactura(string nombre, DataGridView data, string id)
        {
            InitializeComponent();
            usuario = nombre;
            view = data;
            identificador = id;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmrFactura_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            clsFactura factura = new clsFactura();
            dt = factura.cargarCategorias();
            for (int fila = 0; fila < dt.Rows.Count; fila++)
            {
                agregarBoton(dt.Rows[fila][0].ToString());
            }
            dt.Clear();
            dt = factura.cargarProductos();
            for(int fila = 0; fila < dt.Rows.Count; fila++)
            {
                agregarPanel(dt.Rows[fila][0].ToString(), dt.Rows[fila][1].ToString());
            }
            dt.Clear();
            dt = factura.cargarClientes();
            for (int fila = 0; fila < dt.Rows.Count; fila++)
            {
                cbCliente.Items.Add(dt.Rows[fila][0].ToString());
            }
            tbVendedor.Text = usuario;
            dt.Clear();
            dt = factura.cargarNumFac();
            int fac = int.Parse(dt.Rows[0][0].ToString()) + 1;
            lbNumFac.Text = fac.ToString();
            if(view != null)
            {
                DataTable dataTable = new DataTable();
                dataTable = factura.productoPendiente(identificador);
                for(int fila = 0; fila < dataTable.Rows.Count; fila++)
                {
                    dt.Clear();
                    dt = factura.buscarProducto(dataTable.Rows[fila][0].ToString());
                    float subtotal = float.Parse(dt.Rows[0][1].ToString()) * float.Parse(dataTable.Rows[fila][1].ToString());
                    dgvFactura.Rows.Add($"{dt.Rows[0][0].ToString()}", dataTable.Rows[fila][1].ToString(), $"{dt.Rows[0][1].ToString()}",subtotal);
                }
                float total = 0;
                for (int fila = 0; fila < dgvFactura.Rows.Count; fila++)
                {
                    total += float.Parse(dgvFactura.Rows[fila].Cells[3].Value.ToString());
                }
                tbPago.Text = total.ToString();
            }
        }
        private void agregarBoton(string nombre)
        {
            Button button = new Button();
            button.BackColor = System.Drawing.Color.LightSkyBlue;
            button.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            button.FlatAppearance.BorderSize = 2;
            button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            button.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            button.Location = new System.Drawing.Point(76, 114);
            button.Name = "btn"+nombre;
            button.Size = new System.Drawing.Size(130, 40);
            button.Text = nombre;
            button.UseVisualStyleBackColor = false;
            button.Click += new EventHandler(Categoria_Click);
            flpCategorias.Controls.Add(button);
        }
        private void agregarPanel(string nombre, string Foto)
        {
            PictureBox pbImagen = new PictureBox();
            pbImagen.Dock = System.Windows.Forms.DockStyle.Top;
            pbImagen.Location = new System.Drawing.Point(0, 0);
            pbImagen.Size = new System.Drawing.Size(120, 120);
            pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pbImagen.ImageLocation = Foto;
            pbImagen.TabIndex = 0;
            pbImagen.TabStop = false;
            Button lbProducto = new Button();
            lbProducto.AutoSize = true;
            lbProducto.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lbProducto.Location = new System.Drawing.Point(41, 128);
            lbProducto.Size = new System.Drawing.Size(47, 30);
            lbProducto.Text = nombre;
            lbProducto.Click += new EventHandler(Button_Click);
            lbProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            lbProducto.FlatStyle = FlatStyle.Flat;
            //lbProducto.BackColor = System.Drawing.Color.MediumBlue;
            lbProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CadetBlue;
            lbProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            Panel pnlProducto = new Panel();
            pnlProducto.Controls.Add(lbProducto);
            pnlProducto.Controls.Add(pbImagen);
            pnlProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pnlProducto.Location = new System.Drawing.Point(308, 64);
            pnlProducto.Size = new System.Drawing.Size(160, 180);
            flpProductos.Controls.Add(pnlProducto);
        }
        private void Button_Click(object sender, EventArgs e)
        {
            Button click = sender as Button;
            if(click != null)
            {
                string nombre = click.Text;
                tbProducto.Text = nombre;
            }
        }
        private void Categoria_Click(object sender, EventArgs e)
        {
            clsFactura factura = new clsFactura();
            DataTable dt = new DataTable();
            Button click = sender as Button;
            int paneles = flpProductos.Controls.Count;
            for(int panel = 0; panel < paneles; panel++)
            {
                Control control = flpProductos.Controls[0];
                flpProductos.Controls.Remove(control);
            }
            if (click != null)
            {
                string nombre = click.Text;
                dt = factura.consultarProductos(nombre);
                for (int fila = 0; fila < dt.Rows.Count; fila++)
                {
                    agregarPanel(dt.Rows[fila][0].ToString(), dt.Rows[fila][1].ToString());
                }
            }
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void vScrollBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCantidad_Click(object sender, EventArgs e)
        {
            clsFactura factura = new clsFactura();
            DataTable dt = new DataTable();
            dt = factura.consultarInventario(tbProducto.Text);
            if(tbProducto.Text != "")
            {
                if (tbCantidad.Text != "")
                {
                    if (float.TryParse((tbCantidad.Text), out _))
                    {
                        if (float.Parse(dt.Rows[0][0].ToString()) < float.Parse(tbCantidad.Text))
                        {
                            MessageBox.Show("La cantidad ingresada excede el inventario existente del articulo");
                        }
                        else
                        {
                            float nuevaCantidad;
                            if (dgvFactura.Rows.Count == 0)
                            {
                                dt.Clear();
                                dt = factura.consultarPrecio(tbProducto.Text);
                                dgvFactura.Rows.Add(tbProducto.Text, tbCantidad.Text, dt.Rows[0][0].ToString(), float.Parse(tbCantidad.Text) * float.Parse(dt.Rows[0][0].ToString()));
                                tbCantidad.Text = "";
                                tbProducto.Text = "";
                            }
                            else
                            {
                                bool repetido = false;
                                int posicion = 9999;
                                for (int fila = 0; fila < dgvFactura.Rows.Count; fila++)
                                {
                                    if (dgvFactura.Rows[fila].Cells[0].Value.ToString() == tbProducto.Text)
                                    {
                                        repetido = true;
                                        posicion = fila;
                                    }
                                }
                                if (repetido != true)
                                {
                                    dt.Clear();
                                    dt = factura.consultarPrecio(tbProducto.Text);
                                    string texto = dt.Rows[0][0].ToString();
                                    dgvFactura.Rows.Add(tbProducto.Text, tbCantidad.Text, dt.Rows[0][0].ToString(), float.Parse(tbCantidad.Text) * float.Parse(dt.Rows[0][0].ToString()));
                                    tbCantidad.Text = "";
                                    tbProducto.Text = "";
                                }
                                else
                                {
                                    nuevaCantidad = float.Parse(tbCantidad.Text) + float.Parse(dgvFactura.Rows[posicion].Cells[1].Value.ToString());
                                    if (float.Parse(dt.Rows[0][0].ToString()) < nuevaCantidad)
                                    {
                                        MessageBox.Show("La cantidad ingresada excede el inventario existente del articulo");
                                    }
                                    else
                                    {
                                        dgvFactura.Rows[posicion].Cells[1].Value = nuevaCantidad;
                                        dgvFactura.Rows[posicion].Cells[3].Value = nuevaCantidad * float.Parse(dgvFactura.Rows[posicion].Cells[2].Value.ToString());
                                        dt.Clear();
                                        tbCantidad.Text = "";
                                        tbProducto.Text = "";
                                        posicion = 9999;
                                        repetido = false;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("El campo cantidad no es numérico");
                    }
                }
                else
                {
                    MessageBox.Show("Debes ingresar una cantidad");
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto primero");
            }
            float total = 0;
            for(int fila = 0; fila < dgvFactura.Rows.Count; fila++)
            {
                total += float.Parse(dgvFactura.Rows[fila].Cells[3].Value.ToString());
            }
            tbPago.Text = total.ToString();
        }

        private void dgvFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvFactura.Columns[e.ColumnIndex].Name == "Borrar")
                {
                    dgvFactura.Rows.Remove(dgvFactura.CurrentRow);
                    float total = 0;
                    for (int fila = 0; fila < dgvFactura.Rows.Count; fila++)
                    {
                        total += float.Parse(dgvFactura.Rows[fila].Cells[3].Value.ToString());
                    }
                    tbPago.Text = total.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se logro borrar el articulo de la lista " + ex);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if(tbCliente.Text == "" || tbPago.Text == "0" || cbCliente.Text == "")
            {
                MessageBox.Show("Debes ingresar un articulo ,el cliente y/o el pago del cliente");
            }
            else
            {
                if(float.TryParse((tbCliente.Text),out _))
                {
                    DialogResult resultado = MessageBox.Show("¿Seguro que desea facturar? se descontaran los articulos del inventario", "CONFIRMAR VENTA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (resultado == DialogResult.Yes)
                    {
                        fmrImprimir imprimir = new fmrImprimir(cbCliente.Text, tbVendedor.Text, lbNumFac.Text, dgvFactura, tbPago.Text, tbCliente.Text, tbCambio.Text);
                        imprimir.Show();
                        float cantidad = 0;
                        DataTable dt = new DataTable();
                        clsFactura factura = new clsFactura();
                        if(identificador == "")
                        {
                            for (int fila = 0; fila < dgvFactura.Rows.Count; fila++)
                            {
                                dt = factura.consultarInventario(dgvFactura.Rows[fila].Cells[0].Value.ToString());
                                cantidad = float.Parse(dt.Rows[0][0].ToString()) - float.Parse(dgvFactura.Rows[fila].Cells[1].Value.ToString());
                                factura.Pd_Cantidad = cantidad.ToString();
                                factura.actualizarInventario(dgvFactura.Rows[fila].Cells[0].Value.ToString());
                                factura.agregarFactura(lbNumFac.Text, dgvFactura.Rows[fila].Cells[0].Value.ToString(), dgvFactura.Rows[fila].Cells[1].Value.ToString(), dgvFactura.Rows[fila].Cells[3].Value.ToString(), tbVendedor.Text, cbCliente.Text);
                            }
                            Limpiar();
                        }
                        else
                        {
                            for (int fila = 0; fila < dgvFactura.Rows.Count; fila++)
                            {
                                dt = factura.consultarInventario(dgvFactura.Rows[fila].Cells[0].Value.ToString());
                                cantidad = float.Parse(dt.Rows[0][0].ToString()) - float.Parse(dgvFactura.Rows[fila].Cells[1].Value.ToString());
                                factura.Pd_Cantidad = cantidad.ToString();
                                factura.actualizarInventario(dgvFactura.Rows[fila].Cells[0].Value.ToString());
                                factura.agregarFactura(lbNumFac.Text, dgvFactura.Rows[fila].Cells[0].Value.ToString(), dgvFactura.Rows[fila].Cells[1].Value.ToString(), dgvFactura.Rows[fila].Cells[3].Value.ToString(), tbVendedor.Text, cbCliente.Text);
                                factura.modificarPedido(dgvFactura.Rows[fila].Cells[0].Value.ToString(), identificador);
                            }
                            Limpiar();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Debes ingresar un valor numérico en el campo de pago cliente");
                }
            }
        }

        private void tbCliente_Leave(object sender, EventArgs e)
        {
            if (float.TryParse((tbCliente.Text), out _))
            {
                if (float.Parse(tbCliente.Text) - float.Parse(tbPago.Text) < 0)
                {
                    MessageBox.Show("El pago del cliente es insuficiente para lo adeudado");
                }
                else
                {
                    tbCambio.Text = Convert.ToString((float.Parse(tbCliente.Text) - float.Parse(tbPago.Text)));
                }
            }
            else
            {
                MessageBox.Show("Debes ingresar un valor numérico en el campo de pago cliente");
            }
        }
        private void Limpiar()
        {
            tbCambio.Text = "";
            tbCliente.Text = "";
            tbPago.Text = "";
            dgvFactura.Rows.Clear();
            cbCliente.ResetText();
            tbCantidad.Text = "";
            cbCliente.Items.Clear();
            tbProducto.Text = "";
            flpCategorias.Controls.Clear();
            flpProductos.Controls.Clear();
            DataTable dt = new DataTable();
            clsFactura factura = new clsFactura();
            dt = factura.cargarCategorias();
            for (int fila = 0; fila < dt.Rows.Count; fila++)
            {
                agregarBoton(dt.Rows[fila][0].ToString());
            }
            dt.Clear();
            dt = factura.cargarProductos();
            for (int fila = 0; fila < dt.Rows.Count; fila++)
            {
                agregarPanel(dt.Rows[fila][0].ToString(), dt.Rows[fila][1].ToString());
            }
            dt.Clear();
            dt = factura.cargarClientes();
            for (int fila = 0; fila < dt.Rows.Count; fila++)
            {
                cbCliente.Items.Add(dt.Rows[fila][0].ToString());
            }
            tbVendedor.Text = usuario;
            dt.Clear();
            dt = factura.cargarNumFac();
            int fac = int.Parse(dt.Rows[0][0].ToString()) + 1;
            lbNumFac.Text = fac.ToString();
        }
    }
}
