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
    public partial class fmrReserva : Form
    {
        List<DateTime> horasFinales = new List<DateTime> { };
        List<DateTime> horasIniciales = new List<DateTime> { };
        string usuario;
        string fecha;
        string hora;
        public fmrReserva(string user,string date,string hour)
        {
            InitializeComponent();
            usuario = user;
            fecha = date;
            hora = hour;
        }
        DataTable table = new DataTable();
        clsReserva reserva = new clsReserva();
        private void fmrReserva_Load(object sender, EventArgs e)
        {
            try
            {
                if (fecha == "")
                {
                    try
                    {
                        table = reserva.cargarClientes();
                        foreach (DataRow row in table.Rows)
                        {
                            cbCliente.Items.Add(row[0].ToString());
                        }
                        cbCliente.Items.RemoveAt(0);
                        table.Rows.Clear();
                        table = reserva.cargarEspacios();
                        foreach (DataRow row in table.Rows)
                        {
                            cbMesa.Items.Add(row[0].ToString());
                        }
                    }
                    catch
                    {
                        MessageBox.Show("No se logro cargar la información correctamente");
                    }
                }
                else
                {
                    btnGuardar.Visible = false;
                    dtpFecha.Value = DateTime.Parse(fecha);
                    dtpFecha.Enabled = false;
                    try
                    {
                        reserva.Pd_Fecha = fecha;
                        reserva.Pd_Hora = hora;
                        cbHora.Enabled = true;
                        cbHora.Items.Clear();
                        cbHora.Items.Add(hora);
                        cbHora.SelectedIndex = 0;
                        table = reserva.consultarReserva();
                        cbMesa.Enabled = true;
                        cbMesa.Items.Clear();
                        cbMesa.Items.Add(table.Rows[0][3].ToString());
                        cbMesa.SelectedIndex = 0;
                        cbCliente.Items.Clear();
                        cbCliente.Items.Add(table.Rows[0][2].ToString());
                        cbCliente.SelectedIndex = 0;
                        tbComentario.Text = table.Rows[0][5].ToString();
                        tbComentario.Enabled = false;
                        cbCliente.Enabled = false;
                        cbHora.Enabled = false;
                        cbMesa.Enabled = false;
                    }
                    catch
                    {
                        MessageBox.Show("No se pudo cargar correctarmente la información de la reserva");
                    }
                }
            }
            catch
            {
                MessageBox.Show("No se pudo cargar la información de las reservas correctamente ");
            }
        }

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            cbHora.Enabled = true;
            cbMesa.Enabled = false;
            cbMesa.Items.Clear();
            cbMesa.Items.Add("");
            cbMesa.SelectedIndex = 0;
            cbHora.Items.Clear();
            try
            {
                string dia = dtpFecha.Value.ToString("dddd");
                TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
                table = reserva.consultarRango(ti.ToTitleCase(dia));
                List<string> horario = horarios(table.Rows[0][0].ToString(), table.Rows[0][1].ToString(), table.Rows[0][2].ToString(), table.Rows[0][3].ToString());
                foreach (string item in horario)
                {
                    cbHora.Items.Add(item);
                }
            }
            catch
            {
                MessageBox.Show("No se pudo cargar los horarios disponibles");
            }
        }
        public List<string> horarios(string apertura, string cierre, string horas, string minutos)
        {
            List<string> Lista = new List<string>();
            TimeSpan horaInicio = TimeSpan.Parse(apertura);
            TimeSpan horaFinal = TimeSpan.Parse(cierre);
            TimeSpan duracion = new TimeSpan(int.Parse(horas), int.Parse(minutos), 0);
            TimeSpan intervaloActual = horaInicio;
            int iteraciones = 0;
            while (intervaloActual.Add(duracion) <= horaFinal)
            {
                TimeSpan siguienteIntervalo;
                if (iteraciones == 0)
                {
                    siguienteIntervalo = intervaloActual;
                }
                else
                {
                    siguienteIntervalo = intervaloActual.Add(duracion);
                }
                horasIniciales.Add(DateTime.Parse(siguienteIntervalo.ToString()));
                horasFinales.Add(DateTime.Parse(siguienteIntervalo.Add(duracion).ToString()));
                string item;
                if (siguienteIntervalo.Hours < 10)
                {
                    if(siguienteIntervalo.Minutes < 10)
                    {
                        item = $"0{Convert.ToString((int)siguienteIntervalo.TotalHours)}:0{siguienteIntervalo.Minutes}";
                    }
                    else
                    {
                        item = $"0{Convert.ToString((int)siguienteIntervalo.TotalHours)}:{siguienteIntervalo.Minutes}";
                    }
                }
                else
                {
                    if(siguienteIntervalo.Minutes < 10)
                    {
                        item = Convert.ToString((int)siguienteIntervalo.TotalHours) + ":" + "0" + siguienteIntervalo.Minutes;
                    }
                    else
                    {
                        item = Convert.ToString((int)siguienteIntervalo.TotalHours) + ":" + siguienteIntervalo.Minutes;
                    }
                }
                Lista.Add(item);
                intervaloActual = siguienteIntervalo;
                iteraciones += 1;
            }
            return Lista;
        }
        public string extraerHora(DateTime date)
        {
            string hora;
            string minutos;
            if(date.Hour < 10)
            {
                hora = "0" + date.Hour.ToString();
            }
            else
            {
                hora = date.Hour.ToString();
            }
            if(date.Minute < 10)
            {
                minutos = "0" + date.Minute.ToString();
            }
            else
            {
                minutos = date.Minute.ToString();
            }
            return $"{hora}:{minutos}";
        }
        public void consultarDisponibilidad(DateTime fecha)
        {
            try
            {
                int recorrer = 0;
                while (recorrer < horasIniciales.Count)
                {
                    if (fecha.Hour >= horasIniciales[recorrer].Hour && fecha.Hour < horasFinales[recorrer].Hour)
                    {
                        table = reserva.consultarEspacios(fecha.ToShortDateString(), extraerHora(horasIniciales[recorrer]));
                        foreach (DataRow row in table.Rows)
                        {
                            cbMesa.Items.Remove(row[0].ToString());
                        }
                        recorrer = horasIniciales.Count;
                    }
                    else
                    {
                        recorrer += 1;
                    }
                }
            }
            catch
            {
                MessageBox.Show("No se pudo realizar la consulta de la disponibilidad de espacio");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbHora_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMesa.Enabled = true;
            cbMesa.Items.Clear();
            table = reserva.cargarEspacios();
            foreach (DataRow row in table.Rows)
            {
                cbMesa.Items.Add(row[0].ToString());
            }
            string fecha = dtpFecha.Value.ToShortDateString() + " " + cbHora.Text;
            consultarDisponibilidad(DateTime.Parse(fecha));
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            List<Control> controls = new List<Control>() {cbHora, cbMesa, cbCliente };
            int resultado = 0;
            if(dtpFecha.Value != null && dtpFecha.Value != DateTime.MinValue)
            {
                foreach(ComboBox control in controls)
                {
                    if(control.SelectedItem != null)
                    {
                        resultado = 0;
                    }
                    else
                    {
                        MessageBox.Show("Debe seleccionar primero " + control.Name);
                        resultado = 1;
                    }
                }
                if(resultado == 0)
                {
                    try
                    {
                        reserva.Pd_Fecha = dtpFecha.Value.ToShortDateString();
                        reserva.Pd_Hora = cbHora.Text;
                        reserva.Pd_Cliente = cbCliente.Text;
                        reserva.Pd_Espacio = cbMesa.Text;
                        reserva.Pd_Usuario = usuario;
                        reserva.Pd_Comentarios = tbComentario.Text;
                        reserva.guardarReserva();
                        MessageBox.Show("Se guardo correctamnte la reserva");
                        this.Close();
                    }
                    catch
                    {
                        MessageBox.Show("No se pudo guardar la reserva");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debes seleccionar una fecha primero");
            }
        }
    }
}
