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
    public class clsEmpleados
    {
        public string Pd_id { get; set; }
        public string Pd_name { get; set; }
        public string Pd_nacimiento { get; set; }

        public string Pd_rh { get; set; }
        public string Pd_contacto { get; set; }
        public string Pd_email { get; set; }
        public string Pd_eps { get; set; }
        public string Pd_peso { get; set; }
        public string Pd_altura { get; set; }
        public string Pd_camiseta { get; set; }
        public string Pd_direccion { get; set; }
        public string Pd_comentarios { get; set; }
        public string Pd_ingreso { get; set; }
        public string Pd_estado { get; set; }
        public string Pd_reingresos { get; set; }
        public string Pd_cargo { get; set; }
        public string Pd_salario { get; set; }
        public string Pd_moneda { get; set; }
        public string Pd_retiro { get; set; }
        public string Pd_arl { get; set; }
        public string Pd_motivo { get; set; }
        public string Pd_modifica { get; set; }
        public string Pd_foto { get; set; }
        public string Pd_zapato { get; set; }
        public string Pd_pantalon { get; set; }
        public string Pd_TipoDoc { get; set; }
        public DataTable cargarEmpleados()
        {
            try
            {
                string sentencia = "Select ID,Nombre,Fecha_nacimiento,Cargo,Estado from tbEmpleados";
                DataTable data = new DataTable();
                Cls_Acceso_Datos acceso = new Cls_Acceso_Datos();
                data = acceso.EjecutarConsulta(sentencia);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los empleados " + ex);
            }
        }
        public DataTable filtrarTexto(string texto, string campo)
        {
            try
            {
                string sentencia = $"Select ID,Nombre,Edad,Cargo,Estado from tbEmpleados where {campo} like '%{texto}%'";
                DataTable data = new DataTable();
                Cls_Acceso_Datos acceso = new Cls_Acceso_Datos();
                data = acceso.EjecutarConsulta(sentencia);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los empleados " + ex);
            }
        }
        public DataTable cargarCargos()
        {
            try
            {
                string sentencia = "Select Nombre from tbCargos";
                DataTable data = new DataTable();
                Cls_Acceso_Datos acceso = new Cls_Acceso_Datos();
                data = acceso.EjecutarConsulta(sentencia);
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los empleados " + ex);
            }
        }
        public DataTable cargarEstados()
        {
            try
            {;
                DataTable data = new DataTable();
                data.Columns.Add();
                data.Rows.Add("Activo");
                data.Rows.Add("Inactivo");
                return data;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar los empleados " + ex);
            }
        }
        public void eliminarEmpleado(int id)
        {
            try
            {
                string comando = $"Delete from tbEmpleados where ID = '{id}'";
                Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
                datos.EjecutarComando(comando);
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo eliminar el empleado " + ex);
            }
        }

        public int calcularEdad(DateTime date)
        {
            int edad = DateTime.Now.Year - date.Year;
            if (date.Date > DateTime.Now.Date.AddYears(-edad))
            {
                edad--;
            }
            return edad;
        }
        public string calcularAntiguedad(DateTime date)
        {
            int años = DateTime.Now.Year - date.Year;
            int mes;
            int dia;
            if (date.Month > DateTime.Now.Month)
            {
                años--;
                mes = DateTime.Now.Month - date.Month + 12;
            }
            else
            {
                mes = DateTime.Now.Month - date.Month;
            }
            if (date.Day > DateTime.Now.Day)
            {
                mes--;
                dia = DateTime.Now.Day - date.Day + 30;
            }
            else
            {
                dia = DateTime.Now.Day - date.Day;
            }
            return dia + " días, " + mes + " meses, " + años + " años";
        }
        public string agregarEmpleado()
        {
            try
            {
                Cls_Acceso_Datos cls_Acceso = new Cls_Acceso_Datos();
                string sentencia = $"Insert into tbEmpleados (ID,Nombre,Fecha_nacimiento,RH,Contacto,Email,Eps,Peso,Altura,Camiseta,Direccion,Comentarios,Fecha_ingreso,Estado,Reingresos,Cargo,Salario,Moneda,Arl,Motivo,Usuario_Modifica,Foto,Pantalon,Zapatos,Tipo_documento) values ('{Pd_id}','{Pd_name}','{Pd_nacimiento}','{Pd_rh}','{Pd_contacto}','{Pd_email}','{Pd_eps}','{Pd_peso}','{Pd_altura}','{Pd_camiseta}','{Pd_direccion}','{Pd_comentarios}','{Pd_ingreso}','{Pd_estado}','0','{Pd_cargo}','{Pd_salario}','{Pd_moneda}','{Pd_arl}','{Pd_motivo}','{Pd_modifica}','{Pd_foto}','{Pd_zapato}','{Pd_pantalon}','{Pd_TipoDoc}')";
                cls_Acceso.EjecutarComando(sentencia);
                return "Se agrego correctamente el nuevo empleado";
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo agregar el empleado correctamente " + ex);
            } 
        }
        public string actualizarEmpleado()
        {
            try
            {
                Cls_Acceso_Datos cls_Acceso = new Cls_Acceso_Datos();
                string sentencia = $"update tbEmpleados set Nombre = '{Pd_name}',Fecha_nacimiento = '{Pd_nacimiento}',RH = '{Pd_rh}',Contacto = '{Pd_contacto}',Email = '{Pd_email}',Eps = '{Pd_eps}',Peso = '{Pd_peso}',Altura = '{Pd_altura}',Camiseta = '{Pd_camiseta}',Direccion = '{Pd_direccion}',Comentarios = '{Pd_comentarios}',Fecha_ingreso = '{Pd_ingreso}',Estado = '{Pd_estado}',Reingresos = '{Pd_reingresos}',Cargo = '{Pd_cargo}',Salario = '{Pd_salario}',Moneda = '{Pd_moneda}',Fecha_retiro = '{Pd_retiro}',Arl = '{Pd_arl}',Motivo = '{Pd_motivo}',Usuario_Modifica = '{Pd_modifica}',Foto = '{Pd_foto}',Pantalon = '{Pd_pantalon}',Zapatos = '{Pd_zapato}', Tipo_documento = '{Pd_TipoDoc}' where ID = '{Pd_id}'";
                cls_Acceso.EjecutarComando(sentencia);
                return "Se actualizo correctamente el empleado";
            }
            catch (Exception ex)
            {
                throw new Exception("No se pudo actualizar el empleado correctamente " + ex);
            }
        }
        public DataTable cargarEmpleado(int id)
        {
            try
            {
                Cls_Acceso_Datos datos = new Cls_Acceso_Datos();
                DataTable table = new DataTable();
                string sentencia = $"Select * from tbEmpleados where ID = '{id}'";
                table = datos.EjecutarConsulta(sentencia);
                return table;
        }
            catch(Exception ex)
            {
                throw new Exception("No se pudo cargar el empleado " + ex);
            }
        }
        public string distanciaFechas(DateTime inicio, DateTime final)
        {
            TimeSpan time = final - inicio;
            int años = time.Days / 365;
            int meses = time.Days % 365 / 30;
            int dias = time.Days % 365 % 30;
            return dias + " días, " + meses + " meses, " + años + " años";
        }
    }
}
