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
    public partial class fmrListaEmpleados : Form
    {
        string usuario;
        string rol;
        public fmrListaEmpleados(string user,string role)
        {
            InitializeComponent();
            usuario = user;
            rol = role;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmrListaEmpleados_Load(object sender, EventArgs e)
        {
            clsEmpleados empleados = new clsEmpleados();
            DataTable data = new DataTable();
            data = empleados.cargarEmpleados();
            LlenarDGV(dgvEmpleados, data);
        }
        public void LlenarDGV(DataGridView view, DataTable table)
        {
            for(int fila = 0; fila < table.Rows.Count; fila++)
            {
                view.Rows.Add();
                for(int columna = 0; columna < table.Columns.Count; columna++)
                {
                    if(view.Columns[columna].HeaderText == "Edad")
                    {
                        clsEmpleados empleados = new clsEmpleados();
                        int edad = empleados.calcularEdad(Convert.ToDateTime(table.Rows[fila][columna].ToString()));
                        view.Rows[fila].Cells[columna].Value = edad;
                    }
                    else
                    {
                        view.Rows[fila].Cells[columna].Value = table.Rows[fila][columna].ToString();
                    }
                }
            }
        }

        private void rbtID_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtID.Checked == true)
            {
                txtBusqueda.Visible = true;
                cbBusqueda.Visible = false;
            }
        }

        private void rbtNombre_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtNombre.Checked == true)
            {
                txtBusqueda.Visible = true;
                cbBusqueda.Visible = false;
            }
        }

        private void rbtCargo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtCargo.Checked == true)
            {
                txtBusqueda.Visible = false;
                cbBusqueda.Visible = true;
                clsEmpleados empleados = new clsEmpleados();
                DataTable data = empleados.cargarCargos();
                cbBusqueda.Items.Clear();
                cargarCombobox(cbBusqueda, data);
            }
        }

        private void rbtEstado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtEstado.Checked == true)
            {
                txtBusqueda.Visible = false;
                cbBusqueda.Visible = true;
                clsEmpleados empleados = new clsEmpleados();
                DataTable data = empleados.cargarEstados();
                cbBusqueda.Items.Clear();
                cargarCombobox(cbBusqueda, data);
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            dgvEmpleados.Rows.Clear();
            fmrListaEmpleados_Load(sender, e);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            clsEmpleados empleados = new clsEmpleados();
            DataTable table = new DataTable();
            if(rbtID.Checked == true)
            {
                dgvEmpleados.Rows.Clear();
                table = empleados.filtrarTexto(txtBusqueda.Text, "ID");
                LlenarDGV(dgvEmpleados, table);
                rbtID.Checked = false;
                txtBusqueda.Text = "";
                txtBusqueda.Visible = false;
            }
            else if(rbtNombre.Checked == true)
            {
                dgvEmpleados.Rows.Clear();
                table = empleados.filtrarTexto(txtBusqueda.Text, "Nombre");
                LlenarDGV(dgvEmpleados, table);
                rbtNombre.Checked = false;
                txtBusqueda.Text = "";
                txtBusqueda.Visible = false;
            }
            else if(rbtCargo.Checked == true)
            {
                filtrarDatagridview(dgvEmpleados, "Cargo", cbBusqueda.Text);
                rbtCargo.Checked = false;
                cbBusqueda.Items.Clear();
                cbBusqueda.Items.Add("");
                cbBusqueda.SelectedIndex = 0;
                cbBusqueda.Visible = false;
            }
            else if(rbtEstado.Checked == true)
            {
                filtrarDatagridview(dgvEmpleados, "Estado", cbBusqueda.Text);
                rbtEstado.Checked = false;
                cbBusqueda.Items.Clear();
                cbBusqueda.Items.Add("");
                cbBusqueda.SelectedIndex = 0;
                cbBusqueda.Visible = false;
            }
        }
        private void filtrarDatagridview(DataGridView table,string campo, string texto)
        {
            int columnaCampo = 0;
            int recorrer = 0;
            while(recorrer < table.Columns.Count)
            {
                if(campo == table.Columns[recorrer].HeaderText)
                {
                    columnaCampo = recorrer;
                    recorrer = table.Columns.Count;
                }
                else
                {
                    recorrer += 1;
                }
            }
            recorrer = 0;
            while(recorrer < table.Rows.Count)
            {
                if(table.Rows[recorrer].Cells[columnaCampo].Value.ToString() != texto)
                {
                    table.Rows.RemoveAt(recorrer);
                    recorrer = 0;
                }
                else
                {
                    recorrer += 1;
                }
            }
        }
        private void cargarCombobox(ComboBox box, DataTable table)
        {
            for(int fila = 0; fila < table.Rows.Count; fila++)
            {
                box.Items.Add(table.Rows[fila][0].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fmrEmpleado empleado = new fmrEmpleado(0,usuario,0);
            empleado.Show();
        }

        private void dgvFactura_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvEmpleados.Columns[e.ColumnIndex].HeaderText == "Editar" && e.RowIndex != -1)
            {
                fmrEmpleado empleado = new fmrEmpleado(1,usuario,int.Parse(dgvEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString()));
                empleado.Show();
            }
            else if (dgvEmpleados.Columns[e.ColumnIndex].HeaderText == "Borrar")
            {
                DialogResult resultado = MessageBox.Show("¿Seguro desea eliminar este empleado, una vez eliminado no se puede recuperar la información?", "ADVERTENCIA", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
                if(resultado == DialogResult.Yes)
                {
                    try
                    {
                        clsEmpleados empleados = new clsEmpleados();
                        int id = int.Parse(dgvEmpleados.Rows[e.RowIndex].Cells[0].Value.ToString());
                        empleados.eliminarEmpleado(id);
                        MessageBox.Show("Se elimino correctamente el empleado");
                        dgvEmpleados.Rows.Clear();
                        fmrListaEmpleados_Load(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se puedo eliminar correctamente el empleado");
                    }
                }
            }
        }
    }
}
