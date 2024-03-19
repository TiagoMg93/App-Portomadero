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
    public partial class fmrEmpleado : Form
    {
        int entrada;
        string usuario;
        int documento;
        fmrEmpleados1 empleado1 = new fmrEmpleados1();
        fmrEmpleados2 empleado2 = new fmrEmpleados2();
        public fmrEmpleado(int ingreso, string user, int id)
        {
            InitializeComponent();
            entrada = ingreso;
            usuario = user;
            documento = id;
        }
        
        private void agregarForm(Form form,Panel panel)
        {
            form.TopLevel = false;
            panel.Controls.Add(form);
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
        }

        private void fmrEmpleado_Load(object sender, EventArgs e)
        {
            agregarForm(empleado1, pnlPrincipal);
            agregarForm(empleado2, pnlPrincipal);
            empleado1.Show();
            if(entrada == 1)
            {
                txtNombre.Visible = false;
                txtDocumento.Visible = false;
                btnModificar.Visible = true;
                lbObligatorio.Visible = false;
                lbObligatorio2.Visible = false;
                btnModificar.Visible = true;
                clsEmpleados empleados = new clsEmpleados();
                DataTable table = new DataTable();
                table = empleados.cargarEmpleado(documento);
                cargarDatosEmpleado(table);
            }
            else
            {
                lbNombre.Visible = false;
                lbDocumento.Visible = false;
                empleado2.cbEstado.Text = "Activo";
                empleado2.lbIngresos.Text = "0";
                empleado2.cbEstado.Enabled = false;
                empleado2.dtpRetiro.Enabled = false;
                empleado2.txtRetiro.Enabled = false;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea salir? (la información que no se ha guardado se perderá)","SALIR",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (empleado1.Visible)
            {
                empleado1.Hide();
                empleado2.Show();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (empleado2.Visible)
            {
                empleado2.Hide();
                empleado1.Show();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (entrada == 0)
            {
                List<Control> campos = new List<Control>() { txtDocumento, txtNombre, cbTipoDocumento, empleado1.cbRh, empleado1.txtContacto, empleado1.cbEps, empleado2.cbEstado, empleado2.cbCargos, empleado2.tbSalario, empleado2.cbMoneda, empleado2.cbArl };
                if (comprobarDocumento() == 1)
                {
                    MessageBox.Show("El documento ingresado no es valido");
                }
                else if (empleado1.lbEdad.Text == "-")
                {
                    MessageBox.Show("Se debe ingresar una fecha de nacimiento del empleado");
                }
                else if (empleado2.lbTiempo.Text == "-")
                {
                    MessageBox.Show("Se debe ingresar una fecha de ingreso del empleado");
                }
                else
                {
                    if (comprobarCampos(campos) == 0)
                    {
                        clsEmpleados empleados = new clsEmpleados();
                        empleados.Pd_id = txtDocumento.Text;
                        empleados.Pd_name = txtNombre.Text;
                        empleados.Pd_nacimiento = empleado1.dtpNacimiento.Value.ToShortDateString();
                        empleados.Pd_rh = empleado1.cbRh.Text;
                        empleados.Pd_contacto = empleado1.txtContacto.Text;
                        empleados.Pd_email = empleado1.txtEmail.Text;
                        empleados.Pd_eps = empleado1.cbEps.Text;
                        empleados.Pd_peso = empleado1.tbPeso.Text;
                        empleados.Pd_altura = empleado1.tbAltura.Text;
                        empleados.Pd_camiseta = empleado1.tbCamiseta.Text;
                        empleados.Pd_direccion = empleado1.txtDireccion.Text;
                        empleados.Pd_comentarios = empleado1.tbComentarios.Text;
                        empleados.Pd_ingreso = empleado2.dtpIngreso.Value.ToShortDateString();
                        empleados.Pd_estado = empleado2.cbEstado.Text;
                        empleados.Pd_reingresos = empleado2.lbIngresos.Text;
                        empleados.Pd_cargo = empleado2.cbCargos.Text;
                        empleados.Pd_salario = empleado2.tbSalario.Text;
                        empleados.Pd_moneda = empleado2.cbMoneda.Text;
                        empleados.Pd_retiro = null;
                        empleados.Pd_motivo = null;
                        empleados.Pd_arl = empleado2.cbArl.Text;
                        empleados.Pd_modifica = usuario;
                        empleados.Pd_foto = txtFoto.Text;
                        empleados.Pd_pantalon = empleado1.tbPantalon.Text;
                        empleados.Pd_zapato = empleado1.tbZapatos.Text;
                        empleados.Pd_TipoDoc = cbTipoDocumento.Text;
                        try
                        {
                            string resultado = empleados.agregarEmpleado();
                            MessageBox.Show($"{resultado}");
                            this.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("No se pudo guardar el nuevo empleado " + ex);
                        }
                    }
                }
            }
            else
            {
                lbObligatorio2.Visible = false;
                lbNombre.Visible = true;
                txtNombre.Visible = false;
                txtNombre.Text = lbNombre.Text;
                List<Control> campos = new List<Control>() {txtNombre, cbTipoDocumento, empleado1.cbRh, empleado1.txtContacto, empleado1.cbEps, empleado2.cbEstado, empleado2.cbCargos, empleado2.tbSalario, empleado2.cbMoneda, empleado2.cbArl};
                if(comprobarCampos(campos) == 0)
                {
                    clsEmpleados empleados = new clsEmpleados();
                    empleados.Pd_id = lbDocumento.Text;
                    empleados.Pd_name = txtNombre.Text;
                    empleados.Pd_nacimiento = empleado1.dtpNacimiento.Value.ToShortDateString();
                    empleados.Pd_rh = empleado1.cbRh.Text;
                    empleados.Pd_contacto = empleado1.txtContacto.Text;
                    empleados.Pd_email = empleado1.txtEmail.Text;
                    empleados.Pd_eps = empleado1.cbEps.Text;
                    empleados.Pd_peso = empleado1.tbPeso.Text;
                    empleados.Pd_altura = empleado1.tbAltura.Text;
                    empleados.Pd_camiseta = empleado1.tbCamiseta.Text;
                    empleados.Pd_direccion = empleado1.txtDireccion.Text;
                    empleados.Pd_comentarios = empleado1.tbComentarios.Text;
                    empleados.Pd_ingreso = empleado2.dtpIngreso.Value.ToShortDateString();
                    empleados.Pd_estado = empleado2.cbEstado.Text;
                    empleados.Pd_reingresos = empleado2.lbIngresos.Text;
                    empleados.Pd_cargo = empleado2.cbCargos.Text;
                    empleados.Pd_salario = empleado2.tbSalario.Text;
                    empleados.Pd_moneda = empleado2.cbMoneda.Text;
                    if(empleado2.cbEstado.Text == "Inactivo")
                    {
                        empleados.Pd_retiro = empleado2.dtpRetiro.Value.ToShortDateString();
                    }
                    empleados.Pd_arl = empleado2.cbArl.Text;
                    empleados.Pd_motivo = empleado2.txtRetiro.Text;
                    empleados.Pd_modifica = usuario;
                    empleados.Pd_foto = txtFoto.Text;
                    empleados.Pd_pantalon = empleado1.tbPantalon.Text;
                    empleados.Pd_zapato = empleado1.tbZapatos.Text;
                    empleados.Pd_TipoDoc = cbTipoDocumento.Text;
                    try
                    {
                        string resultado = empleados.actualizarEmpleado();
                        MessageBox.Show($"{resultado}");
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo actualizar el empleado " + ex);
                    }
                }
            }
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
        private int comprobarCampos(List<Control> campos)
        {
            int resultado = 0;
            int recorrer = 0;
            while(recorrer < campos.Count)
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

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Title = "Selecciona una imagen";
            abrir.Filter = "PNG |*.png| JPG |*.jpg";
            if (abrir.ShowDialog() == DialogResult.OK)
            {
                txtFoto.Text = abrir.FileName.ToString();
                pbFoto.ImageLocation = abrir.FileName;
                pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            lbObligatorio2.Visible = true;
            lbNombre.Visible = false;
            txtNombre.Visible = true;
            txtNombre.Text = lbNombre.Text;
        }
        private void cargarDatosEmpleado(DataTable tabla)
        {
            try
            {
                lbNombre.Text = tabla.Rows[0][1].ToString();
                lbDocumento.Text = tabla.Rows[0][0].ToString();
                cbTipoDocumento.Text = tabla.Rows[0][27].ToString();
                txtFoto.Text = tabla.Rows[0][27].ToString();
                if (tabla.Rows[0][23].ToString() != null)
                {
                    pbFoto.ImageLocation = tabla.Rows[0][23].ToString();
                }
                empleado1.dtpNacimiento.Value = Convert.ToDateTime(tabla.Rows[0][2].ToString());
                empleado1.cbRh.Text = tabla.Rows[0][3].ToString();
                empleado1.txtContacto.Text = tabla.Rows[0][4].ToString();
                empleado1.txtEmail.Text = tabla.Rows[0][5].ToString();
                empleado1.cbEps.Text = tabla.Rows[0][6].ToString();
                empleado1.tbPeso.Text = tabla.Rows[0][7].ToString();
                empleado1.tbAltura.Text = tabla.Rows[0][8].ToString();
                empleado1.tbCamiseta.Text = tabla.Rows[0][9].ToString();
                empleado1.txtDireccion.Text = tabla.Rows[0][10].ToString();
                empleado1.tbComentarios.Text = tabla.Rows[0][11].ToString();
                empleado2.dtpIngreso.Value = Convert.ToDateTime(tabla.Rows[0][12].ToString());
                empleado2.cbEstado.Text = tabla.Rows[0][13].ToString();
                empleado2.lbIngresos.Text = tabla.Rows[0][14].ToString();
                empleado2.cbCargos.Text = tabla.Rows[0][15].ToString();
                empleado2.tbSalario.Text = tabla.Rows[0][16].ToString();
                empleado2.cbMoneda.Text = tabla.Rows[0][17].ToString();
                empleado2.cbArl.Text = tabla.Rows[0][19].ToString();
                empleado2.txtRetiro.Text = tabla.Rows[0][20].ToString();
                empleado1.tbPantalon.Text = tabla.Rows[0][25].ToString();
                empleado1.tbZapatos.Text = tabla.Rows[0][26].ToString();
                clsEmpleados empleados = new clsEmpleados();
                empleado1.lbEdad.Text = Convert.ToString(empleados.calcularEdad(empleado1.dtpNacimiento.Value));
                if (tabla.Rows[0][18].ToString() == "")
                {
                    empleado2.lbTiempo.Text = empleados.calcularAntiguedad(empleado2.dtpIngreso.Value);
                }
                else
                {
                    clsEmpleados empleado = new clsEmpleados();
                    empleado2.lbTiempo.Text = empleado.distanciaFechas(empleado2.dtpIngreso.Value, empleado2.dtpRetiro.Value);
                    empleado2.dtpRetiro.Value = Convert.ToDateTime(tabla.Rows[0][18].ToString());
                }
        }
            catch
            {
                MessageBox.Show("No se pudo cargar los datos del empleado correctamente");
            }
        }
    }
}
