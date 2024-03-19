using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_AccesoDatos;
using System.Data;

namespace Capa_Logica
{
    public class clsCategorias
    {
        public string Pd_Nombre { get; set; }
        public string Pd_Descripcion { get; set; }
        public string Pd_Usuario { get; set; }
        public string Pd_Costos { get; set; }
        public DataTable cargarCategorias()
        {
            try
            {
                string sentencia = $"Select * from tbCategorias";
                DataTable data = new DataTable();
                Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
                data = datos.EjecutarConsulta(sentencia);
                return data;
            }
            catch(Exception ex)
            {
                throw new Exception("No se pudo cargar las categorias " + ex);
            }
        }
        public void agregarCategoria()
        {
            try
            {
                string sentencia = $"Insert into tbCategorias (Nombre,Descripcion,Usuario_modifica,Centro_costos) values ('{Pd_Nombre}','{Pd_Descripcion}','{Pd_Usuario}','{Pd_Costos}')";
                Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
                datos.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo agregar la categoria " + ex);
            }
        }
        public void actualizarCategoria()
        {
            try
            {
                string sentencia = $"update tbCategorias set  Descripcion = '{Pd_Descripcion}', Usuario_modifica = '{Pd_Usuario}', Centro_costos = '{Pd_Costos}' where Nombre = '{Pd_Nombre}'";
                Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
                datos.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar la categoria " + ex);
            }
        }
        public void eliminarCategoria()
        {
            try
            {
                string sentencia = $"Delete from tbCategorias where Nombre = '{Pd_Nombre}'";
                Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
                datos.EjecutarComando(sentencia);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar la categoria " + ex);
            }
        }
    }
}
