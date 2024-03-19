using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using Capa_AccesoDatos;

namespace Capa_Logica
{
    public class clsFactura
    {
        public string Pd_Cantidad { get; set; }
        public string Pd_Producto { get; set; }
        public string Pd_Subtotal { get; set; }
        public string Pd_Pago { get; set; }
        public string Pd_Cambio { get; set; }
        public string Pd_Vendedor { get; set; }
        public string Pd_Cliente { get; set; }

        public DataTable cargarCategorias()
        {
            try
            {
                string sentencia = $"SELECT Nombre FROM tbCategorias";
                Cls_Acceso_Datos cls_Acceso = new Cls_Acceso_Datos();
                DataTable data = new DataTable();
                data = cls_Acceso.EjecutarConsulta(sentencia);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar las categorias " + ex);
            }
        }
        public DataTable consultarProductos(string texto)
        {
            try
            {
                string sentencia = $"SELECT Nombre,Foto FROM tbProductos where Categoria = '{texto}'";
                Cls_Acceso_Datos cls_Acceso = new Cls_Acceso_Datos();
                DataTable data = new DataTable();
                data = cls_Acceso.EjecutarConsulta(sentencia);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar los productos " + ex);
            }
        }
        public DataTable cargarProductos()
        {
            try
            {
                string sentencia = $"SELECT Nombre,Foto FROM tbProductos";
                Cls_Acceso_Datos cls_Acceso = new Cls_Acceso_Datos();
                DataTable data = new DataTable();
                data = cls_Acceso.EjecutarConsulta(sentencia);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los productos " + ex);
            }
        }
        public DataTable consultarInventario(string nombre)
        {
            try
            {
                string sentencia = $"SELECT Cantidad FROM tbProductos Where Nombre = '{nombre}'";
                Cls_Acceso_Datos cls_Acceso = new Cls_Acceso_Datos();
                DataTable data = new DataTable();
                DataTable pedido = new DataTable();
                int disponible = 0;
                data = cls_Acceso.EjecutarConsulta(sentencia);
                sentencia = $"SELECT Sum(Cantidad) as Pedidos FROM tbPedidos Where Producto = '{nombre}' and Pago ='No'";
                pedido = cls_Acceso.EjecutarConsulta(sentencia);
                for(int fila = 0; fila < pedido.Rows.Count; fila++)
                {
                    try
                    {
                        disponible += int.Parse(pedido.Rows[0][fila].ToString());
                    }
                    catch
                    {
                        disponible = 0;
                    }
                }
                disponible = int.Parse(data.Rows[0][0].ToString()) - disponible;
                data.Rows[0][0] = disponible;
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la consulta de stoke " + ex);
            }
        }
        public DataTable consultarPrecio(string nombre)
        {
            try
            {
                string sentencia = $"SELECT Precio FROM tbProductos Where Nombre = '{nombre}'";
                Cls_Acceso_Datos cls_Acceso = new Cls_Acceso_Datos();
                DataTable data = new DataTable();
                data = cls_Acceso.EjecutarConsulta(sentencia);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al consultar el precio " + ex);
            }
        }
        public DataTable cargarClientes()
        {
            try
            {
                string sentencia = $"SELECT Nombre FROM tbClientes";
                Cls_Acceso_Datos cls_Acceso = new Cls_Acceso_Datos();
                DataTable data = new DataTable();
                data = cls_Acceso.EjecutarConsulta(sentencia);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los clientes " + ex);
            }
        }
        public void actualizarInventario(string nombre)
        {
            try
            {
                string sentencia = $"UPDATE tbProductos set Cantidad = {Pd_Cantidad} where Nombre = '{nombre}'";
                Cls_Acceso_Datos cls_Acceso = new Cls_Acceso_Datos();
                cls_Acceso.EjecutarComando(sentencia);       
            }
            catch(Exception ex)
            {
                throw new Exception("Error en la actualizacion del inventario " + ex);
            }
        }
        public DataTable cargarNumFac()
        {
            try
            {
                string sentencia = $"Select Max(Distinct NumFactura) as 'Factura anterior' from tbFacturas";
                Cls_Acceso_Datos cls_Acceso = new Cls_Acceso_Datos();
                DataTable dt = new DataTable();
                dt = cls_Acceso.EjecutarConsulta(sentencia);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error no se pudo cargar el número de factura " + ex);
            }
        }
        public void agregarFactura(string numFac, string producto, string cantidad,string subtotal, string pago, string cambio, string vendedor, string cliente)
        {
            try
            {
                DateTime time = DateTime.Now;
                string sentencia = $"INSERT INTO tbFacturas (NumFactura,Producto,Cantidad,Subtotal,Pago,Cambio,Vendedor,Cliente,Fecha) values('{numFac}','{producto}','{cantidad}','{subtotal}','{pago}','{cambio}','{vendedor}','{cliente}','{time}')";
                Cls_Acceso_Datos cls_Acceso = new Cls_Acceso_Datos();
                cls_Acceso.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en ingresar la información de la factura " + ex);
            }
        }
        public DataTable buscarProducto(string nombre)
        {
            try
            {
                string sentencia = $"SELECT Nombre,Precio FROM tbProductos where Nombre = '{nombre}'";
                Cls_Acceso_Datos cls_Acceso = new Cls_Acceso_Datos();
                DataTable data = new DataTable();
                data = cls_Acceso.EjecutarConsulta(sentencia);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los clientes " + ex);
            }
        }
        public void modificarPedido(string nombre, string id)
        {
            try
            {
                string sentencia = $"Update tbPedidos set Pago = 'Si' where Producto ='{nombre}' and ID = '{id}'";
                Cls_Acceso_Datos cls_Acceso = new Cls_Acceso_Datos();
                cls_Acceso.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el pago del producto " + ex);
            }
        }
        public DataTable productoPendiente(string id)
        {
            try
            {
                string sentencia = $"SELECT Producto,Cantidad from tbPedidos where Pago = 'No' and ID = '{id}'";
                Cls_Acceso_Datos cls_Acceso = new Cls_Acceso_Datos();
                DataTable data = new DataTable();
                data = cls_Acceso.EjecutarConsulta(sentencia);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los clientes " + ex);
            }
        }
        public DataTable cargarFacturas()
        {
            try
            {
                string sentencia = $"SELECT NumFactura, Fecha, SUM(Subtotal) AS total_factura,Vendedor,Cliente FROM tbFacturas GROUP BY NumFactura,Fecha,Vendedor,Cliente";
                Cls_Acceso_Datos cls_Acceso = new Cls_Acceso_Datos();
                DataTable data = new DataTable();
                data = cls_Acceso.EjecutarConsulta(sentencia);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar las facturas " + ex);
            }
        }
        public DataTable cargarEmpleados()
        {
            try
            {
                Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
                DataTable data = new DataTable();
                string sentencia = "select Nombre from tbEmpleados";
                data = datos.EjecutarConsulta(sentencia);
                return data;
            }
            catch(Exception ex)
            {
                throw new Exception("Error al cargar los empleados " + ex);
            }
        }

        public DataTable filtrarFactura(string filtro, string texto)
        {
            try
            {
                Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
                DataTable data = new DataTable();
                string sentencia = $"SELECT NumFactura, Fecha, SUM(Subtotal) AS total_factura,Vendedor,Cliente FROM tbFacturas Where {filtro} = '{texto}' GROUP BY NumFactura,Fecha,Vendedor,Cliente";
                data = datos.EjecutarConsulta(sentencia);
                return data;
            }
            catch(Exception ex)
            {
                throw new Exception("Error al filtrar las facturas " + ex);
            }
        }

        public DataTable buscarFecha(string inicial, string final)
        {
            try
            {
                Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
                DataTable data = new DataTable();
                string sentencia = $"SELECT NumFactura, Fecha, SUM(Subtotal) AS total_factura,Vendedor,Cliente FROM tbFacturas Where Fecha Between '{inicial}' and '{final}' GROUP BY NumFactura,Fecha,Vendedor,Cliente";
                data = datos.EjecutarConsulta(sentencia);
                return data;
            }
            catch(Exception ex)
            {
                throw new Exception("Error al buscar la fecha establecida " + ex);
            }
        }

        public DataTable buscarNumFactura(string texto)
        {
            try
            {
                Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
                DataTable data = new DataTable();
                string sentencia = $"SELECT NumFactura, Fecha, SUM(Subtotal) AS total_factura,Vendedor,Cliente FROM tbFacturas Where NumFactura like '%{texto}%' GROUP BY NumFactura,Fecha,Vendedor,Cliente";
                data = datos.EjecutarConsulta(sentencia);
                return data;
            }
            catch(Exception ex)
            {
                throw new Exception("Error al buscar el número de factura " + ex);
            }
        }

        public DataTable filtrarProducto(string texto)
        {
            try
            {
                Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
                DataTable data = new DataTable();
                string sentencia = $"SELECT NumFactura, Fecha, SUM(Subtotal) AS total_factura,Vendedor,Cliente FROM tbFacturas GROUP BY NumFactura,Fecha,Vendedor,Cliente having SUM(CASE WHEN Producto = '{texto}' THEN 1 ELSE 0 END) > 0;";
                data = datos.EjecutarConsulta(sentencia);
                return data;
            }
            catch(Exception ex)
            {
                throw new Exception("Error al filtrar el producto " + ex);
            }
        }
        public DataTable consultarFactura(string texto)
        {
            try
            {
                Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
                DataTable data = new DataTable();
                string sentencia = $"select Cliente,Vendedor,Sum(Subtotal) as Total,Pago,Cambio,Fecha from tbFacturas where NumFactura = '{texto}' group by Cliente,Vendedor,Pago,Cambio,Fecha";
                data = datos.EjecutarConsulta(sentencia);
                return data;
            }
            catch(Exception ex)
            {
                throw new Exception("Error al buscar la factura " + ex);
            }
        }
        public DataTable verProductos(string texto)
        {
            try
            {
                Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
                DataTable data = new DataTable();
                string sentencia = $"SELECT Producto,tbFacturas.Cantidad,Precio,Subtotal from tbFacturas inner join tbProductos on tbFacturas.Producto = tbProductos.Nombre where NumFactura ='{texto}'";
                data = datos.EjecutarConsulta(sentencia);
                return data;
            }
            catch(Exception ex)
            {
                throw new Exception("Error al cargar los productos de la factura " + ex);
            }
        }

        public void eliminarFactura(string id)
        {
            try
            {
                Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
                string sentencia = $"DELETE From tbFacturas where NumFactura = '{id}'";
                datos.EjecutarComando(sentencia);
            }
            catch(Exception ex)
            {
                throw new Exception("Error al eliminar la factura " + ex);
            }
        }
    }
}
