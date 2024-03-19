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
    public partial class fmrEmpleados1 : Form
    {
        public fmrEmpleados1()
        {
            InitializeComponent();
        }

        private void dtpNacimiento_ValueChanged(object sender, EventArgs e)
        {
            clsEmpleados empleados = new clsEmpleados();
            lbEdad.Text = Convert.ToString(empleados.calcularEdad(dtpNacimiento.Value));
        }
    }
}
