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
    public partial class fmrListaClientes : Form
    {
        string rol;
        string usuario;
        public fmrListaClientes(string role, string user)
        {
            InitializeComponent();
            rol = role;
            usuario = user;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fmrListaClientes_Load(object sender, EventArgs e)
        {
            try
            {
                dgvClientes.Rows.Clear();
                clsClientes clientes = new clsClientes();
                DataTable table = new DataTable();
                table = clientes.cargarClientes();
                LlenarDGV(dgvClientes, table);
                dgvClientes.Rows.RemoveAt(0);
            }
            catch
            {
                MessageBox.Show("Error al cargar la lista de los clientes");
            }
        }
        public void LlenarDGV(DataGridView view, DataTable table)
        {
            for (int fila = 0; fila < table.Rows.Count; fila++)
            {
                view.Rows.Add();
                for (int columna = 0; columna < table.Columns.Count; columna++)
                {
                    if (view.Columns[columna].HeaderText == "Edad")
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

        private void limpiarCampos()
        {
            txtDocumento.Text = "";
            txtNombre.Text = "";
            txtContacto.Text = "";
            txtEmail.Text = "";
            rbtDocumento.Checked = false;
            rbtNombre.Checked = false;
            tbBusqueda.Text = "";
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            int resultado = comprobarCampo(txtDocumento.Text, "Documento");
            if(resultado == 0)
            {
                resultado = comprobarCampo(txtContacto.Text, "Número de contacto");
                if(resultado == 0)
                {
                    if(btnAgregar.Text == "Agregar")
                    {
                        try
                        {
                            clsClientes clientes = new clsClientes();
                            clientes.Pd_Documento = txtDocumento.Text;
                            clientes.Pd_Nombre = txtNombre.Text;
                            clientes.Pd_Telefono = txtContacto.Text;
                            clientes.Pd_Email = txtEmail.Text;
                            clientes.Pd_Modifica = usuario;
                            clientes.agregarCliente();
                            limpiarCampos();
                            fmrListaClientes_Load(sender, e);
                        }
                        catch
                        {
                            MessageBox.Show("No se pudo agregar al cliente");
                        }
                    }
                    else
                    {
                        try
                        {
                            clsClientes clientes = new clsClientes();
                            clientes.Pd_Documento = txtDocumento.Text;
                            clientes.Pd_Nombre = txtNombre.Text;
                            clientes.Pd_Telefono = txtContacto.Text;
                            clientes.Pd_Email = txtEmail.Text;
                            clientes.Pd_Modifica = usuario;
                            clientes.actualizarCliente();
                            limpiarCampos();
                            fmrListaClientes_Load(sender, e);
                            btnAgregar.Text = "Agregar";
                        }
                        catch
                        {
                            MessageBox.Show("No se pudo actualizar los datos del cliente");
                        }
                    }
                }
            }
        }
        private int comprobarCampo(string num,string nombreCampo)
        {
            long prueba;
            int resultado = 0;
            if (long.TryParse(num,out prueba))
            {
                resultado = 0;
            }
            else
            {
                resultado = 1;
                MessageBox.Show($"El campo {nombreCampo} no es un número, por favor verificar");
            }
            return resultado;
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvClientes.Columns[e.ColumnIndex].Name == "Editar")
            {
                txtDocumento.Text = dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtNombre.Text = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtContacto.Text = dgvClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtEmail.Text = dgvClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
                btnAgregar.Text = "Editar";
            }
            else if(dgvClientes.Columns[e.ColumnIndex].Name == "Borrar")
            {
                DialogResult result = MessageBox.Show($"¿Seguro que desea eliminar a '{dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString()}'?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.Yes)
                {
                    clsClientes clientes = new clsClientes();
                    try
                    {
                        clientes.Pd_Documento = dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
                        clientes.eliminarCliente();
                        MessageBox.Show("No se pudo borrar el cliente");
                    }
                    catch
                    {
                        MessageBox.Show("No se pudo borrar el cliente");
                    }
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if(rbtDocumento.Checked == true && tbBusqueda.Text != "")
            {
                if (comprobarCampo(tbBusqueda.Text, "Documento")== 0)
                {
                    foreach (DataGridViewRow fila in dgvClientes.Rows)
                    {
                        DataGridViewCell celda = fila.Cells["ID"];
                        if (celda.Value != null && celda.Value.ToString().Contains(tbBusqueda.Text))
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
            else
            {
                foreach (DataGridViewRow fila in dgvClientes.Rows)
                {
                    DataGridViewCell celda = fila.Cells["Nombre"];
                    if (celda.Value != null && celda.Value.ToString().Contains(tbBusqueda.Text))
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

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            fmrListaClientes_Load(sender, e);
        }
    }
}
