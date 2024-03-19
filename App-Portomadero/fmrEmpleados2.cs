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
    public partial class fmrEmpleados2 : Form
    {
        public fmrEmpleados2()
        {
            InitializeComponent();
            clsEmpleados empleados = new clsEmpleados();
            DataTable table = new DataTable();
            table = empleados.cargarCargos();
            llenarCB(cbCargos, table);
        }

        private void dtpIngreso_ValueChanged(object sender, EventArgs e)
        {
            clsEmpleados empleados = new clsEmpleados();
            lbTiempo.Text = empleados.calcularAntiguedad(dtpIngreso.Value);
        }

        private void llenarCB(ComboBox box, DataTable table)
        {
            for(int fila = 0; fila < table.Rows.Count; fila++)
            {
                box.Items.Add(table.Rows[fila][0].ToString());
            }
        }

        private void fmrEmpleados2_Load(object sender, EventArgs e)
        {

        }

        private void cbEstado_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbEstado.Text == "Activo")
            {
                int resultado = int.Parse(lbIngresos.Text);
                resultado += 1;
                lbIngresos.Text = resultado.ToString();
            }
            else if(cbEstado.Text == "Inactivo")
            {
                dtpRetiro.Value = DateTime.Now;
            }
        }
    }
}
