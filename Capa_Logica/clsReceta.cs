using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;
using System.Data;

namespace Capa_Logica
{
    public class clsReceta
    {
        public string Receta { get; set; }
        public string Ingrediente { get; set; }
        public string Cantidad { get; set; }
        public string Unidad { get; set; }
        public string Valor { get; set; }
        public string Usuario { get; set; }

        DataTable data = new DataTable();
        Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
        public DataTable cargarProducto()
        {
            try
            {
                string sentencia = "select Nombre from tbProductos where Centro = 'Cocina'";
                data = datos.EjecutarConsulta(sentencia);
                return data;
            }
            catch(Exception ex)
            {
                throw new Exception("No se pudo cargar la información de los productos" + ex);
            }
        }
        public DataTable cargarIngredientes()
        {
            try
            {
                string sentencia = "select Nombre from tbIngredientes";
                data = datos.EjecutarConsulta(sentencia);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo cargar la información de los ingredientes" + ex);
            }
        }
        public DataTable buscarUnidades(string nombre)
        {
            try
            {
                string sentencia = $"select Unidad,Precio from tbIngredientes where Nombre = '{nombre}'";
                data = datos.EjecutarConsulta(sentencia);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo cargar la información del ingrediente " + ex);
            }
        }
        public DataTable consultarReceta(string nombre)
        {
            try
            {
                string sentencia = $"select Ingrediente,Cantidad,Unidad,Valor from tbRecetas where Nombre = '{nombre}'";
                data = datos.EjecutarConsulta(sentencia);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo cargar la información de la receta " + ex);
            }
        }
        public void eliminarReceta()
        {
            try
            {
                string sentencia = $"delete from tbRecetas where Nombre = '{Receta}'";
                datos.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar la receta " + ex);
            }
        }
        public void agregarReceta()
        {
            try
            {
                string sentencia = $"insert into tbRecetas (Nombre,Ingrediente,Cantidad,Unidad,Valor,Usuario_modifica) values ('{Receta}','{Ingrediente}','{Cantidad}','{Unidad}','{Valor}','{Usuario}')";
                datos.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo agregar la receta " + ex);
            }
        }
    }
}
