






namespace WinFormsDivisibleNumbers
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
            lblNumbers = new Label();
            txtNumbers = new TextBox();
            lblDivisor = new Label();
            txtDivisor = new TextBox();
            btnCalculate = new Button();
            Resultados = new ListBox();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // lblNumbers
            // 
            lblNumbers.AutoSize = true;
            lblNumbers.Location = new Point(13, 13);
            lblNumbers.Name = "lblNumbers";
            lblNumbers.Size = new Size(144, 20);
            lblNumbers.TabIndex = 0;
            lblNumbers.Text = "Ingrese los números:";
            // 
            // txtNumbers
            // 
            txtNumbers.Location = new Point(16, 42);
            txtNumbers.Multiline = true;
            txtNumbers.Name = "txtNumbers";
            txtNumbers.Size = new Size(454, 51);
            txtNumbers.TabIndex = 1;
            // 
            // lblDivisor
            // 
            lblDivisor.AutoSize = true;
            lblDivisor.Location = new Point(33, 114);
            lblDivisor.Name = "lblDivisor";
            lblDivisor.Size = new Size(124, 20);
            lblDivisor.TabIndex = 2;
            lblDivisor.Text = "Ingrese el divisor:";
            lblDivisor.Click += lblDivisor_Click;
            // 
            // txtDivisor
            // 
            txtDivisor.Location = new Point(201, 114);
            txtDivisor.Name = "txtDivisor";
            txtDivisor.Size = new Size(141, 27);
            txtDivisor.TabIndex = 3;
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(25, 216);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(87, 37);
            btnCalculate.TabIndex = 4;
            btnCalculate.Text = "Calcular";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Resultados
            // 
            Resultados.FormattingEnabled = true;
            Resultados.Location = new Point(159, 169);
            Resultados.Name = "Resultados";
            Resultados.Size = new Size(256, 144);
            Resultados.TabIndex = 5;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(159, 324);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(87, 37);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(339, 324);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(87, 37);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(485, 373);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(Resultados);
            Controls.Add(btnCalculate);
            Controls.Add(txtDivisor);
            Controls.Add(lblDivisor);
            Controls.Add(txtNumbers);
            Controls.Add(lblNumbers);
            Name = "Form1";
            Text = "Números Divisibles";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblNumbers;
        private System.Windows.Forms.TextBox txtNumbers;
        private System.Windows.Forms.Label lblDivisor;
        private System.Windows.Forms.TextBox txtDivisor;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.ListBox Resultados;
        private Button btnLimpiar;
        private Button btnSalir;
    }
}