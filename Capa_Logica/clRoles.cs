using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Capa_AccesoDatos;

namespace Capa_Logica
{
    public class clRoles
    {
        public DataTable cargarRoles()
        {
            try
            {
                DataTable data = new DataTable();
                Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
                string sentencia = $"Select Nombre,Descripcion from tbRoles";
                data = datos.EjecutarConsulta(sentencia);
                return data;
            }
            catch(Exception ex)
            {
                throw new Exception("No se pudo cargar los roles " + ex);
            }
        }
    }
}
