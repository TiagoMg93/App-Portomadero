using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Capa_AccesoDatos
{
    public class Cls_parametros
    {
        public string Nombre { get; set; } //Se crea un atributo con el nombre del dato
        public object Valor { get; set; } //Se crea un atributo con el objeto que contiene el dato
        public SqlDbType TipoDato { get; set; } //Se crea un atributo con la tipologia del dato(char, varchar, string, etc.)
        public Int32 Tamaño { get; set; } //Se cuantifica el tamaño del dato todos y cada uno de sus caracteres
        public ParameterDirection Direccionparametro { get; set; } // Se necesita saber si el dato es de entrada o salida

        public Cls_parametros(string Objnombre, Object ObjValor) //Se crea un parametro donde se tiene el nombre del dato y el objeto que es su valor
        {
            Nombre = Objnombre; //Se actualizan los atributos de entrada
            Valor = ObjValor;
            Direccionparametro = ParameterDirection.Input;
        }

        public Cls_parametros(string Objnombre, SqlDbType ObjTipoDato, Int32 ObjTamaño) //Se crea un parametro para la salida de un dato de la base de datos
        {
            Nombre = Objnombre; //Se actualizan los atributos de salida
            TipoDato = ObjTipoDato;
            Tamaño = ObjTamaño;
            Direccionparametro = ParameterDirection.Output;
        }

    }

    public class Cls_Acceso_Datos //Se crea una clase para la conexión de la base de datos
    {
        SqlConnection conexion;
        SqlCommand cmd;
        SqlDataReader LectorDato = null;
        SqlDataAdapter da;
        DataTable dt;

        public string AbrirBD() //Parametro para abrir la base de datos
        {
            string resultado = "";
            try //Se comprueba con un try-catch para que muestre si hay un error en la conexion con el servidor
            {
                conexion = new SqlConnection($"Data Source = 'DESKTOP-108L2NP'; Initial Catalog = DBGENERAL; User ID = sa; Password = 8493");
                conexion.Open();
            }
            catch
            {
                resultado = "Error: no se estableció la conexión con la base de datos";
            }
            return resultado;
        }

        public string CerrarBD() //Parametro para cerrar la base de datos
        {
            string resultado = "";
            try
            {
                conexion.Close();
            }
            catch
            {
                resultado = "Error fallo al cerrar la base de datos";
            }
            return resultado;
        }

        public string EjecutarComando(string sentencia) //un parametro para los comandos insertar,modificar o eliminar
        {
            string salida = "";
            try
            {
                int retornado;
                AbrirBD();
                cmd = new SqlCommand(sentencia, conexion);
                retornado = cmd.ExecuteNonQuery();
                CerrarBD();
                if (retornado > 0)
                {
                    salida = "Los datos fueron actualizados";
                }
                else
                {
                    salida = "los datos no fueron actualizados";
                }
            }
            catch (Exception ex)
            {
                salida = "ERROR: falló la operación" + ex;
            }
            return salida;
        }
        public DataTable EjecutarConsulta(string cmd) //Si se desea sacar una consulta especifica de la base de datos
        {
            try
            {
                AbrirBD();
                da = new SqlDataAdapter(cmd, conexion);
                dt = new DataTable();
                da.Fill(dt);
                CerrarBD();
                return dt;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}