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
    public partial class fmrInicio : Form
    {
        int intentos = 0; //Se controla el ingreso de usuarios con un número limitado de intentos
        public fmrInicio()
        {
            InitializeComponent();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Deseas salir de la aplicación","ADVERTENCIA", MessageBoxButtons.YesNo);
            if(resultado == DialogResult.Yes)
            {
                Application.Exit(); //Se configura el boton de salida de la aplicación
            }
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            cl_Inicio inicio = new cl_Inicio(); //Se llama la clase de la capa logica
            inicio.txtUsuario = tbUsuario.Text;
            inicio.txtPassword = tbPassword.Text; //Se mandan los datos ingresados como los atributos para validar el usuario 
            inicio.ValidarUsuario();
            if(inicio.txtNombre == null)
            {
                MessageBox.Show("El Usuario y/o contraseña ingresado no es correcto, por favor verifique la información");
                tbPassword.Text = "";
                tbUsuario.Text = ""; //Se resetea el texto de los campos
                intentos += 1;
                if(intentos == 3)
                {
                    MessageBox.Show("Has excedido el número de intentos posibles");
                    Application.Exit(); //Luego de varios intentos erroneos se cierra la aplicación
                }
            }
            else
            {
                MessageBox.Show("Bienvenido " + inicio.txtNombre); //Se da la bienvenida a la aplicación
            }
        }
    }
}
