namespace WinFormsTarea4._1estructura
{
    partial class Form1
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
            lblNumeros = new Label();
            txtNumeros = new TextBox();
            textBox1 = new TextBox();
            btnCrear = new Button();
            btnSalir = new Button();
            btnLimpiar = new Button();
            btnMostrar = new Button();
            SuspendLayout();
            // 
            // lblNumeros
            // 
            lblNumeros.AutoSize = true;
            lblNumeros.Location = new Point(269, 71);
            lblNumeros.Name = "lblNumeros";
            lblNumeros.Size = new Size(121, 20);
            lblNumeros.TabIndex = 0;
            lblNumeros.Text = "Ingrese Numeros";
            lblNumeros.Click += label1_Click;
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(263, 98);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(125, 27);
            txtNumeros.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            textBox1.Location = new Point(81, 150);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(540, 145);
            textBox1.TabIndex = 2;
            // 
            // btnCrear
            // 
            btnCrear.Location = new Point(43, 385);
            btnCrear.Name = "btnCrear";
            btnCrear.Size = new Size(122, 29);
            btnCrear.TabIndex = 3;
            btnCrear.Text = "Crear Objeto";
            btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(589, 385);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(122, 29);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button1_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(417, 385);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(122, 29);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnMostrar
            // 
            btnMostrar.Location = new Point(211, 385);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(177, 29);
            btnMostrar.TabIndex = 6;
            btnMostrar.Text = "Mostrar Información";
            btnMostrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMostrar);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalir);
            Controls.Add(btnCrear);
            Controls.Add(textBox1);
            Controls.Add(txtNumeros);
            Controls.Add(lblNumeros);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumeros;
        private TextBox txtNumeros;
        private TextBox textBox1;
        private Button btnCrear;
        private Button btnSalir;
        private Button btnLimpiar;
        private Button btnMostrar;
    }
}
