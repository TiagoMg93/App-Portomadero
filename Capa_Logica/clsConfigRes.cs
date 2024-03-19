using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_AccesoDatos;

namespace Capa_Logica
{
    public class clsConfigRes
    {
        DataTable data = new DataTable();
        Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
        public string Pd_Dia { get; set; }
        public string Pd_Apertura { get; set; }
        public string Pd_Cierre { get; set; }
        public string Pd_Usuario { get; set; }
        public string Pd_Horas { get; set; }
        public string Pd_Minutos { get; set; }
        public DataTable cargarHorarios()        {

            try
            {
                string sentencia = "Select * from tbHorario";
                data = datos.EjecutarConsulta(sentencia);
                return data;
            }
            catch(Exception ex)
            {
                throw new Exception("No se pudo cargar los horarios " + ex);
            }
        }
        public void guardarHorario()
        {
            try
            {
                string sentencia = $"Update tbHorario set Entrada = '{Pd_Apertura}', Salida = '{Pd_Cierre}', Modifica = '{Pd_Usuario}', Horas = '{Pd_Horas}', Minutos = '{Pd_Minutos}' where Dia = '{Pd_Dia}'";
                datos.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar el horario " + ex);
            }
        }
    }
}
