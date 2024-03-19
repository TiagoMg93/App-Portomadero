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
    public partial class fmrListaCargos : Form
    {
        string rol;
        string usuario;
        public fmrListaCargos(string role,string user)
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
        private void fmrListaCargos_Load(object sender, EventArgs e)
        {
            dgvCargos.Rows.Clear();
            DataTable table = new DataTable();
            clsCargos cargos = new clsCargos();
            try
            {
                table = cargos.cargarCargos();
                LlenarDGV(dgvCargos, table);
                Limpiar();
            }
            catch
            {
                MessageBox.Show("No se pudo cargar correctamente la informcación de los cargos");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            clsCargos cargos = new clsCargos();
            if(btnAgregar.Text == "Agregar")
            {
                try
                {
                    cargos.Pd_Cargo = txtNombre.Text;
                    cargos.Pd_Descripcion = tbDescripcion.Text;
                    cargos.agregarCargo(usuario);
                    fmrListaCargos_Load(sender, e);
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
                    cargos.Pd_Cargo = txtNombre.Text;
                    cargos.Pd_Descripcion = tbDescripcion.Text;
                    cargos.actualizarCargo(usuario);
                    fmrListaCargos_Load(sender, e);
                    Limpiar();
                    btnAgregar.Text = "Agregar";
                }
                catch
                {
                    MessageBox.Show("No se pudo actualizar correctamente la informcación del cargo");
                }
            }
        }
        private void Limpiar()
        {
            txtNombre.Text = "";
            tbDescripcion.Text = "";
            tbBusqueda.Text = "";
            txtNombre.Enabled = true;
        }

        private void dgvCargos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvCargos.Columns[e.ColumnIndex].HeaderText == "Editar" && e.RowIndex != -1)
            {
                btnAgregar.Text = "Editar";
                txtNombre.Text = dgvCargos.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombre.Enabled = false;
                tbDescripcion.Text = dgvCargos.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
            else if(dgvCargos.Columns[e.ColumnIndex].HeaderText == "Borrar" && e.RowIndex != -1)
            {
                DialogResult dialog = MessageBox.Show("¿Seguro que desea eliminar este cargo?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
                if(dialog == DialogResult.Yes)
                {
                    if(rol != "Admon")
                    {
                        MessageBox.Show("Solo los administradores pueden eliminar cargos");
                    }
                    else
                    {
                        try
                        {
                            clsCargos cargos = new clsCargos();
                            cargos.Pd_Cargo = dgvCargos.Rows[e.RowIndex].Cells[0].Value.ToString();
                            cargos.eliminarCargo();
                            MessageBox.Show("Se elimino el cargo correctamente");
                            fmrListaCargos_Load(sender, e);
                            Limpiar();
                        }
                        catch
                        {
                            MessageBox.Show("No fue posible eliminar el cargo");
                        }
                    }
                }
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            fmrListaCargos_Load(sender, e);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow fila in dgvCargos.Rows)
            {
                DataGridViewCell celda = fila.Cells[0];
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
    }
}
