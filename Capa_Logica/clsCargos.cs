using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;
using System.Data;

namespace Capa_Logica
{
    public class clsCargos
    {
        public string Pd_Cargo { get; set; }
        public string Pd_Descripcion { get; set; }
        Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
        DataTable table = new DataTable();
        public DataTable cargarCargos()
        {
            try
            {
                string sentencia = "Select * from tbCargos";
                table = datos.EjecutarConsulta(sentencia);
                return table;
            }
            catch(Exception ex)
            {
                throw new Exception("No se pudo cargar la información correctamente " + ex);
            }
        }
        public void agregarCargo(string usuario)
        {
            try
            {
                string sentencia = $"Insert into tbCargos (Nombre,Descripcion,Usuario_modifica) values ('{Pd_Cargo}','{Pd_Descripcion}','{usuario}')";
                datos.EjecutarComando(sentencia);
            }
            catch(Exception ex)
            {
                throw new Exception("No se pudo agregar el cargo " + ex);
            }
        }
        public void actualizarCargo(string usuario)
        {
            try
            {
                string sentencia = $"update tbCargos set  Descripcion = '{Pd_Descripcion}', Usuario_modifica = '{usuario}' where Nombre = '{Pd_Cargo}'";
                datos.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar el cargo " + ex);
            }
        }
        public void eliminarCargo()
        {
            try
            {
                string sentencia = $"Delete from tbCargos where Nombre = '{Pd_Cargo}'";
                datos.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar el cargo " + ex);
            }
        }
    }
}
