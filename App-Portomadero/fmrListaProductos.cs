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
    public partial class fmrListaProductos : Form
    {
        string usuario;
        string rol;
        public fmrListaProductos(string user, string role)
        {
            InitializeComponent();
            usuario = user;
            rol = role;
        }

        private void rbtCategoria_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtCategoria.Checked == true)
            {
                cbBusqueda.Visible = true;
                txtBusqueda.Visible = false;
            }
        }

        private void rbtNombre_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtNombre.Checked == true)
            {
                cbBusqueda.Visible = false;
                txtBusqueda.Visible = true;
            }
        }
        public void LlenarDGV(DataGridView view, DataTable table)
        {
            for (int fila = 0; fila < table.Rows.Count; fila++)
            {
                view.Rows.Add();
                for (int columna = 0; columna < table.Columns.Count; columna++)
                {
                    view.Rows[fila].Cells[columna].Value = table.Rows[fila][columna].ToString();
                }
            }
        }
        public void LlenarCB(ComboBox box, DataTable table)
        {
            for (int fila = 0; fila < table.Rows.Count; fila++)
            {
                    box.Items.Add(table.Rows[fila][0].ToString());
            }
        }

        private void fmrListaProductos_Load(object sender, EventArgs e)
        {
            try
            {
                Limpiar();
                dgvProductos.Rows.Clear();
                DataTable table = new DataTable();
                clsProducto producto = new clsProducto();
                table = producto.cargarProductos();
                LlenarDGV(dgvProductos, table);
                table.Rows.Clear();
                table = producto.cargarCategorias();
                LlenarCB(cbBusqueda, table);
            }
            catch
            {
                MessageBox.Show("No se pudo cargar los productos");
            }
        }
        private void Limpiar()
        {
            cbBusqueda.Items.Add("");
            cbBusqueda.SelectedItem = "";
            cbBusqueda.Items.Clear();
            rbtCategoria.Checked = false;
            rbtNombre.Checked = false;
            txtBusqueda.Text = "";
            txtBusqueda.Visible = false;
            cbBusqueda.Visible = false;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            fmrListaProductos_Load(sender, e);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if(rbtCategoria.Checked == true)
            {
                filtrarBusqueda(2, cbBusqueda.Text, dgvProductos);
            }
            else if (rbtNombre.Checked)
            {
                filtrarBusqueda(1, txtBusqueda.Text, dgvProductos);
                txtBusqueda.Text = "";
            }
        }
        private void filtrarBusqueda(int columna, string busqueda, DataGridView view)
        {
            for(int fila = 0; fila < view.Rows.Count; fila++)
            {
                DataGridViewCell cell = dgvProductos.Rows[fila].Cells[columna];
                if (cell.Value != null && cell.Value.ToString().Contains(busqueda))
                {
                    view.Rows[fila].Visible = true;
                }
                else
                {
                    view.Rows[fila].Visible = false;
                }
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvProductos.Columns[e.ColumnIndex].HeaderText == "Editar" && e.RowIndex != -1)
            {
                fmrProducto producto = new fmrProducto(1, dgvProductos.Rows[e.RowIndex].Cells[1].Value.ToString(), usuario,rol);
                producto.Show();
            }
        }
    }
}
