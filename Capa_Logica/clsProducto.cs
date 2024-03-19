using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Capa_AccesoDatos;

namespace Capa_Logica
{
    public class clsProducto
    {
        public string Pd_Nombre { get; set; }
        public string Pd_Categoria { get; set; }
        public string Pd_Foto { get; set; }
        public string Pd_Costo { get; set; }
        public string Pd_Precio { get; set; }
        public string Pd_Cantidad { get; set; }
        public string Pd_Unidad{ get; set; }
        public string Pd_Usuario { get; set; }

        public string Pd_CentroCostos { get; set; }
        public void agregarProducto()
        {
            try
            {
                string sentencia = $"INSERT INTO tbProductos (Nombre,Categoria,Foto,Costo,Precio,Cantidad,Unidad,Usuario_modifica,Centro) VALUES ('{Pd_Nombre}','{Pd_Categoria}','{Pd_Foto}','{Pd_Costo}','{Pd_Precio}','{Pd_Cantidad}','{Pd_Unidad}','{Pd_Usuario}','{Pd_CentroCostos}')";
                Cls_Acceso_Datos Acceso = new Cls_Acceso_Datos();
                Acceso.EjecutarComando(sentencia);
            }
            catch(Exception ex)
            {
                throw new Exception("Error en la creacion del nuevo producto " + ex);
            }
        }

        public void editarProducto(int ID)
        {
            try
            {
                string sentencia = $"UPDATE tbProductos SET Categoria = '{Pd_Categoria}',Foto = '{Pd_Foto}',Costo = '{Pd_Costo}', Precio = '{Pd_Precio}', Cantidad ='{Pd_Cantidad}', Unidad = '{Pd_Unidad}',Usuario_modifica = '{Pd_Usuario}',Centro = '{Pd_CentroCostos}' WHERE Codigo = '{ID}'";
                Cls_Acceso_Datos Acceso = new Cls_Acceso_Datos();
                Acceso.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la actualizacion del producto " + ex);
            }
        }
        public void borrarProducto(int ID)
        {
            try
            {
                string sentencia = $"DELETE FROM tbProductos WHERE Codigo = '{ID}'";
                Cls_Acceso_Datos Acceso = new Cls_Acceso_Datos();
                Acceso.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar el producto " + ex);
            }
        }
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
        public DataTable cargarDatos(string nombre)
        {
            try
            {
                string sentencia = $"SELECT * FROM tbProductos Where Nombre ='{nombre}'";
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
        public DataTable cargarProductos()
        {
            try
            {
                string sentencia = $"SELECT Codigo,Nombre,Categoria,Costo,Precio,Cantidad FROM tbProductos";
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
        public DataTable cargarCentroCostos()
        {
            try
            {
                string sentencia = $"SELECT CentroCostos from tbCentroCostos";
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
    }
}
