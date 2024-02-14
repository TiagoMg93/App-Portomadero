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

namespace App_Portomadero
{
    public partial class fmrPedido : Form
    {
        int entrada;
        int id;
        string mesas;
        public fmrPedido(int num, int ID)
        {
            InitializeComponent();
            entrada = num;
            id = ID;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmrPedido_Load(object sender, EventArgs e)
        {
            clsPedido pedido = new clsPedido();
            DataTable data = new DataTable();
            if(entrada == 0)
            {
                try
                {
                    btnFacturar.Visible = false;
                    data = pedido.consultarNumPed();
                    int number = int.Parse(data.Rows[0][0].ToString()) + 1;
                    lbNum.Text = number.ToString();
                    data.Rows.Clear();
                    data = pedido.cargarMesas();
                    for (int fila = 0; fila < data.Rows.Count; fila++)
                    {
                        cbMesa.Items.Add(data.Rows[fila][0].ToString());
                    }
                    data.Rows.Clear();
                    data = pedido.cargarEmpleados();
                    for (int fila = 0; fila < data.Rows.Count; fila++)
                    {
                        cbMesero.Items.Add(data.Rows[fila][0].ToString());
                    }
                    data.Rows.Clear();
                    data = pedido.cargarCategorias();
                    cbCategorias.Items.Add("");
                    for (int fila = 0; fila < data.Rows.Count; fila++)
                    {
                        cbCategorias.Items.Add(data.Rows[fila][0].ToString());
                    }
                    data.Rows.Clear();
                    data = pedido.cargarProductos();
                    cbProducto.Items.Add("");
                    for (int fila = 0; fila < data.Rows.Count; fila++)
                    {
                        cbProducto.Items.Add(data.Rows[fila][0].ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudieron actualizar los datos " + ex);
                }
            }
            else
            {
                try
                {
                    btnFacturar.Visible = true;
                    data = pedido.cargarMesas();
                    for (int fila = 0; fila < data.Rows.Count; fila++)
                    {
                        cbMesa.Items.Add(data.Rows[fila][0].ToString());
                        mesas = data.Rows[fila][0].ToString();
                    }
                    data.Rows.Clear();
                    data = pedido.cargarEmpleados();
                    for (int fila = 0; fila < data.Rows.Count; fila++)
                    {
                        cbMesero.Items.Add(data.Rows[fila][0].ToString());
                    }
                    data.Rows.Clear();
                    data = pedido.cargarCategorias();
                    cbCategorias.Items.Add("");
                    for (int fila = 0; fila < data.Rows.Count; fila++)
                    {
                        cbCategorias.Items.Add(data.Rows[fila][0].ToString());
                    }
                    data.Rows.Clear();
                    data = pedido.cargarProductos();
                    cbProducto.Items.Add("");
                    for (int fila = 0; fila < data.Rows.Count; fila++)
                    {
                        cbProducto.Items.Add(data.Rows[fila][0].ToString());
                    }
                    data.Rows.Clear();
                    data = pedido.consultarPedido(id);
                    lbNum.Text = data.Rows[0][0].ToString();
                    cbMesa.Text = data.Rows[0][3].ToString();
                    cbMesero.Text = data.Rows[0][2].ToString();
                    for(int fila = 0; fila < data.Rows.Count; fila++)
                    {
                        dgvPedido.Rows.Add();
                        dgvPedido.Rows[fila].Cells[0].Value = data.Rows[fila][1].ToString();
                        dgvPedido.Rows[fila].Cells[1].Value = data.Rows[fila][7].ToString();
                    }
                    tbComentario.Text = data.Rows[0][8].ToString();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("No se pudieron actualizar los datos " + ex);
                }
            }
        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbProducto.Items.Clear();
            clsPedido pedido = new clsPedido();
            DataTable data = new DataTable();
            try
            {
                data = pedido.consultarProductos(cbCategorias.Text);
                cbProducto.Items.Add("");
                for (int fila = 0; fila < data.Rows.Count; fila++)
                {
                    cbProducto.Items.Add(data.Rows[fila][0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudieron actualizar los productos " + ex);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(cbMesa.Text == "" | cbMesero.Text == "" | cbCategorias.Text == "" | cbProducto.Text == "" | tbCantidad.Text == "")
            {
                MessageBox.Show("Se debe diligenciar todos los campos");
            }
            else
            {
                int fila = dgvPedido.Rows.Count;
                dgvPedido.Rows.Add();
                dgvPedido.Rows[fila].Cells[0].Value = cbProducto.Text;
                dgvPedido.Rows[fila].Cells[1].Value = tbCantidad.Text;
                cbProducto.SelectedItem = 0;
                cbCategorias.SelectedIndex = 0;
                tbCantidad.Text = "";
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            clsPedido pedido = new clsPedido();
            if(entrada == 0)
            {
                for (int fila = 0; fila < dgvPedido.Rows.Count; fila++)
                {
                    string sentencia = $"INSERT INTO tbPedidos (ID,Producto,Mesero,Mesa,Hora,Estado,Pago,Cantidad,Comentario) values ('{lbNum.Text}','{dgvPedido.Rows[fila].Cells[0].Value.ToString()}','{cbMesero.Text}','{cbMesa.Text}','{DateTime.Now}','En proceso','No','{dgvPedido.Rows[fila].Cells[1].Value.ToString()}','{tbComentario.Text}')";
                    try
                    {
                        pedido.agregarPedido(sentencia);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("No se pudo agregar el pedido correctamente " + ex);
                    }
                }
                MessageBox.Show("Se agrego el pedido correctamente");
                string mesa = $"UPDATE tbMesa set Estado = 'Ocupado' where Numero = '{cbMesa.Text}'";
                pedido.agregarPedido(mesa);
                this.Close();
            }
            else
            {
                if (mesas != cbMesa.Text)
                {
                    try
                    {
                        pedido.eliminarPedido(int.Parse(lbNum.Text));
                        for (int fila = 0; fila < dgvPedido.Rows.Count; fila++)
                        {
                            string sentencia = $"INSERT INTO tbPedidos (ID,Producto,Mesero,Mesa,Hora,Estado,Pago,Cantidad,Comentario) values ('{lbNum.Text}','{dgvPedido.Rows[fila].Cells[0].Value.ToString()}','{cbMesero.Text}','{cbMesa.Text}','{DateTime.Now.ToShortDateString()}','En proceso','No','{dgvPedido.Rows[fila].Cells[1].Value.ToString()}','{tbComentario.Text}')";
                            try
                            {
                                pedido.agregarPedido(sentencia);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("No se pudo agregar el pedido correctamente " + ex);
                            }
                        }
                        MessageBox.Show("Se agrego el pedido correctamente");
                        pedido.cambiarMesa(mesas, cbMesa.Text);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo actualizar el pedido " + ex);
                    }
                }
                else
                {
                    try
                    {
                        pedido.eliminarPedido(int.Parse(lbNum.Text));
                        for (int fila = 0; fila < dgvPedido.Rows.Count; fila++)
                        {
                            string sentencia = $"INSERT INTO tbPedidos (ID,Producto,Mesero,Mesa,Hora,Estado,Pago,Cantidad,Comentario) values ('{lbNum.Text}','{dgvPedido.Rows[fila].Cells[0].Value.ToString()}','{cbMesero.Text}','{cbMesa.Text}','{DateTime.Now.ToShortDateString()}','En proceso','No','{dgvPedido.Rows[fila].Cells[1].Value.ToString()}','{tbComentario.Text}')";
                            try
                            {
                                pedido.agregarPedido(sentencia);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("No se pudo agregar el pedido correctamente " + ex);
                            }
                        }
                        MessageBox.Show("Se actualizo correctamente el pedido");
                        this.Close();
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("No se pudo actualizar el pedido " + ex);
                    }
                }
            }
        }

        private void dgvPedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (this.dgvPedido.Columns[e.ColumnIndex].Name == "Quitar")
                {
                    dgvPedido.Rows.Remove(dgvPedido.CurrentRow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se logro borrar el articulo de la lista " + ex);
            }
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            fmrFactura factura = new fmrFactura(cbMesero.Text,dgvPedido,lbNum.Text);
            factura.Show();
        }
    }
}
