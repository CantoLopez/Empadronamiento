using Empadronamiento.Conexion_sql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Empadronamiento
{
    public partial class FrmRegistro : Form
    {
        public FrmRegistro()
        {
            InitializeComponent();
        }
        public void rellenar()
        {
            TxtPnombre.Text = "* Primer Nombre";
            TxtSegundonombre.Text = "Segundo Nombre";
            TxtTercerNombre.Text = "Tecer Nombre";
            TxtApellido.Text = "* Primer Apellido";
            TxtSegundoApellido.Text = "Segundo Apellido";
            TxtApllidoCasada.Text = "Apellido de casada";
            TxtCui.Text = "* Ingrese su CUI - DPI";
            TxtFecha.Text = "* Fecha de nacimiento";
            TxtPaiz.Text = "País";
            TxtEstado.Text = "Estado";
            TxtCiudad.Text = "Ciudad";
            TxtCorreo.Text = "* Correo Electronico";
        }
        string nombreG;
        private void TxtPnombre_Enter(object sender, EventArgs e)
        {
            //nombreG = TxtPnombre.Text;
            if (TxtPnombre.Text == "* Primer Nombre")
            {
                TxtPnombre.Text = "";
                TxtPnombre.ForeColor = Color.DimGray;
            }
        }

        private void TxtPnombre_Leave(object sender, EventArgs e)
        {
            if (TxtPnombre.Text == "")
            {
                TxtPnombre.Text = "* Primer Nombre";                
                TxtPnombre.ForeColor = Color.LightGray;
            }
        }

        private void TxtSegundonombre_Enter(object sender, EventArgs e)
        {
            //nombreG = TxtSegundonombre.Text;
            if (TxtSegundonombre.Text == "Segundo Nombre")
            {
                TxtSegundonombre.Text = "";
                TxtSegundonombre.ForeColor = Color.DimGray;
            }
        }

        private void TxtSegundonombre_Leave(object sender, EventArgs e)
        {
            if (TxtSegundonombre.Text == "")
            {
                TxtSegundonombre.Text = "Segundo Nombre";              
                TxtSegundonombre.ForeColor = Color.LightGray;
            }
        }

        private void TxtTercerNombre_Enter(object sender, EventArgs e)
        {
            //nombreG = TxtTercerNombre.Text;
            if (TxtTercerNombre.Text == "Tercer Nombre")
            {
                TxtTercerNombre.Text = "";
                TxtTercerNombre.ForeColor = Color.DimGray;
            }
        }

        private void TxtTercerNombre_Leave(object sender, EventArgs e)
        {
            if (TxtTercerNombre.Text == "")
            {
                TxtTercerNombre.Text = "Tercer Nombre";                
                TxtTercerNombre.ForeColor = Color.LightGray;
            }
        }

        private void TxtApellido_Enter(object sender, EventArgs e)
        {
            //nombreG = TxtApellido.Text;
            if (TxtApellido.Text == "* Primer Apellido")
            {
                TxtApellido.Text = "";
                TxtApellido.ForeColor = Color.DimGray;
            }
        }

        private void TxtApellido_Leave(object sender, EventArgs e)
        {
            if (TxtApellido.Text == "")
            {
                TxtApellido.Text = "* Primer Apellido";                
                TxtApellido.ForeColor = Color.LightGray;
            }
        }

        private void TxtSegundoApellido_Enter(object sender, EventArgs e)
        {
            //nombreG = TxtSegundoApellido.Text;
            if (TxtSegundoApellido.Text == "Segundo Apellido")
            {
                TxtSegundoApellido.Text = "";
                TxtSegundoApellido.ForeColor = Color.DimGray;
            }
        }

        private void TxtSegundoApellido_Leave(object sender, EventArgs e)
        {
            if (TxtSegundoApellido.Text == "")
            {
                TxtSegundoApellido.Text = "Segundo Apellido";                
                TxtSegundoApellido.ForeColor = Color.LightGray;
            }
        }

        private void TxtApllidoCasada_Enter(object sender, EventArgs e)
        {
            //ombreG = TxtApllidoCasada.Text;
            if (TxtApllidoCasada.Text == "Apellido de casada")
            {
                TxtApllidoCasada.Text = "";
                TxtApllidoCasada.ForeColor = Color.DimGray;
            }
        }

        private void TxtApllidoCasada_Leave(object sender, EventArgs e)
        {
            if (TxtApllidoCasada.Text == "")
            {
                TxtApllidoCasada.Text = "Apellido de casada";                
                TxtApllidoCasada.ForeColor = Color.LightGray;
            }
        }

        private void TxtDiseño_Enter(object sender, EventArgs e)
        {
            //nombreG = TxtCui.Text;
            if (TxtCui.Text == "* Ingrese su CUI - DPI")
            {
                TxtCui.Text = "";
                TxtCui.ForeColor = Color.DimGray;
            }
        }

        private void TxtDiseño_Leave(object sender, EventArgs e)
        {
            if (TxtCui.Text == "")
            {
                TxtCui.Text = "* Ingrese su CUI - DPI";                
                TxtCui.ForeColor = Color.LightGray;
            }
        }

        private void TxtFecha_Enter(object sender, EventArgs e)
        {
            //nombreG = TxtFecha.Text;
            if (TxtFecha.Text == "* Fecha de nacimiento")
            {
                TxtFecha.Text = "";
                TxtFecha.ForeColor = Color.DimGray;
            }
        }

        private void TxtFecha_Leave(object sender, EventArgs e)
        {
            if (TxtFecha.Text == "")
            {
                TxtFecha.Text = "* Fecha de nacimiento";                
                TxtFecha.ForeColor = Color.LightGray;
            }
        }

        private void TxtPaiz_Enter(object sender, EventArgs e)
        {
            //nombreG = TxtPaiz.Text;
            if (TxtPaiz.Text == "País")
            {
                TxtPaiz.Text = "";
                TxtPaiz.ForeColor = Color.DimGray;
            }
        }

        private void TxtPaiz_Leave(object sender, EventArgs e)
        {
            if (TxtPaiz.Text == "")
            {
                TxtPaiz.Text = "País";               ;
                TxtPaiz.ForeColor = Color.LightGray;
            }
        }

        private void TxtEstado_Enter(object sender, EventArgs e)
        {
            //nombreG = TxtEstado.Text;
            if (TxtEstado.Text == "Estado")
            {
                TxtEstado.Text = "";
                TxtEstado.ForeColor = Color.DimGray;
            }
        }

        private void TxtEstado_Leave(object sender, EventArgs e)
        {
            if (TxtEstado.Text == "")
            {
                TxtEstado.Text = "Estado";                
                TxtEstado.ForeColor = Color.LightGray;
            }
        }

        private void TxtCiudad_Enter(object sender, EventArgs e)
        {
            //nombreG = TxtCiudad.Text;
            if (TxtCiudad.Text == "Ciudad")
            {
                TxtCiudad.Text = "";
                TxtCiudad.ForeColor = Color.DimGray;
            }
        }

        private void TxtCiudad_Leave(object sender, EventArgs e)
        {
            if (TxtCiudad.Text == "")
            {
                TxtCiudad.Text = "Ciudad";                
                TxtCiudad.ForeColor = Color.LightGray;
            }
        }

        private void TxtCorreo_Enter(object sender, EventArgs e)
        {
            //nombreG = TxtCorreo.Text;
            if (TxtCorreo.Text == "* Correo Electronico")
            {
                TxtCorreo.Text = "";
                TxtCorreo.ForeColor = Color.DimGray;
            }
        }

        private void TxtCorreo_Leave(object sender, EventArgs e)
        {
            if (TxtCorreo.Text == "")
            {
                TxtCorreo.Text = "* Correo Electronico";                
                TxtCorreo.ForeColor = Color.LightGray;
            }
        }

        private void BtnGuardado_Click(object sender, EventArgs e)
        {
            //Instanciar la clase guardarDatos

            GuardarDatos insertar = new GuardarDatos();


            //Inviar Datos a la guardarDatos
            //Info se envia despues a Funciones

            int valor0, valor1, valor2, valor3, valor4, valor5, valor6, valor8, valor9, valor10, valor11;
            DateTime Fecha;
            bool n1 = int.TryParse(TxtPnombre.Text, out valor0);
            bool n2 = int.TryParse(TxtSegundonombre.Text, out valor1);
            bool n3 = int.TryParse(TxtTercerNombre.Text, out valor2);
            bool ap1 = int.TryParse(TxtApellido.Text, out valor3);
            bool ap2 = int.TryParse(TxtSegundoApellido.Text, out valor4);
            bool ap3 = int.TryParse(TxtTercerNombre.Text, out valor5);
            bool cui = int.TryParse(TxtCui.Text, out valor6);
            bool fec = DateTime.TryParse(TxtFecha.Text, out Fecha);
            bool pais = int.TryParse(TxtPaiz.Text, out valor8);
            bool est = int.TryParse(TxtEstado.Text, out valor9);
            bool ciu = int.TryParse(TxtCiudad.Text, out valor10);
            bool corr = int.TryParse(TxtCorreo.Text, out valor11);

            if (TxtPnombre.Text == "* Primer Nombre" || TxtApellido.Text == "* Primer Apellido" || TxtCui.Text == "* Ingrese su CUI - DPI" || TxtFecha.Text == "* Fecha de nacimiento" || TxtCorreo.Text == "* Correo Electronico")
            {
                MessageBox.Show("Error dejo un campo vacio");
                return;
            }
            else if (n1 == true || n2 == true || n3 == true || ap1 == true || ap2 == true || ap3 == true || cui == false || fec == false || pais == true || est == true || ciu == true || corr == true)
            {
                MessageBox.Show("Error por favor ingrese un dato valido ");
                return;
            }

            insertar.Pnombre1 = TxtPnombre.Text;

            if (TxtSegundonombre.Text == "Segundo Nombre")
            {
                insertar.Snombre1 = " ";
            }
            else
            {
                insertar.Snombre1 = TxtSegundonombre.Text;
            }

            if (TxtTercerNombre.Text == "Tercer Nombre")
            {
                insertar.Tnombre1 = " ";
            }
            else
            {
                insertar.Tnombre1 = TxtTercerNombre.Text;
            }

            insertar.Papellido1 = TxtApellido.Text;

            if (TxtSegundoApellido.Text == "Segundo Apellido")
            {
                insertar.Sapelldio1 = " ";
            }
            else
            {
                insertar.Sapelldio1 = TxtSegundoApellido.Text;
            }

            if (TxtApllidoCasada.Text == "Apellido de casada")
            {
                insertar.CasaApellido1 = " ";
            }
            else
            {
                insertar.CasaApellido1 = TxtApllidoCasada.Text;
            }

            insertar.Cui1 = Convert.ToInt32(TxtCui.Text);
            insertar.Fecha1 = TxtFecha.Text;

            if (TxtPaiz.Text == "País")
            {
                insertar.Pais1 = " ";
            }
            else
            {
                insertar.Pais1 = TxtPaiz.Text;
            }

            if (TxtEstado.Text == "Estado")
            {
                insertar.Estado1 = " ";
            }
            else
            {
                insertar.Estado1 = TxtEstado.Text;
            }

            if (TxtCiudad.Text == "Ciudad")
            {
                insertar.Ciudad1 = " ";
            }
            else
            {
                insertar.Ciudad1 = TxtCiudad.Text;
            }

            insertar.Correo1 = TxtCorreo.Text;

            int estado = Funciones.insertarDatos(insertar);

            if (estado > 0)
            {
                rellenar();
                MessageBox.Show("Datos Guardado","Exito");
            }
            else
            {
                MessageBox.Show("NO se guardaron los datos","ERROR");
            }


        }
    }
}
