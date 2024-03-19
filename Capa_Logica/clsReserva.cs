using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_AccesoDatos;

namespace Capa_Logica
{
    public class clsReserva
    {
        DataTable data = new DataTable();
        Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
        public string Pd_Fecha { get; set; }
        public string Pd_Hora { get; set; }
        public string Pd_Cliente { get; set; }
        public string Pd_Espacio { get; set; }
        public string Pd_Usuario { get; set; }
        public string Pd_Comentarios { get; set; }
        public DataTable cargarReservas()
        {
            try
            {
                string sentencia = "Select * from tbReservas Order by Fecha DESC, Hora ASC";
                data = datos.EjecutarConsulta(sentencia);
                return data;
            }
            catch(Exception ex)
            {
                throw new Exception("No se pudo cargar la información de las reservas " + ex);
            }
        }
        public DataTable cargarClientes()
        {
            try
            {
                string sentencia = "Select Nombre from tbClientes";
                data = datos.EjecutarConsulta(sentencia);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo cargar la información de los clientes " + ex);
            }
        }
        public DataTable cargarEspacios()
        {
            try
            {
                string sentencia = "Select Nombre from tbMesas";
                data = datos.EjecutarConsulta(sentencia);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo cargar la información de los espacios " + ex);
            }
        }
        public DataTable consultarFecha(string consulta)
        {
            try
            {
                string sentencia = $"Select Hora from tbReservas where Fecha = '{consulta}'";
                data = datos.EjecutarConsulta(sentencia);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo cargar la información de las reservas de la fecha seleccionada " + ex);
            }
        }
        public DataTable consultarRango(string dia)
        {
            try
            {
                string sentencia = $"Select Entrada,Salida,Horas,Minutos from tbHorario where Dia = '{dia}'";
                data = datos.EjecutarConsulta(sentencia);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo cargar la información de las reservas de la fecha seleccionada " + ex);
            }
        }
        public DataTable consultarEspacios(string fecha,string hora)
        {
            try
            {
                string sentencia = $"Select Espacio from tbReservas where Fecha = '{fecha}' and Hora = '{hora}'";
                data = datos.EjecutarConsulta(sentencia);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo cargar la información de las reservas de la fecha seleccionada " + ex);
            }
        }
        public void guardarReserva()
        {
            try
            {
                string sentencia = $"Insert into tbReservas (Fecha,Hora,Cliente,Espacio,Usuario,Comentarios) values ('{Pd_Fecha}','{Pd_Hora}','{Pd_Cliente}','{Pd_Espacio}','{Pd_Usuario}','{Pd_Comentarios}')";
                datos.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo guardar la información de la reserva " + ex);
            }
        }
        public DataTable consultarFechas(string fechaInicial, string fechaFinal)
        {
            try
            {
                string sentencia = $"Select * from tbReservas where Fecha between '{fechaInicial}' and '{fechaFinal}' Order by Fecha DESC, Hora ASC";
                data = datos.EjecutarConsulta(sentencia);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo cargar la información de las reservas de las fechas seleccionada " + ex);
            }
        }
        public DataTable consultarReserva()
        {
            try
            {
                string sentencia = $"Select * from tbReservas where Fecha = '{Pd_Fecha}' and Hora = '{Pd_Hora}'";
                data = datos.EjecutarConsulta(sentencia);
                return data;
            }
            catch(Exception ex)
            {
                throw new Exception("No se encontro información de las fechas " + ex);
            }
        }
        public void eliminarReserva()
        {
            try
            {
                string sentencia = $"delete from tbReservas where Fecha = '{Pd_Fecha}' and Hora = '{Pd_Hora}'";
                datos.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar la reserva " + ex);
            }
        }
    }
}
