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
    public partial class fmrRoles : Form
    {
        public fmrRoles()
        {
            InitializeComponent();
        }

        private void fmrRoles_Load(object sender, EventArgs e)
        {
            DataTable table = new DataTable();
            clRoles roles = new clRoles();
            try
            {
                table = roles.cargarRoles();
                LlenarDGV(dgvRoles, table);
            }
            catch
            {
                MessageBox.Show("No se pudo cargar los roles");
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

        private void dgvRoles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvRoles.Columns[e.ColumnIndex].HeaderText == "Ver" && e.RowIndex != -1)
            {
                txtNombre.Text = dgvRoles.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbDescripcion.Text = dgvRoles.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
