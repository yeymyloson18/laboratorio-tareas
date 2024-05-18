




namespace WinFormsDiferenciaConjuntos
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
            lblNumbers1.Location = new Point(37, 13);
            lblNumbers1.Name = "lblNumbers1";
            lblNumbers1.Size = new Size(186, 20);
            lblNumbers1.TabIndex = 0;
            lblNumbers1.Text = "Ingrese el primer conjunto:";
            // 
            // txtPrimerC
            // 
            txtPrimerC.Location = new Point(16, 36);
            txtPrimerC.Multiline = true;
            txtPrimerC.Name = "txtPrimerC";
            txtPrimerC.Size = new Size(347, 58);
            txtPrimerC.TabIndex = 1;
            // 
            // lblNumbers2
            // 
            lblNumbers2.AutoSize = true;
            lblNumbers2.Location = new Point(37, 111);
            lblNumbers2.Name = "lblNumbers2";
            lblNumbers2.Size = new Size(199, 20);
            lblNumbers2.TabIndex = 2;
            lblNumbers2.Text = "Ingrese el segundo conjunto:";
            lblNumbers2.Click += lblNumbers2_Click;
            // 
            // txtSegundoC
            // 
            txtSegundoC.Location = new Point(16, 145);
            txtSegundoC.Multiline = true;
            txtSegundoC.Name = "txtSegundoC";
            txtSegundoC.Size = new Size(347, 58);
            txtSegundoC.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(81, 247);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(114, 31);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Resultado
            // 
            Resultado.FormattingEnabled = true;
            Resultado.Location = new Point(16, 293);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(256, 144);
            Resultado.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(298, 314);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(298, 387);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += button2_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(404, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(Resultado);
            Controls.Add(btnCalculate);
            Controls.Add(txtSegundoC);
            Controls.Add(lblNumbers2);
            Controls.Add(txtPrimerC);
            Controls.Add(lblNumbers1);
            Name = "Form1";
            Text = "Diferencia de Conjuntos";
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