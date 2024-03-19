using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;
using System.Data;

namespace Capa_Logica
{
    public class clsInventario
    {
        public string Pd_Item { get; set; }
        public string Pd_Cantidad { get; set; }
        public DataTable cargarInventario()
        {
            try
            {
                DataTable data = new DataTable();
                Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
                string sentencia = "Select Nombre,Cantidad from tbProductos";
                data = datos.EjecutarConsulta(sentencia);
                return data;
            }
            catch(Exception ex)
            {
                throw new Exception("No se pudo cargar los items " + ex);
            }
        }
        public void actualizarItem()
        {
            try
            {
                Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
                string sentencia = $"Update tbProductos set Cantidad = '{Pd_Cantidad}' where Nombre = '{Pd_Item}'";
                datos.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar el item " + ex);
            }
        }
    }
}
