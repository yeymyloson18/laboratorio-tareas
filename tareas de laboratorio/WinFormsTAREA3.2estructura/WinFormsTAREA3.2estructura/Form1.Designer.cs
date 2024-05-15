namespace WinFormsTAREA3._2estructura
{
    partial class frmJefesito
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
            txtNombres = new TextBox();
            txtDni = new TextBox();
            lblDni = new Label();
            txtAntigüedad = new TextBox();
            lblAntigüo = new Label();
            cboCargo = new ComboBox();
            lblCargo = new Label();
            lblArea = new Label();
            cboArea = new ComboBox();
            txtResultado = new TextBox();
            tbnCrear = new Button();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnMostrar = new Button();
            SuspendLayout();
            // 
            // lblNombres
            // 
            lblNombres.AutoSize = true;
            lblNombres.Location = new Point(67, 16);
            lblNombres.Name = "lblNombres";
            lblNombres.Size = new Size(70, 20);
            lblNombres.TabIndex = 0;
            lblNombres.Text = "Nombres";
            lblNombres.Click += label1_Click;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(45, 39);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(125, 27);
            txtNombres.TabIndex = 1;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(45, 92);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(125, 27);
            txtDni.TabIndex = 3;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(77, 69);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(35, 20);
            lblDni.TabIndex = 2;
            lblDni.Text = "DNI";
            // 
            // txtAntigüedad
            // 
            txtAntigüedad.Location = new Point(273, 52);
            txtAntigüedad.Name = "txtAntigüedad";
            txtAntigüedad.Size = new Size(125, 27);
            txtAntigüedad.TabIndex = 5;
            // 
            // lblAntigüo
            // 
            lblAntigüo.AutoSize = true;
            lblAntigüo.Location = new Point(273, 19);
            lblAntigüo.Name = "lblAntigüo";
            lblAntigüo.Size = new Size(145, 20);
            lblAntigüo.TabIndex = 4;
            lblAntigüo.Text = "Años de Antigüedad";
            lblAntigüo.Click += lblAntigüo_Click;
            // 
            // cboCargo
            // 
            cboCargo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboCargo.FormattingEnabled = true;
            cboCargo.Items.AddRange(new object[] { "Gerente", "Subgerente" });
            cboCargo.Location = new Point(513, 38);
            cboCargo.Name = "cboCargo";
            cboCargo.Size = new Size(151, 28);
            cboCargo.TabIndex = 6;
            // 
            // lblCargo
            // 
            lblCargo.AutoSize = true;
            lblCargo.Location = new Point(556, 16);
            lblCargo.Name = "lblCargo";
            lblCargo.Size = new Size(49, 20);
            lblCargo.TabIndex = 7;
            lblCargo.Text = "Cargo";
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(556, 69);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(40, 20);
            lblArea.TabIndex = 9;
            lblArea.Text = "Area";
            // 
            // cboArea
            // 
            cboArea.DropDownStyle = ComboBoxStyle.DropDownList;
            cboArea.FormattingEnabled = true;
            cboArea.Items.AddRange(new object[] { "Contabilidad", "Planificación" });
            cboArea.Location = new Point(513, 92);
            cboArea.Name = "cboArea";
            cboArea.Size = new Size(151, 28);
            cboArea.TabIndex = 8;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(56, 126);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(673, 248);
            txtResultado.TabIndex = 10;
            // 
            // tbnCrear
            // 
            tbnCrear.Location = new Point(45, 409);
            tbnCrear.Name = "tbnCrear";
            tbnCrear.Size = new Size(144, 29);
            tbnCrear.TabIndex = 11;
            tbnCrear.Text = "Crear Objeto";
            tbnCrear.UseVisualStyleBackColor = true;
            tbnCrear.Click += tbnCrear_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(606, 409);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(479, 409);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(210, 409);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(208, 29);
            btnMostrar.TabIndex = 14;
            btnMostrar.Text = "Mostrar Información";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // frmJefesito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMostrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalir);
            Controls.Add(tbnCrear);
            Controls.Add(txtResultado);
            Controls.Add(lblArea);
            Controls.Add(cboArea);
            Controls.Add(lblCargo);
            Controls.Add(cboCargo);
            Controls.Add(txtAntigüedad);
            Controls.Add(lblAntigüo);
            Controls.Add(txtDni);
            Controls.Add(lblDni);
            Controls.Add(txtNombres);
            Controls.Add(lblNombres);
            Name = "frmJefesito";
            Text = "Jefesito";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombres;
        private TextBox txtNombres;
        private TextBox txtDni;
        private Label lblDni;
        private TextBox txtAntigüedad;
        private Label lblAntigüo;
        private ComboBox cboCargo;
        private Label lblCargo;
        private Label lblArea;
        private ComboBox cboArea;
        private TextBox txtResultado;
        private Button tbnCrear;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnMostrar;
    }
}
