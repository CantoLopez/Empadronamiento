using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Empadronamiento.Conexion_sql
{
    internal class Funciones
    {
        public static int insertarDatos(GuardarDatos add) { 

            
            Conexion conexion = Conexion.creaInstancia();
            SqlConnection conex = conexion.crearConexion();
            conex.Open();

            int estado = 0;
            SqlCommand comando = new SqlCommand(string.Format("INSERT INTO Personas (CUI, PrimerNombre, SegundoNombre, TercerNombre, PrimerApellido, SegundoApellido, ApellidoCasada, FechaNacimiento, Pais, Estado, Ciudad, CorreoElectronico)VALUES('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}', '{11}' )", 
                add.Cui1, add.Pnombre1, add.Snombre1, add.Tnombre1 , add.Papellido1, add.Sapelldio1, add.CasaApellido1, add.Fecha1, add.Pais1, add.Estado1, add.Ciudad1, add.Correo1), conex);
            
            estado = comando.ExecuteNonQuery();

            return estado;

        }

        public static List<GuardarDatos> mostrarRegistro()
        {
            Conexion conexion = Conexion.creaInstancia();
            SqlConnection conex = conexion.crearConexion();
            conex.Open();

            List<GuardarDatos> lista = new List<GuardarDatos>();
            SqlCommand comando = new SqlCommand("SELECT * FROM Personas", conex);

            SqlDataReader Leer = comando.ExecuteReader();

            while (Leer.Read())
            {
                GuardarDatos datos = new GuardarDatos();

                datos.Cui1 = Leer.GetInt32(0);
                datos.Pnombre1 = Leer.GetString(1);
                datos.Snombre1 = Leer.GetString(2);
                datos.Tnombre1 = Leer.GetString(3);
                datos.Papellido1 = Leer.GetString(4);
                datos.Sapelldio1 = Leer.GetString(5);
                datos.CasaApellido1 = Leer.GetString(6);
                datos.Fecha1 = Leer.GetDateTime(7).ToString("yyyy-MM-dd");
                datos.Pais1 = Leer.GetString(8);
                datos.Ciudad1 = Leer.GetString(9);
                datos.Estado1 = Leer.GetString(10);
                datos.Correo1 = Leer.GetString(11);

                lista.Add(datos);
            }

            Leer.Close(); // Cerrar el SqlDataReader
            conex.Close(); // Cerrar la conexión

            return lista;
        }

    }
}

