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
                string sentencia = "SELECT Nombre from tbMesas where Estado = 'Disponible'";
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
        public DataTable consultarPedidos()
        {
            try
            {
                string sentencia = $"select ID,Mesero,Mesa,Estado,Pago from tbPedidos where Estado = 'En proceso' group by ID,Mesero,Mesa,Estado,Pago";
                Cls_Acceso_Datos acceso_Datos = new Cls_Acceso_Datos();
                DataTable dt = new DataTable();
                dt = acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("No se logro cargar los pedido " + ex);
            }
        }
        public DataTable cargarTodasMesas()
        {
            try
            {
                string sentencia = "SELECT Numero from tbMesa";
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
        public DataTable filtrarMesero(string nombre)
        {
            try
            {
                string sentencia = $"select ID,Mesero,Mesa,Estado,Pago from tbPedidos where Mesero = '{nombre}' group by ID,Mesero,Mesa,Estado,Pago";
                Cls_Acceso_Datos acceso_Datos = new Cls_Acceso_Datos();
                DataTable dt = new DataTable();
                dt = acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("No se logran cargar los meseros " + ex);
            }
        }
        public DataTable filtrarMesa(string numero)
        {
            try
            {
                string sentencia = $"select ID,Mesero,Mesa,Estado,Pago from tbPedidos where Mesa = '{numero}' group by ID,Mesero,Mesa,Estado,Pago";
                Cls_Acceso_Datos acceso_Datos = new Cls_Acceso_Datos();
                DataTable dt = new DataTable();
                dt = acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("No se logran cargar las mesas " + ex);
            }
        }
        public DataTable filtrarEstado(string estado)
        {
            try
            {
                string sentencia = $"select ID,Mesero,Mesa,Estado,Pago from tbPedidos where Estado = '{estado}' group by ID,Mesero,Mesa,Estado,Pago";
                Cls_Acceso_Datos acceso_Datos = new Cls_Acceso_Datos();
                DataTable dt = new DataTable();
                dt = acceso_Datos.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("No se logran cargar el estado de los pedidos " + ex);
            }
        }
        public void actualizarEstado(string id)
        {
            try
            {
                string sentencia = $"Update tbPedidos set Estado = 'Terminado' where ID = '{id}'";
                Cls_Acceso_Datos acceso_Datos = new Cls_Acceso_Datos();
                acceso_Datos.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                throw new Exception("No se logra actualizar el estado del pedido " + ex);
            }
        }
        public DataTable consultarHorario(string diaHoy)
        {
            try
            {
                string sentencia = $"Select Entrada,Salida,Horas,Minutos from tbHorario where Dia = '{diaHoy}'";
                Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
                DataTable table = new DataTable();
                table = datos.EjecutarConsulta(sentencia);
                return table;
            }
            catch(Exception ex)
            {
                throw new Exception("No se pudo actualizar la zona horaria del dia de hoy " + ex);
            }
        }
        public DataTable consultarEspacios(string fecha, string hora)
        {
            try
            {
                DataTable data = new DataTable();
                Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
                string sentencia = $"Select Espacio from tbReservas where Fecha = '{fecha}' and Hora = '{hora}'";
                data = datos.EjecutarConsulta(sentencia);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo cargar la información de las reservas de la fecha seleccionada " + ex);
            }
        }
    }
}
