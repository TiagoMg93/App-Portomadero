using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;
using System.Data;

namespace Capa_Logica
{
    public class clsClientes
    {
        public string Pd_Documento { get; set; }
        public string Pd_Nombre { get; set; }
        public string Pd_Telefono { get; set; }
        public string Pd_Email { get; set; }
        public string Pd_Modifica { get; set; }

        public DataTable cargarClientes()
        {
            try
            {
                Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
                DataTable table = new DataTable();
                string sentencia = "Select * from tbClientes";
                table = datos.EjecutarConsulta(sentencia);
                return table;
            }
            catch(Exception ex)
            {
                throw new Exception("No se pudo cargar los clientes " + ex);
            }
        }
        public void agregarCliente()
        {
            try
            {
                Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
                string sentencia = $"insert into tbClientes (ID,Nombre,Telefono,Email,Usuario_modifica)values('{Pd_Documento}','{Pd_Nombre}','{Pd_Telefono}','{Pd_Email}','{Pd_Modifica}')";
                datos.EjecutarComando(sentencia);
            }
            catch(Exception ex)
            {
                throw new Exception("No se pudo agregar el nuevo cliente " + ex);
            }
        }
        public void actualizarCliente()
        {
            //try
            //{
                Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
                string sentencia = $"update tbClientes set Nombre = '{Pd_Nombre}',Telefono = '{Pd_Telefono}',Email = '{Pd_Email}',Usuario_modifica = '{Pd_Modifica}' where ID = '{Pd_Documento}'";
                datos.EjecutarComando(sentencia);
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception("No se pudo actualizar el cliente " + ex);
            //}
        }
        public void eliminarCliente()
        {
            //try
            //{
                Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
                string sentencia = $"delete from tbClientes where ID = '{Pd_Documento}'";
                datos.EjecutarComando(sentencia);
            //}
            //catch (Exception ex)
            //{
            //    throw new Exception("No se pudo eliminar el cliente " + ex);
            //}
        }
    }
}
