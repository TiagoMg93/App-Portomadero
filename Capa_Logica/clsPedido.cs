using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;
using System.Data;
using System.Data.SqlClient;

namespace Capa_Logica
{
    public class clsPedido
    {
        public DataTable cargarMesas()
        {
            try
            {
                string sentencia = "SELECT Numero from tbMesa where Estado = 'Disponible'";
                Cls_Acceso_Datos acceso_Datos = new Cls_Acceso_Datos();
                DataTable dt = new DataTable();
                dt = acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("No se logran cargar las mesas disponibles " + ex);
            }
        }
        public DataTable cargarEmpleados()
        {
            try
            {
                string sentencia = "SELECT Nombre from tbEmpleados";
                Cls_Acceso_Datos acceso_Datos = new Cls_Acceso_Datos();
                DataTable dt = new DataTable();
                dt = acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("No se logran cargar los empleados " + ex);
            }
        }
        public DataTable cargarCategorias()
        {
            try
            {
                string sentencia = "SELECT Nombre from tbCategorias";
                Cls_Acceso_Datos acceso_Datos = new Cls_Acceso_Datos();
                DataTable dt = new DataTable();
                dt = acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("No se logran cargar las categorias " + ex);
            }
        }
        public DataTable cargarProductos()
        {
            try
            {
                string sentencia = "SELECT Nombre from tbProductos";
                Cls_Acceso_Datos acceso_Datos = new Cls_Acceso_Datos();
                DataTable dt = new DataTable();
                dt = acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("No se logran cargar los productos " + ex);
            }
        }
        public DataTable consultarProductos(string categoria)
        {
            try
            {
                string sentencia = $"SELECT Nombre from tbProductos where Categoria = '{categoria}'";
                Cls_Acceso_Datos acceso_Datos = new Cls_Acceso_Datos();
                DataTable dt = new DataTable();
                dt = acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("No se logran cargar los productos " + ex);
            }
        }
        public DataTable consultarNumPed()
        {
            try
            {
                string sentencia = $"SELECT MAX(ID) From tbPedidos";
                Cls_Acceso_Datos acceso_Datos = new Cls_Acceso_Datos();
                DataTable dt = new DataTable();
                dt = acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("No se logro cargar el número de pedido " + ex);
            }
        }
        public void agregarPedido(string sentencia)
        {
            Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
            try
            {
                datos.EjecutarComando(sentencia);
            }
            catch(Exception ex)
            {
                throw new Exception("No se logro agregar el pedido " + ex);
            }
        }
        public DataTable consultarPedido(int ID)
        {
            try
            {
                string sentencia = $"SELECT * from tbPedidos where ID = '{ID}'";
                Cls_Acceso_Datos acceso_Datos = new Cls_Acceso_Datos();
                DataTable dt = new DataTable();
                dt = acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("No se logro cargar el número de pedido " + ex);
            }
        }
        public void eliminarPedido(int ID)
        {
            try
            {
                string sentencia = $"DELETE FROM tbPedidos where ID = '{ID}'";
                Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
                datos.EjecutarComando(sentencia);
            }
            catch(Exception ex)
            {
                throw new Exception("No se pudo eliminar el registro " + ex);
            }
        }
        public void cambiarMesa(string mesainicial, string mesanueva)
        {
            try
            {
                string sentencia = $"UPDATE tbMesa Set Estado = 'Disponible' where Numero = '{mesainicial}'";
                string sentencia2 = $"UPDATE tbMesa Set Estado = 'Ocupado' where Numero = '{mesanueva}'";
                Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
                datos.EjecutarComando(sentencia);
                datos.EjecutarComando(sentencia2);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo cambiar la mesa " + ex);
            }
        }
    }
}
