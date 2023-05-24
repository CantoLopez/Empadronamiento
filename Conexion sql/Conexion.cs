using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empadronamiento.Conexion_sql
{
    internal class Conexion
    {
        // Declar las variables 
        private string Base, Servidor, Usuario, Clave;

        // Nos permite establecer metodo de autenticacion 

        private bool seguridad;

        //Crear un objeto de tipo de conexion
        //Nos serivera para compartir y relizar la conexion de la base de datos 
        
        private static Conexion con = null;

        private Conexion()
        {
            this.Base = "Empadronamiento";
            this.Servidor = "DESKTOP-29UMQGF\\SQLEXPRESS";
            this.Usuario = "SA";
            this.Clave = "Adolfo.10";
            this.seguridad = true;

        }

        //Metodo devolver string de conexion 

        public SqlConnection crearConexion()
        {
            //Variable de tipo SqlConnection 
            SqlConnection cadena = new SqlConnection();
            //controlar errores

            try
            {
                //cadena de conexion
                cadena.ConnectionString = "Server=" + this.Servidor + ";Database =" + this.Base + ";";

                //Condicional para saber el metodo de conexion 
                if (this.seguridad)
                {
                    cadena.ConnectionString = cadena.ConnectionString + "Integrated Security = SSPI";
                }
                else
                {
                    cadena.ConnectionString = cadena.ConnectionString + "User Id=" + this.Usuario + ";Password=" + this.Clave;
                }

            }
            catch (Exception ex)
            {
                cadena = null;
                throw ex; //Mostramos un mensaje del error de la conexion 
            }
            return cadena; //Devolver valor de cadena
        }
        //Metod para generar un instancion al constructor dentro de la clase 
        //Para activar las asignaciones de las variables al constructor 

        public static Conexion creaInstancia()
        {
            if (con == null)
            {
                con = new Conexion();
            }
            return con;
        }

    }
}
