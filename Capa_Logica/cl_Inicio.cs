using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Capa_AccesoDatos;


namespace Capa_Logica
{
    public class cl_Inicio
    {
        public string txtUsuario { get; set; } //Se crean los atributos necesarios para la validación de usuario

        public string txtPassword { get; set; }

        public string txtRol { get; set; }//Se crean dos atributos necesarios para interactuar con el usuario y darle permisos en la app

        public string txtNombre { get; set; }

        public void ValidarUsuario() //Se busca en la base de datos si existe o no el usuario ingresado
        {
            try
            {
                string sentencia = $"SELECT Nombre,Rol FROM tbUsuarios Where Usuario = '{txtUsuario}' and Password = '{txtPassword}'";
                DataTable dt = new DataTable();
                Cls_Acceso_Datos Acceso = new Cls_Acceso_Datos();
                dt = Acceso.EjecutarConsulta(sentencia);
                foreach (DataRow fila in dt.Rows)
                {
                    txtNombre = fila[0].ToString();
                    txtRol = fila[1].ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error en la consulta " + ex);
            }
        }
    }
}
