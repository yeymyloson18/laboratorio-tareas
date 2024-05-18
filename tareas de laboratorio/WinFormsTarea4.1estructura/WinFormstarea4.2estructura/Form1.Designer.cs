


namespace WinFormstarea4._2estructura
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtPalabras;
        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.ListBox Resultados;
        private System.Windows.Forms.Label lblPalabras;
        private System.Windows.Forms.Label lblLetra;

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
            txtPalabras = new TextBox();
            txtLetra = new TextBox();
            btnFiltrar = new Button();
            Resultados = new ListBox();
            lblPalabras = new Label();
            lblLetra = new Label();
            btnLimpiar = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // txtPalabras
            // 
            txtPalabras.Location = new Point(12, 29);
            txtPalabras.Name = "txtPalabras";
            txtPalabras.Size = new Size(457, 27);
            txtPalabras.TabIndex = 0;
            // 
            // txtLetra
            // 
            txtLetra.Location = new Point(132, 82);
            txtLetra.Name = "txtLetra";
            txtLetra.Size = new Size(50, 27);
            txtLetra.TabIndex = 1;
            // 
            // btnFiltrar
            // 
            btnFiltrar.Location = new Point(143, 115);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(80, 39);
            btnFiltrar.TabIndex = 2;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.UseVisualStyleBackColor = true;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // Resultados
            // 
            Resultados.FormattingEnabled = true;
            Resultados.Location = new Point(12, 172);
            Resultados.Name = "Resultados";
            Resultados.Size = new Size(354, 164);
            Resultados.TabIndex = 3;
            // 
            // lblPalabras
            // 
            lblPalabras.AutoSize = true;
            lblPalabras.Location = new Point(12, 9);
            lblPalabras.Name = "lblPalabras";
            lblPalabras.Size = new Size(121, 20);
            lblPalabras.TabIndex = 4;
            lblPalabras.Text = "Ingrese palabras:";
            // 
            // lblLetra
            // 
            lblLetra.AutoSize = true;
            lblLetra.Location = new Point(23, 82);
            lblLetra.Name = "lblLetra";
            lblLetra.Size = new Size(94, 20);
            lblLetra.TabIndex = 5;
            lblLetra.Text = "Ingrese letra:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(398, 185);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(389, 276);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 7;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            btnSalir.Click += btnSalir_Click;
            // 
            // Form1
            // 
            ClientSize = new Size(504, 361);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(lblLetra);
            Controls.Add(lblPalabras);
            Controls.Add(Resultados);
            Controls.Add(btnFiltrar);
            Controls.Add(txtLetra);
            Controls.Add(txtPalabras);
            Name = "Form1";
            Text = "Filtrar Palabras";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button btnLimpiar;
        private Button btnSalir;
    }
}