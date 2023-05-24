using Empadronamiento.Consulta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Librearia para mover el login

namespace Empadronamiento
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        //*********Permite mover FrmPrincipal con mause
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        // ************************************************

        //mover ventana desde el frmPrincipal 
        private void FrmPrincipal_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Mover ventana desde el PnlPrincipal
        private void PnlPrincipal_Paint_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        
        //Mover ventana FrmRegistro
        private void FrmRegistro_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //---------------------------------------------------------------------------
        //Boton para cerrar 
        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();//Cerrar formulario principal 
        }
        //Boton para maximizar
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            //Maximizar el frmPrincipal si en dado caso esta en tamño normal y viseverza 
            // Obtener el monitor actual
            Screen monitorActual = Screen.FromPoint(this.Location);

            // Establecer el tamaño máximo de la ventana al tamaño del monitor actual menos la barra de tareas
            this.MaximumSize = new Size(monitorActual.WorkingArea.Width, monitorActual.WorkingArea.Height);

            if (WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.WindowState = FormWindowState.Normal;
            }
        }
        //Boton para minimizar
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private bool estadoFrm = false; //Nos permite guardar el estado del frm
        private bool estadoFrmC = false;
        private FrmRegistro frm; //Se crea la variable para despues instanciar el frm 
        private FrmConsulta frmC;

        //Boton de registro
        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            if (!estadoFrm)
            {
                //Cerrar formulario de consulta                
                if (estadoFrmC)
                {
                    frmC.Hide();
                    estadoFrmC = false;
                }
                frm = new FrmRegistro(); //Instanciamos el formulario
                frm.TopLevel = false;
                PnlPrincipal.Controls.Add(frm);                
                frm.Show();
                estadoFrm = true;
            }
            else
            {                
                frm.Hide();
                frmC.Hide();
                estadoFrm = false;                
            }            
        }
        //Boton de consulta
        private void BtnConsulta_Click(object sender, EventArgs e)
        {
            if (!estadoFrmC)
            {
                //Cerrar formulario                 
                if (estadoFrm)
                {
                    frm.Hide();
                    estadoFrm = false;
                }
                //Abrimos formulario 
                frmC = new FrmConsulta();                
                frmC.TopLevel = false;
                PnlPrincipal.Controls.Add(frmC);
                frmC.Show();
                estadoFrmC = true;                                
            }
            else
            {
                //Cerramos los formularios en caso esten abiertos
                frmC.Hide();
                frm.Hide();
                estadoFrmC = false;
            }
        }

        private void PnlPrincipal_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
