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
            }
            else if(rbtVendedor.Checked == true)
            {
                table = factura.filtrarFactura("Vendedor", cbProducto.Text);
                for (int fila = 0; fila < table.Rows.Count; fila++)
                {
                    dgvFactura.Rows.Add();
                    dgvFactura.Rows[fila].Cells[0].Value = table.Rows[fila][0].ToString();
                    dgvFactura.Rows[fila].Cells[1].Value = table.Rows[fila][1].ToString();
                    dgvFactura.Rows[fila].Cells[2].Value = table.Rows[fila][2].ToString();
                    dgvFactura.Rows[fila].Cells[3].Value = table.Rows[fila][3].ToString();
                    dgvFactura.Rows[fila].Cells[4].Value = table.Rows[fila][4].ToString();
                }
            }
            else if(rbtCliente.Checked == true)
            {
                table = factura.filtrarFactura("Cliente", cbProducto.Text);
                for (int fila = 0; fila < table.Rows.Count; fila++)
                {
                    dgvFactura.Rows.Add();
                    dgvFactura.Rows[fila].Cells[0].Value = table.Rows[fila][0].ToString();
                    dgvFactura.Rows[fila].Cells[1].Value = table.Rows[fila][1].ToString();
                    dgvFactura.Rows[fila].Cells[2].Value = table.Rows[fila][2].ToString();
                    dgvFactura.Rows[fila].Cells[3].Value = table.Rows[fila][3].ToString();
                    dgvFactura.Rows[fila].Cells[4].Value = table.Rows[fila][4].ToString();
                }
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
            }
        }

        private void rbtProducto_CheckedChanged(object sender, EventArgs e)
        {
            cbProducto.Visible = true;
            cbProducto.Items.Clear();
            DataTable table = new DataTable();
            clsFactura factura = new clsFactura();
            table = factura.cargarProductos();
            for (int fila = 0; fila < table.Rows.Count; fila++)
            {
                cbProducto.Items.Add(table.Rows[fila][0].ToString());
            }
        }
    }
}
