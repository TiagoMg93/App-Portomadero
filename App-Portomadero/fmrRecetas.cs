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
    public partial class fmrRecetas : Form
    {
        string usuario;
        float valor;
        int pos;
        public fmrRecetas(string user)
        {
            InitializeComponent();
            usuario = user;
        }

        private void fmrRecetas_Load(object sender, EventArgs e)
        {
            dgvIngredientes.Rows.Clear();
            dgvProductos.Rows.Clear();
            DataTable data = new DataTable();
            clsReceta receta = new clsReceta();
            try
            {
                data = receta.cargarProducto();
                LlenarDGV(dgvProductos, data);
                DataGridViewComboBoxColumn box = (DataGridViewComboBoxColumn)dgvIngredientes.Columns["Ingrediente"];
                data.Rows.Clear();
                data = receta.cargarIngredientes();
                for(int fila = 0; fila < data.Rows.Count; fila++)
                {
                    box.Items.Add(data.Rows[fila][0].ToString());
                }
            }
            catch
            {
                MessageBox.Show("No se pudo cargar los elementos");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            if(dgvIngredientes.Rows.Count == 0)
            {
                dgvIngredientes.Rows.Add();
                btnGuardar.Enabled = true;
            }
            else if(dgvIngredientes.Rows[dgvIngredientes.Rows.Count-1].Cells[1].Value != null)
            {
                dgvIngredientes.Rows.Add();
            }
        }

        private void dgvIngredientes_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is ComboBox)
            {
                ComboBox comboBox = e.Control as ComboBox;
                comboBox.SelectedIndexChanged -= ComboBox_SelectedIndexChanged;
                comboBox.SelectedIndexChanged += ComboBox_SelectedIndexChanged;
            }
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox box = sender as ComboBox;
            if(box != null)
            {
                try
                {
                    DataTable data = new DataTable();
                    clsReceta receta = new clsReceta();
                    string nombre = box.SelectedItem?.ToString();
                    data = receta.buscarUnidades(nombre);
                    valor = float.Parse(data.Rows[0][1].ToString());
                    int fila = dgvIngredientes.CurrentRow.Index;
                    dgvIngredientes.Rows[fila].Cells[2].Value = data.Rows[0][0].ToString();
                }
                catch
                {
                MessageBox.Show("No se pudo cargar la información del ingrediente");
                }
            }
            // Realiza las acciones necesarias con el valor seleccionado
        }

        private void dgvIngredientes_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            pos = e.RowIndex;
        }

        private void dgvIngredientes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvIngredientes_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                float cantidad;
                float resultado;
                if (float.TryParse(dgvIngredientes.Rows[e.RowIndex].Cells[1].Value.ToString(), out cantidad))
                {
                    DataTable data = new DataTable();
                    clsReceta receta = new clsReceta();
                    data = receta.buscarUnidades(dgvIngredientes.Rows[e.RowIndex].Cells[0].Value.ToString());
                    valor = float.Parse(data.Rows[0][1].ToString());
                    resultado = cantidad * valor;
                    dgvIngredientes.Rows[e.RowIndex].Cells[3].Value = resultado;
                    lbCosto.Text = suma(dgvIngredientes).ToString();
                }
                else
                {
                    MessageBox.Show("La cantidad ingresada no es un valor numérico");
                    dgvIngredientes.Rows[e.RowIndex].Cells[1].Value = null;
                }
            }
        }
        private float suma(DataGridView view)
        {
            float total = 0;
            for(int fila = 0; fila < dgvIngredientes.Rows.Count; fila++)
            {
                total += float.Parse(dgvIngredientes.Rows[fila].Cells[3].Value.ToString());
            }
            return total;
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvProductos.Columns[e.ColumnIndex].HeaderText == "Editar" && e.RowIndex != -1)
            {
                dgvIngredientes.Rows.Clear();
                lbCosto.Text = "-";
                lbReceta.Text = dgvProductos.Rows[e.RowIndex].Cells[0].Value.ToString();
                btnAñadir.Enabled = true;
                DataTable data = new DataTable();
                clsReceta receta = new clsReceta();
                //try
                //{
                    data = receta.consultarReceta(lbReceta.Text);
                    if(data != null)
                    {
                    for (int fila = 0; fila < data.Rows.Count; fila++)
                    {
                            dgvIngredientes.Rows.Add();
                            dgvIngredientes.Rows[fila].Cells[0].Value = data.Rows[fila][0].ToString();
                            dgvIngredientes.Rows[fila].Cells[1].Value = data.Rows[fila][1].ToString();
                            dgvIngredientes.Rows[fila].Cells[2].Value = data.Rows[fila][2].ToString();
                            dgvIngredientes.Rows[fila].Cells[3].Value = data.Rows[fila][3].ToString();
                        }
                        lbCosto.Text = suma(dgvIngredientes).ToString();
                        btnGuardar.Enabled = true;
                    }
                //}
                //catch
                //{
                //    MessageBox.Show("No se pudo cargar la información de la receta");
                //}
            }
        }

        private void dgvIngredientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvIngredientes.Columns[e.ColumnIndex].HeaderText == "Borrar" && e.RowIndex != -1)
            {
                dgvIngredientes.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clsReceta receta = new clsReceta();
            try
            {
                receta.Receta = lbReceta.Text;
                receta.Usuario = usuario;
                receta.eliminarReceta();
                for(int fila = 0; fila < dgvIngredientes.Rows.Count; fila++)
                {
                    receta.Ingrediente = dgvIngredientes.Rows[fila].Cells[0].Value.ToString();
                    receta.Cantidad = dgvIngredientes.Rows[fila].Cells[1].Value.ToString();
                    receta.Unidad = dgvIngredientes.Rows[fila].Cells[2].Value.ToString();
                    receta.Valor = dgvIngredientes.Rows[fila].Cells[3].Value.ToString();
                    receta.agregarReceta();
                }
            MessageBox.Show("Se agrego correctamente la receta");
            }
            catch
            {
                MessageBox.Show("No se pudo actualizar la receta");
            }
}
    }
}
