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
    public partial class fmrListaFacturas : Form
    {
        public fmrListaFacturas()
        {
            InitializeComponent();
        }

        private void fmrListaFacturas_Load(object sender, EventArgs e)
        {
            clsFactura factura = new clsFactura();
            DataTable data = new DataTable();
            data = factura.cargarFacturas();
            for(int fila = 0;fila < data.Rows.Count;fila++)
            {
                dgvFactura.Rows.Add();
                dgvFactura.Rows[fila].Cells[0].Value = data.Rows[fila][0].ToString();
                dgvFactura.Rows[fila].Cells[1].Value = data.Rows[fila][1].ToString();
                dgvFactura.Rows[fila].Cells[2].Value = data.Rows[fila][2].ToString();
                dgvFactura.Rows[fila].Cells[3].Value = data.Rows[fila][3].ToString();
                dgvFactura.Rows[fila].Cells[4].Value = data.Rows[fila][4].ToString();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtFecha_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtFecha.Checked == true)
            {
                lbInicial.Visible = true;
                lbFinal.Visible = true;
                dtpFinal.Visible = true;
                dtpInicial.Visible = true;
                txtBuscar.Visible = false;
                cbProducto.Visible = false;
            }
            else
            {
                lbInicial.Visible = false;
                lbFinal.Visible = false;
                dtpFinal.Visible = false;
                dtpInicial.Visible = false;
            }
        }

        private void rbtNumero_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtNumero.Checked == true)
            {
                txtBuscar.Hint = "Escribe aqui el número de factura a buscar";
                txtBuscar.Visible = true;
                cbProducto.Visible = false;
            }
        }

        private void rbtVendedor_CheckedChanged(object sender, EventArgs e)
        {
            cbProducto.Visible = true;
            txtBuscar.Visible = false;
            cbProducto.Items.Clear();
            DataTable table = new DataTable();
            clsFactura factura = new clsFactura();
            table = factura.cargarEmpleados();
            for(int fila = 0; fila < table.Rows.Count; fila++)
            {
                cbProducto.Items.Add(table.Rows[fila][0].ToString());
            }
        }

        private void rbtCliente_CheckedChanged(object sender, EventArgs e)
        {
            cbProducto.Visible = true;
            txtBuscar.Visible = false;
            cbProducto.Items.Clear();
            DataTable table = new DataTable();
            clsFactura factura = new clsFactura();
            table = factura.cargarClientes();
            for (int fila = 0; fila < table.Rows.Count; fila++)
            {
                cbProducto.Items.Add(table.Rows[fila][0].ToString());
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            dgvFactura.Rows.Clear();
            fmrListaFacturas_Load(sender, e);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            dgvFactura.Rows.Clear();
            DataTable table = new DataTable();
            clsFactura factura = new clsFactura();
            if (rbtNumero.Checked == true)
            {
                table = factura.buscarNumFactura(txtBuscar.Text);
                for (int fila = 0; fila < table.Rows.Count; fila++)
                {
                    dgvFactura.Rows.Add();
                    dgvFactura.Rows[fila].Cells[0].Value = table.Rows[fila][0].ToString();
                    dgvFactura.Rows[fila].Cells[1].Value = table.Rows[fila][1].ToString();
                    dgvFactura.Rows[fila].Cells[2].Value = table.Rows[fila][2].ToString();
                    dgvFactura.Rows[fila].Cells[3].Value = table.Rows[fila][3].ToString();
                    dgvFactura.Rows[fila].Cells[4].Value = table.Rows[fila][4].ToString();
                }
                rbtNumero.Checked = false;
                txtBuscar.Visible = false;
            }
            else if(rbtFecha.Checked == true)
            {
                table = factura.buscarFecha(dtpInicial.Value.ToString(), dtpFinal.Value.ToString());
                for (int fila = 0; fila < table.Rows.Count; fila++)
                {
                    dgvFactura.Rows.Add();
                    dgvFactura.Rows[fila].Cells[0].Value = table.Rows[fila][0].ToString();
                    dgvFactura.Rows[fila].Cells[1].Value = table.Rows[fila][1].ToString();
                    dgvFactura.Rows[fila].Cells[2].Value = table.Rows[fila][2].ToString();
                    dgvFactura.Rows[fila].Cells[3].Value = table.Rows[fila][3].ToString();
                    dgvFactura.Rows[fila].Cells[4].Value = table.Rows[fila][4].ToString();
                }
                rbtFecha.Checked = false;
                lbFinal.Visible = false;
                lbInicial.Visible = false;
                dtpFinal.Visible = false;
                dtpInicial.Visible = false;
            }
            else if(rbtVendedor.Checked == true)
            {
                int filas = dgvFactura.Rows.Count;
                int recorrer = 0;
                while (recorrer < filas)
                {
                    if (dgvFactura.Rows[recorrer].Cells[3].Value.ToString() != cbProducto.Text)
                    {
                        dgvFactura.Rows.RemoveAt(recorrer);
                        recorrer = 0;
                        filas = dgvFactura.Rows.Count;
                    }
                    else
                    {
                        recorrer += 1;
                    }
                }
                rbtVendedor.Checked = false;
                cbProducto.Visible = false;
            }
            else if(rbtCliente.Checked == true)
            {
                int filas = dgvFactura.Rows.Count;
                int recorrer = 0;
                while (recorrer < filas)
                {
                    if (dgvFactura.Rows[recorrer].Cells[4].Value.ToString() != cbProducto.Text)
                    {
                        dgvFactura.Rows.RemoveAt(recorrer);
                        recorrer = 0;
                        filas = dgvFactura.Rows.Count;
                    }
                    else
                    {
                        recorrer += 1;
                    }
                }
                rbtCliente.Checked = false;
                cbProducto.Visible = false;
            }
            else if(rbtProducto.Checked == true)
            {
                table = factura.filtrarProducto(cbProducto.Text);
                for (int fila = 0; fila < table.Rows.Count; fila++)
                {
                    dgvFactura.Rows.Add();
                    dgvFactura.Rows[fila].Cells[0].Value = table.Rows[fila][0].ToString();
                    dgvFactura.Rows[fila].Cells[1].Value = table.Rows[fila][1].ToString();
                    dgvFactura.Rows[fila].Cells[2].Value = table.Rows[fila][2].ToString();
                    dgvFactura.Rows[fila].Cells[3].Value = table.Rows[fila][3].ToString();
                    dgvFactura.Rows[fila].Cells[4].Value = table.Rows[fila][4].ToString();
                }
                rbtProducto.Checked = false;
                cbProducto.Visible = false;
            }
            txtBuscar.Text = "";
            cbProducto.Text = "";
        }

        private void rbtProducto_CheckedChanged(object sender, EventArgs e)
        {
            cbProducto.Visible = true;
            txtBuscar.Visible = false;
            cbProducto.Items.Clear();
            DataTable table = new DataTable();
            clsFactura factura = new clsFactura();
            table = factura.cargarProductos();
            for (int fila = 0; fila < table.Rows.Count; fila++)
            {
                cbProducto.Items.Add(table.Rows[fila][0].ToString());
            }
        }

        private void dgvFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0 && dgvFactura.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvFactura.Columns[e.ColumnIndex].Name == "Ver")
            {
                string id = dgvFactura.Rows[e.RowIndex].Cells[0].Value.ToString();
                DataTable table = new DataTable();
                DataTable data = new DataTable();
                DataGridView productos = new DataGridView();
                clsFactura factura = new clsFactura();
                data = factura.verProductos(id);
                productos.Columns.Add("Producto", "Producto");
                productos.Columns.Add("Cantidad", "Cantidad");
                productos.Columns.Add("Precio", "Precio");
                productos.Columns.Add("Subtotal", "Subtotal");
                for (int fila = 0; fila < data.Rows.Count; fila++)
                {
                    productos.Rows.Add();
                    productos.Rows[fila].Cells[0].Value = data.Rows[fila][0].ToString();
                    productos.Rows[fila].Cells[1].Value = data.Rows[fila][1].ToString();
                    productos.Rows[fila].Cells[2].Value = data.Rows[fila][2].ToString();
                    productos.Rows[fila].Cells[3].Value = data.Rows[fila][3].ToString();
                }
                table = factura.consultarFactura(id);
                fmrImprimir imprimir = new fmrImprimir(table.Rows[0][0].ToString(), table.Rows[0][1].ToString(), id, productos, table.Rows[0][2].ToString(), table.Rows[0][3].ToString(), table.Rows[0][4].ToString());
                imprimir.lbHora.Text = table.Rows[0][5].ToString();
                imprimir.Show();
            }
            else if(e.RowIndex >= 0 && dgvFactura.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvFactura.Columns[e.ColumnIndex].Name == "Borrar")
            {
                DialogResult dialogo = MessageBox.Show("¿Seguro que deseas eliminar esta factura?","Advertencia",MessageBoxButtons.YesNo,MessageBoxIcon.Stop);
                if(dialogo == DialogResult.Yes)
                {
                    string id = dgvFactura.Rows[e.RowIndex].Cells[0].Value.ToString();
                    clsFactura factura = new clsFactura();
                    try
                    {
                        factura.eliminarFactura(id);
                        MessageBox.Show("Se ha eliminado la factura correctamente");
                        btnRestaurar_Click(sender, e);
                    }
                    catch
                    {
                        MessageBox.Show("No se pudo eliminar la factura");
                    }
                }
            }
        }
    }
}
