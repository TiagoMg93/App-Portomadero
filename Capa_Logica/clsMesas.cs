using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;
using System.Data;

namespace Capa_Logica
{
    public class clsMesas
    {
        DataTable data = new DataTable();
        Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
        public string Pd_Nombre { get; set; }
        public string Pd_Estado { get; set; }
        public string Pd_Ruta { get; set; }
        public string Pd_Modifica { get; set; }
        public DataTable cargarEspacios()
        {
            try
            {
                string sentencia = "Select * from tbMesas";
                data = datos.EjecutarConsulta(sentencia);
                return data;
            }
            catch(Exception ex)
            {
                throw new Exception("No se pudo cargar la información de los espacios " + ex);
            }
        }
        public void guardarMesa()
        {
            try
            {
                string sentencia = $"insert  into tbMesas (Nombre,Estado,Ruta,Modifica) values ('{Pd_Nombre}','{Pd_Estado}','{Pd_Ruta}','{Pd_Modifica}')";
                datos.EjecutarComando(sentencia);
            }
            catch(Exception ex)
            {
                throw new Exception("No se pudo agregar la información del espacio " + Pd_Nombre + " " + ex);
            }
        }
        public DataTable consultarMesa()
        {
            try
            {
                string sentencia = $"Select Nombre from tbMesas where Nombre = '{Pd_Nombre}'";
                data = datos.EjecutarConsulta(sentencia);
                return data;
            }
            catch(Exception ex)
            {
                throw new Exception("No se pudo validar si la mesa ya existe " + ex);
            }
        }
        public void actualizarMesa()
        {
            try
            {
                string sentencia = $"update tbMesas set Ruta = '{Pd_Ruta}', Modifica = '{Pd_Modifica}' where Nombre = '{Pd_Nombre}'";
                datos.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualiar la información de las mesa " + Pd_Nombre + " " + ex);
            }
        }
        public void eliminarMesa()
        {
            try
            {
                string sentencia = $"Delete from tbMesas where Nombre = '{Pd_Nombre}')";
                datos.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar la información de las mesa " + Pd_Nombre + " " + ex);
            }
        }
    }
}
