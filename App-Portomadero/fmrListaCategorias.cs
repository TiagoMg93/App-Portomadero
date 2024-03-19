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
    public partial class fmrListaCategorias : Form
    {
        string rol;
        string usuario;
        public fmrListaCategorias(string user,string role)
        {
            InitializeComponent();
            rol = role;
            usuario = user;
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

        private void fmrListaCategorias_Load(object sender, EventArgs e)
        {
            dgvCategorias.Rows.Clear();
            DataTable table = new DataTable();
            clsCategorias categorias = new clsCategorias();
            try
            {
                table = categorias.cargarCategorias();
                LlenarDGV(dgvCategorias, table);
                Limpiar();
            }
            catch
            {
                MessageBox.Show("No se pudo cargar correctamente la informcación de las categorias");
            }
        }
        private void Limpiar()
        {
            txtNombre.Text = "";
            tbDescripcion.Text = "";
            tbBusqueda.Text = "";
            txtNombre.Enabled = true;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            clsCategorias categorias = new clsCategorias();
            if (btnAgregar.Text == "Agregar")
            {
                try
                {
                    categorias.Pd_Nombre = txtNombre.Text;
                    categorias.Pd_Descripcion = tbDescripcion.Text;
                    categorias.Pd_Usuario = usuario;
                    categorias.agregarCategoria();
                    fmrListaCategorias_Load(sender, e);
                    Limpiar();
                }
                catch
                {
                    MessageBox.Show("No se pudo agregar correctamente la informcación del nuevo cargo");
                }
            }
            else
            {
                try
                {
                    categorias.Pd_Nombre = txtNombre.Text;
                    categorias.Pd_Descripcion = tbDescripcion.Text;
                    categorias.Pd_Usuario = usuario;
                    categorias.actualizarCategoria();
                    fmrListaCategorias_Load(sender, e);
                    btnAgregar.Text = "Agregar";
                }
                catch
                {
                    MessageBox.Show("No se pudo actualizar correctamente la informcación de la categoria");
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgvCategorias.Rows)
            {
                DataGridViewCell celda = fila.Cells[1];
                if (celda.Value.ToString().Contains(tbBusqueda.Text))
                {
                    fila.Visible = true;
                }
                else
                {
                    fila.Visible = false;
                }
            }
        }

        private void dgvCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategorias.Columns[e.ColumnIndex].HeaderText == "Editar" && e.RowIndex != -1)
            {
                btnAgregar.Text = "Editar";
                txtNombre.Text = dgvCategorias.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtNombre.Enabled = false;
                tbDescripcion.Text = dgvCategorias.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
            else if (dgvCategorias.Columns[e.ColumnIndex].HeaderText == "Borrar" && e.RowIndex != -1)
            {
                DialogResult dialog = MessageBox.Show("¿Seguro que desea eliminar este cargo?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if (dialog == DialogResult.Yes)
                {
                    if (rol != "Administrador")
                    {
                        MessageBox.Show("Solo los administradores pueden eliminar cargos");
                    }
                    else
                    {
                        try
                        {
                            clsCategorias categorias = new clsCategorias();
                            categorias.Pd_Nombre = dgvCategorias.Rows[e.RowIndex].Cells[1].Value.ToString();
                            categorias.eliminarCategoria();
                            MessageBox.Show("Se elimino la categoria correctamente");
                            fmrListaCategorias_Load(sender, e);
                        }
                        catch
                        {
                            MessageBox.Show("No fue posible eliminar la categoria");
                        }
                    }
                }
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            fmrListaCategorias_Load(sender, e);
        }
    }
}
