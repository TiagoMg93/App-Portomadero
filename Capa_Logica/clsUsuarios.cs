using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;
using System.Data;

namespace Capa_Logica
{
    public class clsUsuarios
    {
        public string Pd_Id { get; set; }
        public string Pd_Usuario { get; set; }
        public string Pd_Password { get; set; }
        public string Pd_Rol { get; set; }
        Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
        DataTable table = new DataTable();
        public DataTable cargarUsuarios()
        {
            try
            {
                string sentencia = "Select * from tbUsuarios";
                table = datos.EjecutarConsulta(sentencia);
                return table;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo cargar la información correctamente " + ex);
            }
        }
        public void agregarUsuario(string usuario)
        {
            try
            {
                string sentencia = $"Insert into tbUsuarios (ID,Usuario,Password,Rol,Usuario_modifica) values ('{Pd_Id}','{Pd_Usuario}','{Pd_Password}','{Pd_Rol}','{usuario}')";
                datos.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo agregar el usuario " + ex);
            }
        }
        public void actualizarUsuario(string usuario)
        {
            try
            {
                string sentencia = $"update tbUsuarios set  Usuario = '{Pd_Usuario}',Password = '{Pd_Password}', Rol = '{Pd_Rol}', Usuario_modifica = '{usuario}' where ID = '{Pd_Id}'";
                datos.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar el usuario " + ex);
            }
        }
        public void eliminarUsuario()
        {
            try
            {
                string sentencia = $"Delete from tbUsuarios where Id = '{Pd_Id}'";
                datos.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar el cargo " + ex);
            }
        }
        public DataTable cargarRoles()
        {
            try
            {
                string sentencia = "Select Nombre from tbRoles";
                table = datos.EjecutarConsulta(sentencia);
                return table;
            }
            catch(Exception ex)
            {
                throw new Exception("No se pudo cargar la información correctamente " + ex);
            }
        }
    }
}
