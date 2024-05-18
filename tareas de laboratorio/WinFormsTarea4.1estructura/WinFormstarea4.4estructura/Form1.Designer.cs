





namespace WinFormsInterseccionNumeros
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblNumbers1 = new Label();
            txtPrimerC = new TextBox();
            lblNumbers2 = new Label();
            txtSegundoC = new TextBox();
            btnCalculate = new Button();
            Resultado = new ListBox();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblNumbers1
            // 
            lblNumbers1.AutoSize = true;
            lblNumbers1.Location = new Point(113, 9);
            lblNumbers1.Name = "lblNumbers1";
            lblNumbers1.Size = new Size(186, 20);
            lblNumbers1.TabIndex = 0;
            lblNumbers1.Text = "Ingrese el primer conjunto:";
            lblNumbers1.Click += lblNumbers1_Click;
            // 
            // txtPrimerC
            // 
            txtPrimerC.Location = new Point(32, 48);
            txtPrimerC.Multiline = true;
            txtPrimerC.Name = "txtPrimerC";
            txtPrimerC.Size = new Size(368, 79);
            txtPrimerC.TabIndex = 1;
            // 
            // lblNumbers2
            // 
            lblNumbers2.AutoSize = true;
            lblNumbers2.Location = new Point(100, 134);
            lblNumbers2.Name = "lblNumbers2";
            lblNumbers2.Size = new Size(199, 20);
            lblNumbers2.TabIndex = 2;
            lblNumbers2.Text = "Ingrese el segundo conjunto:";
            // 
            // txtSegundoC
            // 
            txtSegundoC.Location = new Point(32, 157);
            txtSegundoC.Multiline = true;
            txtSegundoC.Name = "txtSegundoC";
            txtSegundoC.Size = new Size(368, 67);
            txtSegundoC.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(135, 240);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(80, 31);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Resultado
            // 
            Resultado.FormattingEnabled = true;
            Resultado.Location = new Point(43, 294);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(256, 144);
            Resultado.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(320, 307);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(320, 377);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button2_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(435, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(Resultado);
            Controls.Add(btnCalculate);
            Controls.Add(txtSegundoC);
            Controls.Add(lblNumbers2);
            Controls.Add(txtPrimerC);
            Controls.Add(lblNumbers1);
            Name = "Form1";
            Text = "Intersección de Conjuntos";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblNumbers1;
        private System.Windows.Forms.TextBox txtPrimerC;
        private System.Windows.Forms.Label lblNumbers2;
        private System.Windows.Forms.TextBox txtSegundoC;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox Resultado;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}