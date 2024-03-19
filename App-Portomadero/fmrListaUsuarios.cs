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
    public partial class fmrListaUsuarios : Form
    {
        string usuario;
        string rol;
        public fmrListaUsuarios(string user,string role)
        {
            InitializeComponent();
            usuario = user;
            rol = role;
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            if(txtPassword.PasswordChar == '\0')
            {
                txtPassword.PasswordChar = '*';
            }
            else
            {
                txtPassword.PasswordChar = '\0';
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtConfirmar.PasswordChar == '\0')
            {
                txtConfirmar.PasswordChar = '*';
            }
            else
            {
                txtConfirmar.PasswordChar = '\0';
            }
        }

        private void fmrListaUsuarios_Load(object sender, EventArgs e)
        {
            clsUsuarios usuarios = new clsUsuarios();
            DataTable table = new DataTable();
            try
            {
                dgvUsuarios.Rows.Clear();
                table = usuarios.cargarUsuarios();
                LlenarDGV(dgvUsuarios, table);
                Limpiar();
                table.Rows.Clear();
                table = usuarios.cargarRoles();
                LlenarCB(cbRol, table);
            }
            catch
            {
                MessageBox.Show("No se pudo cargar la información de los usuarios");
            }
}

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LlenarDGV(DataGridView view, DataTable table)
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
        private void LlenarCB(ComboBox box, DataTable table)
        {
            for(int fila = 0; fila < table.Rows.Count; fila++)
            {
                cbRol.Items.Add(table.Rows[fila][0].ToString());
            }
        }
        private void Limpiar()
        {
            txtDocumento.Text = "";
            txtUsuario.Text = "";
            txtPassword.Text = "";
            txtConfirmar.Text = "";
            tbBusqueda.Text = "";
            cbRol.Items.Add("");
            cbRol.Text = "";
            cbRol.Items.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            clsUsuarios usuarios = new clsUsuarios();
            List<Control> campos = new List<Control>() { txtDocumento, txtUsuario, txtPassword, cbRol };
            int comprobar = comprobarDocumento();
            comprobar = comprobarCampos(campos);
            if(comprobar == 0)
            {
                if(txtPassword.Text == txtConfirmar.Text)
                {
                    if (btnAgregar.Text == "Agregar")
                    {
                        try
                        {
                            usuarios.Pd_Id = txtDocumento.Text;
                            usuarios.Pd_Usuario = txtUsuario.Text;
                            usuarios.Pd_Password = txtPassword.Text;
                            usuarios.Pd_Rol = cbRol.Text;
                            usuarios.agregarUsuario(usuario);
                            MessageBox.Show("Se agrego el usuario correctamente");
                            fmrListaUsuarios_Load(sender, e);
                        }
                        catch
                        {
                            MessageBox.Show("No se pudo agregar el usuario");
                        }
                    }
                    else
                    {
                        try
                        {
                            usuarios.Pd_Id = txtDocumento.Text;
                            usuarios.Pd_Usuario = txtUsuario.Text;
                            usuarios.Pd_Password = txtPassword.Text;
                            usuarios.Pd_Rol = cbRol.Text;
                            usuarios.actualizarUsuario(usuario);
                            MessageBox.Show("Se actualizo el usuario correctamente");
                            fmrListaUsuarios_Load(sender,e);
                        }
                        catch
                        {
                            MessageBox.Show("No se pudo actualizar el usuario");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("La contraseña y la confirmación no coinciden, por favor verificar");
                }
            }
        }
        private int comprobarCampos(List<Control> campos)
        {
            int resultado = 0;
            int recorrer = 0;
            while (recorrer < campos.Count)
            {
                if (string.IsNullOrEmpty(campos[recorrer].Text))
                {
                    resultado = 1;
                    MessageBox.Show("El campo " + campos[recorrer].Name + " no ha sido diligenciado");
                    recorrer = campos.Count;
                }
                else
                {
                    recorrer += 1;
                }
            }
            return resultado;
        }
        private int comprobarDocumento()
        {
            int resultado = 0;
            if (string.IsNullOrEmpty(txtDocumento.Text))
            {
                resultado = 1;
            }
            else
            {
                long numero;
                if (long.TryParse(txtDocumento.Text, out numero))
                {
                    resultado = 0;
                }
                else
                {
                    MessageBox.Show("El documento que se ingreso no es de valor numérico");
                    resultado = 1;
                }
            }
            return resultado;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            fmrListaUsuarios_Load(sender, e);
        }

        private void dgvUsuarios_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (rol == "Administrador" || usuario == dgvUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString())
            {
                if (dgvUsuarios.Columns[e.ColumnIndex].HeaderText == "Editar")
                {
                    txtDocumento.Text = dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                    txtUsuario.Text = dgvUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtPassword.Text = dgvUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtConfirmar.Text = dgvUsuarios.Rows[e.RowIndex].Cells[2].Value.ToString();
                    cbRol.Text = dgvUsuarios.Rows[e.RowIndex].Cells[3].Value.ToString();
                    txtDocumento.Enabled = false;
                    btnAgregar.Text = "Editar";
                }
                else if (rol == "Administrador" && dgvUsuarios.Columns[e.ColumnIndex].HeaderText == "Borrar")
                {
                    DialogResult dialog = MessageBox.Show($"¿Seguro que desea eliminar al usuario {dgvUsuarios.Rows[e.RowIndex].Cells[1].Value.ToString()}?", "PELIGRO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(dialog == DialogResult.Yes)
                    {
                        clsUsuarios usuarios = new clsUsuarios();
                        try
                        {
                            usuarios.Pd_Id = dgvUsuarios.Rows[e.RowIndex].Cells[0].Value.ToString();
                            usuarios.eliminarUsuario();
                            MessageBox.Show("Se elimino correctamente el usuario");
                            fmrListaUsuarios_Load(sender, e);
                        }
                        catch
                        {
                            MessageBox.Show("No se pudo eliminar el usuario");
                        }
                    }
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow fila in dgvUsuarios.Rows)
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
    }
}
