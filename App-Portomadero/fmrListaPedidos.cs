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
    public partial class fmrListaPedidos : Form
    {
        public fmrListaPedidos()
        {
            InitializeComponent();
        }

        private void fmrListaPedidos_Load(object sender, EventArgs e)
        {
            clsPedido pedido = new clsPedido();
            DataTable data = new DataTable();
            data = pedido.consultarPedidos();
            for(int fila = 0; fila < data.Rows.Count; fila++)
            {
                dgvPedidos.Rows.Add();
                dgvPedidos.Rows[fila].Cells[0].Value = data.Rows[fila][0].ToString();
                dgvPedidos.Rows[fila].Cells[1].Value = data.Rows[fila][1].ToString();
                dgvPedidos.Rows[fila].Cells[2].Value = data.Rows[fila][2].ToString();
                dgvPedidos.Rows[fila].Cells[3].Value = data.Rows[fila][3].ToString();
                dgvPedidos.Rows[fila].Cells[4].Value = data.Rows[fila][4].ToString();
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            dgvPedidos.Rows.Clear();
            fmrListaPedidos_Load(sender, e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtMesero_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtMesero.Checked == true)
            {
                clsPedido pedido = new clsPedido();
                DataTable dt = new DataTable();
                dt = pedido.cargarEmpleados();
                cbFiltrar.Items.Clear();
                for(int fila = 0;fila < dt.Rows.Count; fila++)
                {
                    cbFiltrar.Items.Add(dt.Rows[fila][0].ToString());
                }
                cbFiltrar.Enabled = true;
            }
        }

        private void rbtMesa_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtMesa.Checked == true)
            {
                clsPedido pedido = new clsPedido();
                DataTable dt = new DataTable();
                dt = pedido.cargarTodasMesas();
                cbFiltrar.Items.Clear();
                for (int fila = 0; fila < dt.Rows.Count; fila++)
                {
                    cbFiltrar.Items.Add(dt.Rows[fila][0].ToString());
                }
                cbFiltrar.Enabled = true;
            }
        }

        private void rbtEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtEstado.Checked == true)
            {
                cbFiltrar.Items.Clear();
                cbFiltrar.Items.Add("En proceso");
                cbFiltrar.Items.Add("Terminado");
            }
            cbFiltrar.Enabled = true;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            clsPedido pedido = new clsPedido();
            DataTable data = new DataTable();
            if (rbtMesero.Checked == true)
            {
                int filas = dgvPedidos.Rows.Count;
                int recorrer = 0;
                while(recorrer < filas)
                {
                    if (dgvPedidos.Rows[recorrer].Cells[1].Value.ToString() != cbFiltrar.Text)
                    {
                        dgvPedidos.Rows.RemoveAt(recorrer);
                        recorrer = 0;
                        filas = dgvPedidos.Rows.Count;
                    }
                    else
                    {
                        recorrer += 1;
                    }
                }
                cbFiltrar.Items.Add("");
                cbFiltrar.Text = "";
                rbtMesero.Checked = false;
                cbFiltrar.Enabled = false;
            }
            else if (rbtMesa.Checked == true)
            {
                int filas = dgvPedidos.Rows.Count;
                int recorrer = 0;
                while (recorrer < filas)
                {
                    if (dgvPedidos.Rows[recorrer].Cells[2].Value.ToString() != cbFiltrar.Text)
                    {
                        dgvPedidos.Rows.RemoveAt(recorrer);
                        recorrer = 0;
                        filas = dgvPedidos.Rows.Count;
                    }
                    else
                    {
                        recorrer += 1;
                    }
                }
                cbFiltrar.Items.Add("");
                cbFiltrar.Text = "";
                rbtMesero.Checked = false;
                cbFiltrar.Enabled = false;
            }
            else if (rbtEstado.Checked == true)
            {
                dgvPedidos.Rows.Clear();
                data = pedido.filtrarEstado(cbFiltrar.Text);
                for (int fila = 0; fila < data.Rows.Count; fila++)
                {
                    dgvPedidos.Rows.Add();
                    dgvPedidos.Rows[fila].Cells[0].Value = data.Rows[fila][0].ToString();
                    dgvPedidos.Rows[fila].Cells[1].Value = data.Rows[fila][1].ToString();
                    dgvPedidos.Rows[fila].Cells[2].Value = data.Rows[fila][2].ToString();
                    dgvPedidos.Rows[fila].Cells[3].Value = data.Rows[fila][3].ToString();
                    dgvPedidos.Rows[fila].Cells[4].Value = data.Rows[fila][4].ToString();
                }
                cbFiltrar.Items.Add("");
                cbFiltrar.Text = "";
                rbtEstado.Checked = false;
                cbFiltrar.Enabled = false;
            }
        }

        private void dgvPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvPedidos.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvPedidos.Columns[e.ColumnIndex].Name == "Terminar")
            {
                if(dgvPedidos.Rows[e.RowIndex].Cells[3].Value.ToString() == "Terminado")
                {
                    MessageBox.Show("El pedido ya ha finalizado");
                }
                else
                {
                    DialogResult result = MessageBox.Show("¿Desea terminar el pedido? (se pasara la mesa a disponible)", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (result == DialogResult.Yes)
                    {
                        if (dgvPedidos.Rows[e.RowIndex].Cells[4].Value.ToString() == "Si")
                        {
                            string id = dgvPedidos.Rows[e.RowIndex].Cells[0].Value.ToString();
                            DataTable table = new DataTable();
                            clsPedido pedido = new clsPedido();
                            pedido.actualizarEstado(dgvPedidos.Rows[e.RowIndex].Cells[0].Value.ToString());
                            btnRestaurar_Click(sender, e);
                        }
                        else
                        {
                            MessageBox.Show("Para dar por terminado el pedido debe realizar primero el pago");
                        }
                    }
                }
            }
            else if (e.RowIndex >= 0 && dgvPedidos.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvPedidos.Columns[e.ColumnIndex].Name == "Ver")
            {
                fmrPedido pedido = new fmrPedido(1, int.Parse(dgvPedidos.Rows[e.RowIndex].Cells[0].Value.ToString()));
                pedido.Show();
                btnRestaurar_Click(sender, e);
            }
            else if (e.RowIndex >= 0 && dgvPedidos.Columns[e.ColumnIndex] is DataGridViewButtonColumn && dgvPedidos.Columns[e.ColumnIndex].Name == "Borrar")
            {
                DialogResult dialogo = MessageBox.Show("¿Seguro que deseas eliminar esta factura?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (dialogo == DialogResult.Yes)
                {
                    string id = dgvPedidos.Rows[e.RowIndex].Cells[0].Value.ToString();
                    clsPedido pedido = new clsPedido();
                    try
                    {
                        pedido.eliminarPedido(int.Parse(id));
                        MessageBox.Show("Se ha eliminado el pedido correctamente");
                        btnRestaurar_Click(sender, e);
                    }
                    catch
                    {
                        MessageBox.Show("No se pudo eliminar el pedido");
                    }
                }
            }
        }
    }
}
