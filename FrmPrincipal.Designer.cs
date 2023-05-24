namespace Empadronamiento
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlMenu = new System.Windows.Forms.Panel();
            this.BtnConsulta = new FontAwesome.Sharp.IconButton();
            this.BtnRegistro = new FontAwesome.Sharp.IconButton();
            this.BtnMinimizar = new FontAwesome.Sharp.IconButton();
            this.BtnMaximizar = new FontAwesome.Sharp.IconButton();
            this.BtnCerrar = new FontAwesome.Sharp.IconButton();
            this.PnlPrincipal = new System.Windows.Forms.Panel();
            this.PnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMenu
            // 
            this.PnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(152)))));
            this.PnlMenu.Controls.Add(this.BtnConsulta);
            this.PnlMenu.Controls.Add(this.BtnRegistro);
            this.PnlMenu.Controls.Add(this.BtnMinimizar);
            this.PnlMenu.Controls.Add(this.BtnMaximizar);
            this.PnlMenu.Controls.Add(this.BtnCerrar);
            this.PnlMenu.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.PnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlMenu.Location = new System.Drawing.Point(0, 0);
            this.PnlMenu.Name = "PnlMenu";
            this.PnlMenu.Size = new System.Drawing.Size(800, 42);
            this.PnlMenu.TabIndex = 0;
            this.PnlMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FrmPrincipal_MouseDown_1);
            // 
            // BtnConsulta
            // 
            this.BtnConsulta.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnConsulta.FlatAppearance.BorderSize = 0;
            this.BtnConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConsulta.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConsulta.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.BtnConsulta.IconColor = System.Drawing.Color.Black;
            this.BtnConsulta.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnConsulta.IconSize = 36;
            this.BtnConsulta.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnConsulta.Location = new System.Drawing.Point(120, 0);
            this.BtnConsulta.Name = "BtnConsulta";
            this.BtnConsulta.Size = new System.Drawing.Size(120, 42);
            this.BtnConsulta.TabIndex = 4;
            this.BtnConsulta.Text = "Consulta";
            this.BtnConsulta.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnConsulta.UseVisualStyleBackColor = true;
            this.BtnConsulta.Click += new System.EventHandler(this.BtnConsulta_Click);
            // 
            // BtnRegistro
            // 
            this.BtnRegistro.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnRegistro.FlatAppearance.BorderSize = 0;
            this.BtnRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRegistro.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRegistro.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.BtnRegistro.IconColor = System.Drawing.Color.Black;
            this.BtnRegistro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnRegistro.IconSize = 36;
            this.BtnRegistro.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.BtnRegistro.Location = new System.Drawing.Point(0, 0);
            this.BtnRegistro.Name = "BtnRegistro";
            this.BtnRegistro.Size = new System.Drawing.Size(120, 42);
            this.BtnRegistro.TabIndex = 3;
            this.BtnRegistro.Text = "Registro";
            this.BtnRegistro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnRegistro.UseVisualStyleBackColor = true;
            this.BtnRegistro.Click += new System.EventHandler(this.BtnRegistro_Click);
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BtnMinimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMinimizar.FlatAppearance.BorderSize = 0;
            this.BtnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimizar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMinimizar.IconChar = FontAwesome.Sharp.IconChar.Minus;
            this.BtnMinimizar.IconColor = System.Drawing.Color.Black;
            this.BtnMinimizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMinimizar.IconSize = 30;
            this.BtnMinimizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMinimizar.Location = new System.Drawing.Point(674, 0);
            this.BtnMinimizar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(42, 42);
            this.BtnMinimizar.TabIndex = 2;
            this.BtnMinimizar.UseVisualStyleBackColor = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // BtnMaximizar
            // 
            this.BtnMaximizar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BtnMaximizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMaximizar.FlatAppearance.BorderSize = 0;
            this.BtnMaximizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMaximizar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMaximizar.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.BtnMaximizar.IconColor = System.Drawing.Color.Black;
            this.BtnMaximizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMaximizar.IconSize = 30;
            this.BtnMaximizar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMaximizar.Location = new System.Drawing.Point(716, 0);
            this.BtnMaximizar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnMaximizar.Name = "BtnMaximizar";
            this.BtnMaximizar.Size = new System.Drawing.Size(42, 42);
            this.BtnMaximizar.TabIndex = 1;
            this.BtnMaximizar.UseVisualStyleBackColor = false;
            this.BtnMaximizar.Click += new System.EventHandler(this.btnMaximizar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.BtnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.ForeColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.BtnCerrar.IconColor = System.Drawing.Color.Black;
            this.BtnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnCerrar.IconSize = 30;
            this.BtnCerrar.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnCerrar.Location = new System.Drawing.Point(758, 0);
            this.BtnCerrar.Margin = new System.Windows.Forms.Padding(0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(42, 42);
            this.BtnCerrar.TabIndex = 0;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // PnlPrincipal
            // 
            this.PnlPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlPrincipal.Location = new System.Drawing.Point(0, 42);
            this.PnlPrincipal.Name = "PnlPrincipal";
            this.PnlPrincipal.Size = new System.Drawing.Size(800, 408);
            this.PnlPrincipal.TabIndex = 1;
            this.PnlPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlPrincipal_Paint);
            this.PnlPrincipal.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PnlPrincipal_Paint_MouseDown);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PnlPrincipal);
            this.Controls.Add(this.PnlMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "36";
            this.PnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMenu;
        private FontAwesome.Sharp.IconButton BtnCerrar;
        private FontAwesome.Sharp.IconButton BtnMinimizar;
        private FontAwesome.Sharp.IconButton BtnMaximizar;
        private FontAwesome.Sharp.IconButton BtnConsulta;
        private FontAwesome.Sharp.IconButton BtnRegistro;
        private System.Windows.Forms.Panel PnlPrincipal;
    }
}

