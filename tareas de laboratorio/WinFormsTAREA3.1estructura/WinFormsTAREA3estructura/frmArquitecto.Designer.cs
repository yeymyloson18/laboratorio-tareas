namespace WinFormsTAREA3estructura
{
    partial class frmArquitecto
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblNombres = new Label();
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            cboCondicion = new ComboBox();
            lblCondicionContrato = new Label();
            lblEspecialidad = new Label();
            cboEspecialidad = new ComboBox();
            lblTipoActividad = new Label();
            cboActividad = new ComboBox();
            lblTipoAfiliado = new Label();
            cboAfiliado = new ComboBox();
            txtResultado = new TextBox();
            btnCrear = new Button();
            btnLimpiar = new Button();
            btnSalir = new Button();
            btoMostrar = new Button();
            SuspendLayout();
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(60, 9);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(70, 20);
            lblNombres.TabIndex = 0;
            lblNombres.Text = "Nombres";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(35, 32);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(35, 106);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 3;
            txtCodigo.TextChanged += txtCódigo_TextChanged;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(60, 73);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(58, 20);
            lblCodigo.TabIndex = 2;
            lblCodigo.Text = "Código";
            lblCodigo.Click += lblCódigo_Click;
            // 
            // cboCondicion
            // 
            cboCondicion.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCondicion.FormattingEnabled = true;
            cboCondicion.Items.AddRange(new object[] { "Estable", "Contratado" });
            cboCondicion.Location = new Point(291, 32);
            cboCondicion.Name = "cboCondicion";
            cboCondicion.Size = new Size(151, 28);
            cboCondicion.TabIndex = 4;
            cboCondicion.SelectedIndexChanged += cboCondicion_SelectedIndexChanged;
            // 
            // lblCondicionContrato
            // 
            lblCondicionContrato.AutoSize = true;
            lblCondicionContrato.Location = new Point(291, 9);
            lblCondicionContrato.Name = "lblCondicionContrato";
            lblCondicionContrato.Size = new Size(159, 20);
            lblCondicionContrato.TabIndex = 5;
            lblCondicionContrato.Text = "Condición de Contrato";
            lblCondicionContrato.Click += lblCondicionContrato_Click;
            // 
            // lblEspecialidad
            // 
            lblEspecialidad.AutoSize = true;
            lblEspecialidad.Location = new Point(571, 9);
            lblEspecialidad.Name = "lblEspecialidad";
            lblEspecialidad.Size = new Size(93, 20);
            lblEspecialidad.TabIndex = 7;
            lblEspecialidad.Text = "Especialidad";
            // 
            // cboEspecialidad
            // 
            cboEspecialidad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboEspecialidad.FormattingEnabled = true;
            cboEspecialidad.Items.AddRange(new object[] { "Estructuras", "Recursos Hídricos" });
            cboEspecialidad.Location = new Point(547, 32);
            cboEspecialidad.Name = "cboEspecialidad";
            cboEspecialidad.Size = new Size(151, 28);
            cboEspecialidad.TabIndex = 6;
            cboEspecialidad.SelectedIndexChanged += cboEspecialidad_SelectedIndexChanged;
            // 
            // lblTipoActividad
            // 
            lblTipoActividad.AutoSize = true;
            lblTipoActividad.Location = new Point(299, 74);
            lblTipoActividad.Name = "lblTipoActividad";
            lblTipoActividad.Size = new Size(127, 20);
            lblTipoActividad.TabIndex = 9;
            lblTipoActividad.Text = "Tipo de Actividad";
            // 
            // cboActividad
            // 
            cboActividad.DropDownStyle = ComboBoxStyle.DropDownList;
            cboActividad.FormattingEnabled = true;
            cboActividad.Items.AddRange(new object[] { "Supervición de Obras", "Supervición de Vias" });
            cboActividad.Location = new Point(299, 109);
            cboActividad.Name = "cboActividad";
            cboActividad.Size = new Size(151, 28);
            cboActividad.TabIndex = 8;
            // 
            // lblTipoAfiliado
            // 
            lblTipoAfiliado.AutoSize = true;
            lblTipoAfiliado.Location = new Point(562, 73);
            lblTipoAfiliado.Name = "lblTipoAfiliado";
            lblTipoAfiliado.Size = new Size(100, 20);
            lblTipoAfiliado.TabIndex = 11;
            lblTipoAfiliado.Text = "Tipo  Afiliado";
            lblTipoAfiliado.Click += lblTipoAfiliacion_Click;
            // 
            // cboAfiliado
            // 
            cboAfiliado.DropDownStyle = ComboBoxStyle.DropDownList;
            cboAfiliado.FormattingEnabled = true;
            cboAfiliado.Items.AddRange(new object[] { "AFP", "SNP" });
            cboAfiliado.Location = new Point(562, 106);
            cboAfiliado.Name = "cboAfiliado";
            cboAfiliado.Size = new Size(151, 28);
            cboAfiliado.TabIndex = 10;
            cboAfiliado.SelectedIndexChanged += cboAfiliado_SelectedIndexChanged;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(60, 143);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(678, 244);
            txtResultado.TabIndex = 12;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(24, 393);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(136, 29);
            btnCrear.TabIndex = 13;
            btnCrear.Text = "Crear Objeto";
            btnCrear.UseVisualStyleBackColor = true;
            btnCrear.Click += btnCrear_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(452, 393);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(136, 29);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(621, 393);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(136, 29);
            btnSalir.TabIndex = 16;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btoMostrar
            // 
            btoMostrar.Location = new Point(223, 393);
            btoMostrar.Name = "btoMostrar";
            btoMostrar.Size = new Size(159, 29);
            btoMostrar.TabIndex = 17;
            btoMostrar.Text = "Mostrar Información";
            btoMostrar.UseVisualStyleBackColor = true;
            btoMostrar.Click += btoMostrar_Click;
            // 
            // frmArquitecto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btoMostrar);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCrear);
            Controls.Add(txtResultado);
            Controls.Add(lblTipoAfiliado);
            Controls.Add(cboAfiliado);
            Controls.Add(lblTipoActividad);
            Controls.Add(cboActividad);
            Controls.Add(lblEspecialidad);
            Controls.Add(cboEspecialidad);
            Controls.Add(lblCondicionContrato);
            Controls.Add(cboCondicion);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(txtNombre);
            Controls.Add(lblNombres);
            Name = "frmArquitecto";
            Text = "Arquitectos.sac";
            Load += frmArquitecto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombres;
        private TextBox txtNombre;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private Label label1;
        private ComboBox cboCondicion;
        private Label lblCondicionContrato;
        private Label lblEspecialidad;
        private ComboBox cboEspecialidad;
        private Label lblTipoActividad;
        private ComboBox cboActividad;
        private Label lblTipoAfiliado;
        private ComboBox cboAfiliado;
        private TextBox txtResultado;
        private Button btnCrear;
        private Button btnLimpiar;
        private Button btnSalir;
        private Button btoMostrar;
    }
}
