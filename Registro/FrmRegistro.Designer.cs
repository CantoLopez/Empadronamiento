namespace Empadronamiento
{
    partial class FrmRegistro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnGuardado = new System.Windows.Forms.Button();
            this.LblLinea = new System.Windows.Forms.Label();
            this.TxtPnombre = new System.Windows.Forms.TextBox();
            this.TxtSegundonombre = new System.Windows.Forms.TextBox();
            this.TxtApellido = new System.Windows.Forms.TextBox();
            this.TxtTercerNombre = new System.Windows.Forms.TextBox();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.TxtCui = new System.Windows.Forms.TextBox();
            this.TxtApllidoCasada = new System.Windows.Forms.TextBox();
            this.TxtSegundoApellido = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.TxtCiudad = new System.Windows.Forms.TextBox();
            this.TxtEstado = new System.Windows.Forms.TextBox();
            this.TxtPaiz = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnGuardado
            // 
            this.BtnGuardado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnGuardado.Location = new System.Drawing.Point(348, 319);
            this.BtnGuardado.Name = "BtnGuardado";
            this.BtnGuardado.Size = new System.Drawing.Size(105, 44);
            this.BtnGuardado.TabIndex = 0;
            this.BtnGuardado.Text = "Guardar";
            this.BtnGuardado.UseVisualStyleBackColor = true;
            this.BtnGuardado.Click += new System.EventHandler(this.BtnGuardado_Click);
            // 
            // LblLinea
            // 
            this.LblLinea.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblLinea.AutoSize = true;
            this.LblLinea.BackColor = System.Drawing.Color.Transparent;
            this.LblLinea.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLinea.Location = new System.Drawing.Point(323, 30);
            this.LblLinea.Name = "LblLinea";
            this.LblLinea.Size = new System.Drawing.Size(151, 21);
            this.LblLinea.TabIndex = 2;
            this.LblLinea.Text = "Ingrese sus datos ";
            // 
            // TxtPnombre
            // 
            this.TxtPnombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(187)))), ((int)(((byte)(232)))));
            this.TxtPnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPnombre.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPnombre.ForeColor = System.Drawing.Color.LightGray;
            this.TxtPnombre.Location = new System.Drawing.Point(62, 92);
            this.TxtPnombre.Name = "TxtPnombre";
            this.TxtPnombre.Size = new System.Drawing.Size(146, 21);
            this.TxtPnombre.TabIndex = 1;
            this.TxtPnombre.Text = "* Primer Nombre";
            this.TxtPnombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPnombre.Enter += new System.EventHandler(this.TxtPnombre_Enter);
            this.TxtPnombre.Leave += new System.EventHandler(this.TxtPnombre_Leave);
            // 
            // TxtSegundonombre
            // 
            this.TxtSegundonombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSegundonombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(187)))), ((int)(((byte)(232)))));
            this.TxtSegundonombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSegundonombre.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSegundonombre.ForeColor = System.Drawing.Color.LightGray;
            this.TxtSegundonombre.Location = new System.Drawing.Point(234, 92);
            this.TxtSegundonombre.Name = "TxtSegundonombre";
            this.TxtSegundonombre.Size = new System.Drawing.Size(146, 21);
            this.TxtSegundonombre.TabIndex = 3;
            this.TxtSegundonombre.Text = "Segundo Nombre";
            this.TxtSegundonombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSegundonombre.Enter += new System.EventHandler(this.TxtSegundonombre_Enter);
            this.TxtSegundonombre.Leave += new System.EventHandler(this.TxtSegundonombre_Leave);
            // 
            // TxtApellido
            // 
            this.TxtApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(187)))), ((int)(((byte)(232)))));
            this.TxtApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApellido.ForeColor = System.Drawing.Color.LightGray;
            this.TxtApellido.Location = new System.Drawing.Point(579, 89);
            this.TxtApellido.Name = "TxtApellido";
            this.TxtApellido.Size = new System.Drawing.Size(146, 21);
            this.TxtApellido.TabIndex = 5;
            this.TxtApellido.Text = "* Primer Apellido";
            this.TxtApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtApellido.Enter += new System.EventHandler(this.TxtApellido_Enter);
            this.TxtApellido.Leave += new System.EventHandler(this.TxtApellido_Leave);
            // 
            // TxtTercerNombre
            // 
            this.TxtTercerNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtTercerNombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(187)))), ((int)(((byte)(232)))));
            this.TxtTercerNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtTercerNombre.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTercerNombre.ForeColor = System.Drawing.Color.LightGray;
            this.TxtTercerNombre.Location = new System.Drawing.Point(407, 92);
            this.TxtTercerNombre.Name = "TxtTercerNombre";
            this.TxtTercerNombre.Size = new System.Drawing.Size(146, 21);
            this.TxtTercerNombre.TabIndex = 4;
            this.TxtTercerNombre.Text = "Tercer Nombre";
            this.TxtTercerNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtTercerNombre.Enter += new System.EventHandler(this.TxtTercerNombre_Enter);
            this.TxtTercerNombre.Leave += new System.EventHandler(this.TxtTercerNombre_Leave);
            // 
            // TxtFecha
            // 
            this.TxtFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtFecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(187)))), ((int)(((byte)(232)))));
            this.TxtFecha.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtFecha.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFecha.ForeColor = System.Drawing.Color.LightGray;
            this.TxtFecha.Location = new System.Drawing.Point(566, 151);
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.Size = new System.Drawing.Size(173, 21);
            this.TxtFecha.TabIndex = 9;
            this.TxtFecha.Text = "* Fecha de nacimiento";
            this.TxtFecha.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtFecha.Enter += new System.EventHandler(this.TxtFecha_Enter);
            this.TxtFecha.Leave += new System.EventHandler(this.TxtFecha_Leave);
            // 
            // TxtCui
            // 
            this.TxtCui.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(187)))), ((int)(((byte)(232)))));
            this.TxtCui.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCui.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCui.ForeColor = System.Drawing.Color.LightGray;
            this.TxtCui.Location = new System.Drawing.Point(395, 151);
            this.TxtCui.Name = "TxtCui";
            this.TxtCui.Size = new System.Drawing.Size(167, 21);
            this.TxtCui.TabIndex = 8;
            this.TxtCui.Text = "* Ingrese su CUI - DPI";
            this.TxtCui.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCui.Enter += new System.EventHandler(this.TxtDiseño_Enter);
            this.TxtCui.Leave += new System.EventHandler(this.TxtDiseño_Leave);
            // 
            // TxtApllidoCasada
            // 
            this.TxtApllidoCasada.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtApllidoCasada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(187)))), ((int)(((byte)(232)))));
            this.TxtApllidoCasada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtApllidoCasada.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtApllidoCasada.ForeColor = System.Drawing.Color.LightGray;
            this.TxtApllidoCasada.Location = new System.Drawing.Point(234, 151);
            this.TxtApllidoCasada.Name = "TxtApllidoCasada";
            this.TxtApllidoCasada.Size = new System.Drawing.Size(146, 21);
            this.TxtApllidoCasada.TabIndex = 7;
            this.TxtApllidoCasada.Text = "Apellido de casada";
            this.TxtApllidoCasada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtApllidoCasada.Enter += new System.EventHandler(this.TxtApllidoCasada_Enter);
            this.TxtApllidoCasada.Leave += new System.EventHandler(this.TxtApllidoCasada_Leave);
            // 
            // TxtSegundoApellido
            // 
            this.TxtSegundoApellido.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtSegundoApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(187)))), ((int)(((byte)(232)))));
            this.TxtSegundoApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSegundoApellido.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSegundoApellido.ForeColor = System.Drawing.Color.LightGray;
            this.TxtSegundoApellido.Location = new System.Drawing.Point(64, 151);
            this.TxtSegundoApellido.Name = "TxtSegundoApellido";
            this.TxtSegundoApellido.Size = new System.Drawing.Size(146, 21);
            this.TxtSegundoApellido.TabIndex = 6;
            this.TxtSegundoApellido.Text = "Segundo Apellido";
            this.TxtSegundoApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtSegundoApellido.Enter += new System.EventHandler(this.TxtSegundoApellido_Enter);
            this.TxtSegundoApellido.Leave += new System.EventHandler(this.TxtSegundoApellido_Leave);
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCorreo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(187)))), ((int)(((byte)(232)))));
            this.TxtCorreo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCorreo.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCorreo.ForeColor = System.Drawing.Color.LightGray;
            this.TxtCorreo.Location = new System.Drawing.Point(566, 210);
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(176, 21);
            this.TxtCorreo.TabIndex = 13;
            this.TxtCorreo.Text = "* Correo Electronico";
            this.TxtCorreo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCorreo.Enter += new System.EventHandler(this.TxtCorreo_Enter);
            this.TxtCorreo.Leave += new System.EventHandler(this.TxtCorreo_Leave);
            // 
            // TxtCiudad
            // 
            this.TxtCiudad.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtCiudad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(187)))), ((int)(((byte)(232)))));
            this.TxtCiudad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCiudad.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCiudad.ForeColor = System.Drawing.Color.LightGray;
            this.TxtCiudad.Location = new System.Drawing.Point(407, 210);
            this.TxtCiudad.Name = "TxtCiudad";
            this.TxtCiudad.Size = new System.Drawing.Size(146, 21);
            this.TxtCiudad.TabIndex = 12;
            this.TxtCiudad.Text = "Ciudad";
            this.TxtCiudad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtCiudad.Enter += new System.EventHandler(this.TxtCiudad_Enter);
            this.TxtCiudad.Leave += new System.EventHandler(this.TxtCiudad_Leave);
            // 
            // TxtEstado
            // 
            this.TxtEstado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(187)))), ((int)(((byte)(232)))));
            this.TxtEstado.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtEstado.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtEstado.ForeColor = System.Drawing.Color.LightGray;
            this.TxtEstado.Location = new System.Drawing.Point(234, 210);
            this.TxtEstado.Name = "TxtEstado";
            this.TxtEstado.Size = new System.Drawing.Size(146, 21);
            this.TxtEstado.TabIndex = 11;
            this.TxtEstado.Text = "Estado";
            this.TxtEstado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtEstado.Enter += new System.EventHandler(this.TxtEstado_Enter);
            this.TxtEstado.Leave += new System.EventHandler(this.TxtEstado_Leave);
            // 
            // TxtPaiz
            // 
            this.TxtPaiz.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtPaiz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(187)))), ((int)(((byte)(232)))));
            this.TxtPaiz.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPaiz.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPaiz.ForeColor = System.Drawing.Color.LightGray;
            this.TxtPaiz.Location = new System.Drawing.Point(62, 210);
            this.TxtPaiz.Name = "TxtPaiz";
            this.TxtPaiz.Size = new System.Drawing.Size(146, 21);
            this.TxtPaiz.TabIndex = 10;
            this.TxtPaiz.Text = "País";
            this.TxtPaiz.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TxtPaiz.Enter += new System.EventHandler(this.TxtPaiz_Enter);
            this.TxtPaiz.Leave += new System.EventHandler(this.TxtPaiz_Leave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(284, 278);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 17);
            this.label1.TabIndex = 14;
            this.label1.Text = "*Verifique sus datos antes de guardar";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGray;
            this.label2.Location = new System.Drawing.Point(74, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "________________________";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGray;
            this.label3.Location = new System.Drawing.Point(242, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "__________________________";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightGray;
            this.label6.Location = new System.Drawing.Point(417, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 17);
            this.label6.TabIndex = 19;
            this.label6.Text = "________________________";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightGray;
            this.label7.Location = new System.Drawing.Point(585, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(138, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "__________________________";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGray;
            this.label4.Location = new System.Drawing.Point(74, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "________________________";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGray;
            this.label5.Location = new System.Drawing.Point(242, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "__________________________";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightGray;
            this.label8.Location = new System.Drawing.Point(417, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "________________________";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LightGray;
            this.label9.Location = new System.Drawing.Point(579, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(163, 17);
            this.label9.TabIndex = 24;
            this.label9.Text = "_______________________________";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.LightGray;
            this.label10.Location = new System.Drawing.Point(74, 216);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(128, 17);
            this.label10.TabIndex = 25;
            this.label10.Text = "________________________";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.LightGray;
            this.label11.Location = new System.Drawing.Point(242, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(138, 17);
            this.label11.TabIndex = 26;
            this.label11.Text = "__________________________";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.LightGray;
            this.label12.Location = new System.Drawing.Point(417, 216);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(128, 17);
            this.label12.TabIndex = 27;
            this.label12.Text = "________________________";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.LightGray;
            this.label13.Location = new System.Drawing.Point(566, 216);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(183, 17);
            this.label13.TabIndex = 28;
            this.label13.Text = "___________________________________";
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(615, 131);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(81, 17);
            this.label14.TabIndex = 29;
            this.label14.Text = "año/mes/dia";
            // 
            // FrmRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(187)))), ((int)(((byte)(232)))));
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.TxtCiudad);
            this.Controls.Add(this.TxtEstado);
            this.Controls.Add(this.TxtPaiz);
            this.Controls.Add(this.TxtFecha);
            this.Controls.Add(this.TxtCui);
            this.Controls.Add(this.TxtApllidoCasada);
            this.Controls.Add(this.TxtSegundoApellido);
            this.Controls.Add(this.TxtApellido);
            this.Controls.Add(this.TxtTercerNombre);
            this.Controls.Add(this.TxtSegundonombre);
            this.Controls.Add(this.TxtPnombre);
            this.Controls.Add(this.BtnGuardado);
            this.Controls.Add(this.LblLinea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedro adolfo ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardado;
        private System.Windows.Forms.Label LblLinea;
        private System.Windows.Forms.TextBox TxtPnombre;
        private System.Windows.Forms.TextBox TxtSegundonombre;
        private System.Windows.Forms.TextBox TxtApellido;
        private System.Windows.Forms.TextBox TxtTercerNombre;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.TextBox TxtCui;
        private System.Windows.Forms.TextBox TxtApllidoCasada;
        private System.Windows.Forms.TextBox TxtSegundoApellido;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.TextBox TxtCiudad;
        private System.Windows.Forms.TextBox TxtEstado;
        private System.Windows.Forms.TextBox TxtPaiz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
    }
}