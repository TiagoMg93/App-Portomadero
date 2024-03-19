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
    public partial class fmrConfReserva : Form
    {
        string usuario;
        public fmrConfReserva(string user)
        {
            InitializeComponent();
            usuario = user;
        }

        private void btnLunes_Click(object sender, EventArgs e)
        {
            if(btnLunes.BackColor == Color.White)
            {
                btnLunes.BackColor = Color.LightBlue;
            }
            else
            {
                btnLunes.BackColor = Color.White;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMartes_Click(object sender, EventArgs e)
        {
            if (btnMartes.BackColor == Color.White)
            {
                btnMartes.BackColor = Color.LightBlue;
            }
            else
            {
                btnMartes.BackColor = Color.White;
            }
        }

        private void btnMiercoles_Click(object sender, EventArgs e)
        {
            if (btnMiercoles.BackColor == Color.White)
            {
                btnMiercoles.BackColor = Color.LightBlue;
            }
            else
            {
                btnMiercoles.BackColor = Color.White;
            }
        }

        private void btnJueves_Click(object sender, EventArgs e)
        {
            if (btnJueves.BackColor == Color.White)
            {
                btnJueves.BackColor = Color.LightBlue;
            }
            else
            {
                btnJueves.BackColor = Color.White;
            }
        }

        private void btnViernes_Click(object sender, EventArgs e)
        {
            if (btnViernes.BackColor == Color.White)
            {
                btnViernes.BackColor = Color.LightBlue;
            }
            else
            {
                btnViernes.BackColor = Color.White;
            }
        }

        private void btnSabado_Click(object sender, EventArgs e)
        {
            if (btnSabado.BackColor == Color.White)
            {
                btnSabado.BackColor = Color.LightBlue;
            }
            else
            {
                btnSabado.BackColor = Color.White;
            }
        }

        private void btnDomingo_Click(object sender, EventArgs e)
        {
            if (btnDomingo.BackColor == Color.White)
            {
                btnDomingo.BackColor = Color.LightBlue;
            }
            else
            {
                btnDomingo.BackColor = Color.White;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int resultado = 0;
            List<Control> list = new List<Control>() { btnLunes,btnMartes,btnMiercoles,btnJueves,btnViernes,btnSabado,btnDomingo};
            foreach(Control control in list)
            {
                if(control.BackColor != Color.White)
                {
                    resultado = 1;
                }
            }
            if(resultado == 0)
            {
                MessageBox.Show("Debes seleccionar un dia para asignar el horario");
            }
            else
            {
                if(cbApertura.Text != cbCierre.Text)
                {
                    clsConfigRes res = new clsConfigRes();
                    foreach(Control control in list)
                    {
                        if(control.BackColor != Color.White)
                        {
                            try
                            {
                                res.Pd_Dia = control.Text;
                                res.Pd_Apertura = cbApertura.Text;
                                res.Pd_Cierre = cbCierre.Text;
                                res.Pd_Usuario = usuario;
                                res.Pd_Horas = cbHoras.Text;
                                res.Pd_Minutos = cbMinutos.Text;
                                res.guardarHorario();
                            }
                            catch
                            {
                            MessageBox.Show("No se pudo guardar el horario correctamente");
                            }
                        }
                    }
                    fmrConfReserva_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Debes ajustar el horario de apertura y cierre correctamente");
                }
            }
        }

        private void fmrConfReserva_Load(object sender, EventArgs e)
        {
            clsConfigRes res = new clsConfigRes();
            DataTable table = new DataTable();
            dgvConfiguracion.Rows.Clear();
            Limpiar();
            try
            {
                table = res.cargarHorarios();
                LlenarDGV(dgvConfiguracion, table);
                dgvConfiguracion.Sort(dgvConfiguracion.Columns[0], System.ComponentModel.ListSortDirection.Ascending);
            }
            catch
            {
                MessageBox.Show("No se pudo cargar los horarios");
            }
        }
        public void LlenarDGV(DataGridView view, DataTable table)
        {
            for (int row = 0; row < table.Rows.Count; row++)
            {
                view.Rows.Add();
                for (int column = 0; column < table.Columns.Count; column++)
                {
                    view.Rows[row].Cells[column].Value = table.Rows[row][column].ToString();
                }
            }
        }
        public void Limpiar()
        {
            cbApertura.SelectedIndex = 0;
            cbCierre.SelectedIndex = 0;
            cbHoras.SelectedIndex = 0;
            cbMinutos.SelectedIndex = 0;
            List<Control> list = new List<Control>() { btnLunes, btnMartes, btnMiercoles, btnJueves, btnViernes, btnSabado, btnDomingo };
            foreach(Control control in list)
            {
                control.BackColor = Color.White;
            }
        }
    }
}
