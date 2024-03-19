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
    public partial class fmrIngredientes : Form
    {
        string rol;
        string usuario;
        public fmrIngredientes(string user, string role)
        {
            InitializeComponent();
            usuario = user;
            rol = role;
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

        public void Limpiar()
        {
            txtNombre.Text = "";
            txtCantidad.Text = "";
            txtPrecio.Text = "";
            cbUnidad.Text = " ";
            tbBusqueda.Text = "";
        }

        private void fmrIngredientes_Load(object sender, EventArgs e)
        {
            try
            {
                dgvIngredientes.Rows.Clear();
                DataTable data = new DataTable();
                clsIngredientes ingredientes = new clsIngredientes();
                data = ingredientes.cargarIngredientes();
                LlenarDGV(dgvIngredientes, data);
                Limpiar();
            }
            catch
            {
                MessageBox.Show("No se pudo cargar los ingredientes");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(btnAgregar.Text == "Agregar")
            {
                try
                {
                    clsIngredientes ingredientes = new clsIngredientes();
                    ingredientes.Nombre = txtNombre.Text;
                    ingredientes.Cantidad = txtCantidad.Text;
                    ingredientes.Unidad = cbUnidad.Text;
                    ingredientes.Precio = txtPrecio.Text;
                    ingredientes.Usuario = usuario;
                    ingredientes.agregarIngrediente();
                    MessageBox.Show("Se agrego correctamente el ingrediente");
                    fmrIngredientes_Load(sender, e);
                }
                catch
                {
                    MessageBox.Show("No se pudo agregar correctamente la información ");
                }
            }
            else
            {
                try
                {
                    clsIngredientes ingredientes = new clsIngredientes();
                    ingredientes.Nombre = txtNombre.Text;
                    ingredientes.Cantidad = txtCantidad.Text;
                    ingredientes.Unidad = cbUnidad.Text;
                    ingredientes.Precio = txtPrecio.Text;
                    ingredientes.Usuario = usuario;
                    ingredientes.actualizarIngrediente();
                    MessageBox.Show("Se actualizo el ingrediente correctamente");
                    fmrIngredientes_Load(sender, e);
                    btnAgregar.Text = "Agregar";
                    txtNombre.Enabled = true;
                }
                catch
                {
                    MessageBox.Show("No se pudo actualiar correctamente la información ");
                }
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            fmrIngredientes_Load(sender, e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            for (int fila = 0; fila < dgvIngredientes.Rows.Count; fila++)
            {
                DataGridViewCell cell = dgvIngredientes.Rows[fila].Cells[0];
                if (cell.Value.ToString().Contains(tbBusqueda.Text))
                {
                    dgvIngredientes.Rows[fila].Visible = true;
                }
                else
                {
                    dgvIngredientes.Rows[fila].Visible = false;
                }
            }
        }

        private void dgvIngredientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvIngredientes.Columns[e.ColumnIndex].HeaderText == "Editar" && e.RowIndex != -1)
            {
                btnAgregar.Text = "Editar";
                txtNombre.Text = dgvIngredientes.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtCantidad.Text = dgvIngredientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbUnidad.Text = dgvIngredientes.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtPrecio.Text = dgvIngredientes.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtNombre.Enabled = false;
            }
            else if(dgvIngredientes.Columns[e.ColumnIndex].HeaderText == "Borrar" && e.RowIndex != -1)
            {
                if(rol == "Administrador")
                {
                    try
                    {
                        clsIngredientes ingredientes = new clsIngredientes();
                        ingredientes.Nombre = dgvIngredientes.Rows[e.RowIndex].Cells[0].Value.ToString();
                        ingredientes.eliminarIngrediente();
                        MessageBox.Show("Se elimino correctamente el ingrediente");
                        fmrIngredientes_Load(sender, e);
                    }
                    catch
                    {
                        MessageBox.Show("No se pudo eliminar el ingrediente");
                    }
                }
                else
                {
                    MessageBox.Show("Solo los administradores pueden eliminar ingredientes");
                }
            }
        }
    }
}
