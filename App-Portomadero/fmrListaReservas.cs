using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using Capa_Logica;

namespace App_Portomadero
{
    public partial class fmrListaReservas : Form
    {
        string usuario;
        string rol;
        DataTable data = new DataTable();
        clsReserva reserva = new clsReserva();
        List<string> horasReservas = new List<string>();
        public fmrListaReservas(string user, string role)
        {
            InitializeComponent();
            usuario = user;
            rol = role;
        }

        private void llenarDGV(DataGridView view, DataTable table)
        {
            for(int fila = 0; fila < table.Rows.Count; fila++)
            {
                view.Rows.Add();
                for(int columna = 0; columna < table.Columns.Count; columna++)
                {
                    view.Rows[fila].Cells[columna].Value = table.Rows[fila][columna].ToString();
                }
            }
        }

        private void fmrListaReservas_Load_1(object sender, EventArgs e)
        {
            try
            {
                data = reserva.cargarReservas();
                llenarDGV(dgvReservas, data);
                int recorrer = 0;
                while(recorrer < dgvReservas.Rows.Count)
                {
                    if (DateTime.Parse(dgvReservas.Rows[recorrer].Cells[0].Value.ToString()) < DateTime.Now)
                    {
                        dgvReservas.Rows.RemoveAt(recorrer);
                        recorrer = 0;
                    }
                    else
                    {
                        recorrer += 1;
                    }
                }
                actualiarCombobox();
            }
            catch
            {
                MessageBox.Show("No se pudo cargar la información de las reservas");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private HashSet<string> extraerFiltro(string nombreColumna)
        {
            HashSet<string> lista = new HashSet<string>();
            if (dgvReservas.Columns.Contains(nombreColumna))
            {
                foreach(DataGridViewRow row in dgvReservas.Rows)
                {
                    lista.Add(row.Cells[nombreColumna].Value.ToString());
                }
            }
            return lista;
        }
        private void ingresarItems(HashSet<string> datos, ComboBox box)
        {
            foreach(string item in datos)
            {
                box.Items.Add(item);
            }
        }
        private void actualiarCombobox()
        {
            cbInicio.Items.Clear();
            cbFinal.Items.Clear();
            HashSet<string> horas = extraerFiltro("Hora");
            ingresarItems(horas, cbInicio);
            ingresarItems(horas, cbFinal);
            horas.Clear();
            cbEspacio.Items.Clear();
            horas = extraerFiltro("Espacio");
            ingresarItems(horas, cbEspacio);
            horas.Clear();
            horas = extraerFiltro("Cliente");
            cbCliente.Items.Clear();
            ingresarItems(horas, cbCliente);
            horas.Clear();
            horas = extraerFiltro("Modifica");
            cbUsuario.Items.Clear();
            ingresarItems(horas, cbUsuario);
        }
        private void Limpiar()
        {
            List<Control> controls = new List<Control>() { cbInicio, cbFinal, cbEspacio, cbCliente, cbUsuario };
            foreach(ComboBox box in controls)
            {
                box.Items.Add("");
                box.SelectedText = "";
                box.Items.Clear();
            }
            dtpFinal.Value = DateTime.Today;
            dtpInicio.Value = DateTime.Today;
        }

        private void btnFecha_Click(object sender, EventArgs e)
        {
            if(dtpFinal.Value < dtpInicio.Value)
            {
                MessageBox.Show("Debes seleccionar una fecha final mayor que la fecha inicial");
            }
            else
            {
                try
                {
                    dgvReservas.Rows.Clear();
                    data = reserva.consultarFechas(dtpInicio.Value.ToShortDateString(), dtpFinal.Value.ToShortDateString());
                    llenarDGV(dgvReservas, data);
                    actualiarCombobox();
                }
                catch
                {
                    MessageBox.Show("No se pudo realizar la consulta entre las fechas");
                }
            }
        }

        private void btnHora_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dgvReservas.Rows)
            {
                TimeSpan consulta = TimeSpan.Parse(row.Cells[1].Value.ToString());
                TimeSpan inicio = TimeSpan.Parse(cbInicio.Text);
                TimeSpan final = TimeSpan.Parse(cbFinal.Text);
                if (consulta >= inicio && consulta <= final)
                {
                    row.Visible = true;
                }
                else
                {
                    dgvReservas.Rows.Remove(row);
                }
            }
            Limpiar();
            actualiarCombobox();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            Limpiar();
            fmrListaReservas_Load_1(sender, e);
        }

        private void btnEspacio_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvReservas.Rows)
            {
                if (row.Cells[3].Value.ToString() == cbEspacio.Text)
                {
                    row.Visible = true;
                }
                else
                {
                    dgvReservas.Rows.Remove(row);
                }
            }
            Limpiar();
            actualiarCombobox();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvReservas.Rows)
            {
                if (row.Cells[2].Value.ToString() == cbCliente.Text)
                {
                    row.Visible = true;
                }
                else
                {
                    dgvReservas.Rows.Remove(row);
                }
            }
            Limpiar();
            actualiarCombobox();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvReservas.Rows)
            {
                if (row.Cells[4].Value.ToString() == cbUsuario.Text)
                {
                    row.Visible = true;
                }
                else
                {
                    dgvReservas.Rows.Remove(row);
                }
            }
            Limpiar();
            actualiarCombobox();
        }

        private void dgvReservas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dgvReservas.Columns[e.ColumnIndex].HeaderText == "Ver" && e.RowIndex != -1)
            {
                fmrReserva reserva = new fmrReserva(usuario, dgvReservas.Rows[e.RowIndex].Cells[0].Value.ToString(), dgvReservas.Rows[e.RowIndex].Cells[1].Value.ToString());
                reserva.Show();
            }
            else if(dgvReservas.Columns[e.ColumnIndex].HeaderText == "Borrar" && e.RowIndex != -1)
            {
                if(rol != "Administrador")
                {
                    MessageBox.Show("Contacte un administrador, solo ellos tienen el permiso de eliminar reservas");
                }
                else
                {
                    DialogResult result = MessageBox.Show("¿Seguro que desea eliminar esta reserva?", "ADVERTENCIA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if(result == DialogResult.Yes)
                    {
                        reserva.Pd_Fecha = dgvReservas.Rows[e.RowIndex].Cells[0].Value.ToString();
                        reserva.Pd_Hora = dgvReservas.Rows[e.RowIndex].Cells[1].Value.ToString();
                        reserva.eliminarReserva();
                        MessageBox.Show("Se elimino la reserva correctamente");
                        dgvReservas.Rows.RemoveAt(e.RowIndex);
                    }
                }
            }
        }
    }
}
