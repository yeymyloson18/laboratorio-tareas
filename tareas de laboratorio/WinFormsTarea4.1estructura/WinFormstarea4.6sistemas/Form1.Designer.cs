



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
            primer = new Label();
            txtPrimerC = new TextBox();
            lblSegundo = new Label();
            txtSegundoC = new TextBox();
            btnCalculate = new Button();
            Resultado = new ListBox();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // primer
            // 
            primer.AutoSize = true;
            primer.Location = new Point(13, 13);
            primer.Name = "primer";
            primer.Size = new Size(186, 20);
            primer.TabIndex = 0;
            primer.Text = "Ingrese el primer conjunto:";
            // 
            // txtPrimerC
            // 
            txtPrimerC.Location = new Point(16, 50);
            txtPrimerC.Multiline = true;
            txtPrimerC.Name = "txtPrimerC";
            txtPrimerC.Size = new Size(424, 62);
            txtPrimerC.TabIndex = 1;
            // 
            // lblSegundo
            // 
            lblSegundo.AutoSize = true;
            lblSegundo.Location = new Point(16, 127);
            lblSegundo.Name = "lblSegundo";
            lblSegundo.Size = new Size(199, 20);
            lblSegundo.TabIndex = 2;
            lblSegundo.Text = "Ingrese el segundo conjunto:";
            lblSegundo.Click += lblNumbers2_Click;
            // 
            // txtSegundoC
            // 
            txtSegundoC.Location = new Point(16, 150);
            txtSegundoC.Multiline = true;
            txtSegundoC.Name = "txtSegundoC";
            txtSegundoC.Size = new Size(424, 79);
            txtSegundoC.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(12, 250);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(132, 29);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Resultado
            // 
            Resultado.FormattingEnabled = true;
            Resultado.Location = new Point(16, 313);
            Resultado.Name = "Resultado";
            Resultado.Size = new Size(307, 124);
            Resultado.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(355, 327);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(355, 390);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(472, 450);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(Resultado);
            Controls.Add(btnCalculate);
            Controls.Add(txtSegundoC);
            Controls.Add(lblSegundo);
            Controls.Add(txtPrimerC);
            Controls.Add(primer);
            Name = "Form1";
            Text = "Diferencia de Conjuntos";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label primer;
        private System.Windows.Forms.TextBox txtPrimerC;
        private System.Windows.Forms.Label lblSegundo;
        private System.Windows.Forms.TextBox txtSegundoC;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox Resultado;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}