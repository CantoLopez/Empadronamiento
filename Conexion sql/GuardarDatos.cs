using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empadronamiento.Conexion_sql
{
    internal class GuardarDatos
    {

        // Declaramos las variables
        private int Cui;
        private string 
            Pnombre, 
            Snombre, 
            Tnombre, 
            Papellido, 
            Sapelldio, 
            CasaApellido, 
            Fecha, 
            Pais, 
            Estado, 
            Ciudad, 
            Correo;

        //Creamos un constructor de las variables
        public GuardarDatos(int cui, string pnombre, string snombre, string tnombre, string papellido, string sapelldio, string casaApellido, string fecha, string pais, string estado, string ciudad, string correo)
        {
            this.Cui = cui;
            this.Pnombre = pnombre;
            this.Snombre = snombre;
            this.Tnombre = tnombre;
            this.Papellido = papellido;
            this.Sapelldio = sapelldio;
            this.CasaApellido = casaApellido;
            this.Fecha = fecha;
            this.Pais = pais;
            this.Estado = estado;
            this.Ciudad = ciudad;
            this.Correo = correo;
        }

        //Creamos segundo metedo para acceder a los metodo de la clase

        public GuardarDatos() { 

        }

        //Metodo Get - Set

        public int Cui1 { get => Cui; set => Cui = value; }
        public string Pnombre1 { get => Pnombre; set => Pnombre = value; }
        public string Snombre1 { get => Snombre; set => Snombre = value; }
        public string Tnombre1 { get => Tnombre; set => Tnombre = value; }
        public string Papellido1 { get => Papellido; set => Papellido = value; }
        public string Sapelldio1 { get => Sapelldio; set => Sapelldio = value; }
        public string CasaApellido1 { get => CasaApellido; set => CasaApellido = value; }
        public string Fecha1 { get => Fecha; set => Fecha = value; }
        public string Pais1 { get => Pais; set => Pais = value; }
        public string Estado1 { get => Estado; set => Estado = value; }
        public string Ciudad1 { get => Ciudad; set => Ciudad = value; }
        public string Correo1 { get => Correo; set => Correo = value; }

    }
}
