using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;
using System.Data;

namespace Capa_Logica
{
    public class clsIngredientes
    {
        DataTable data = new DataTable();
        Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
        public string Nombre { get; set; }
        public string Cantidad { get; set; }
        public string Unidad { get; set; }
        public string Usuario { get; set; }
        public string Precio { get; set; }

        public DataTable cargarIngredientes()
        {
            try
            {
                string sentencia = "select * from tbIngredientes";
                data = datos.EjecutarConsulta(sentencia);
                return data;
            }
            catch(Exception ex)
            {
                throw new Exception("No se pudo cargar los ingredientes " + ex);
            }
        }
        public void agregarIngrediente()
        {
            try
            {
                string sentencia = $"Insert into tbIngredientes(Nombre,Cantidad,Unidad,Precio,Usuario) values('{Nombre}','{Cantidad}','{Unidad}','{Precio}','{Usuario}')";
                datos.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo agregar el ingrediente " + ex);
            }
        }
        public void actualizarIngrediente()
        {
            try
            {
                string sentencia = $"update tbIngrediente set Cantidad = '{Cantidad}',Unidad = '{Unidad}',Precio = '{Precio}',Usuario = '{Usuario}' where Nombre = '{Nombre}'";
                datos.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar el ingrediente " + ex);
            }
        }
        public void eliminarIngrediente()
        {
            try
            {
                string sentencia = $"Delete from tbIngrediente where Nombre = '{Nombre}'";
                datos.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar el ingrediente " + ex);
            }
        }
    }
}
