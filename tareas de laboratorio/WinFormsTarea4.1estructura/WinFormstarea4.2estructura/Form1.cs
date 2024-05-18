



namespace WinFormstarea4._2estructura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string inputPalabras = txtPalabras.Text;
            string inputLetra = txtLetra.Text;
            if (inputLetra.Length != 1)
            {
                MessageBox.Show("Por favor, ingrese una sola letra.");
                return;
            }
            char letra = inputLetra[0];
            HashSet<string> palabras = new HashSet<string>(inputPalabras.Split(',')
                .Select(p => p.Trim()).Where(p => !string.IsNullOrEmpty(p)));

            HashSet<string> palabrasFiltradas = FiltrarPalabras.ObtenerPalabrasQueComienzanCon(palabras, letra);

            Resultados.Items.Clear();
            foreach (string palabra in palabrasFiltradas)
            {
                Resultados.Items.Add(palabra);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtLetra.Clear();
            txtPalabras.Clear();
            Resultados.Items.Clear();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void txtPalabras_TextChanged(object sender, EventArgs e)
        {

        }
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
    public static class FiltrarPalabras
    {
        public static HashSet<string> ObtenerPalabrasQueComienzanCon(HashSet<string> palabras, char letra)
        {
            letra = char.ToLower(letra);  
            HashSet<string> resultado = new HashSet<string>();

            foreach (string palabra in palabras)
            {
                if (palabra.Length > 0 && char.ToLower(palabra[0]) == letra)
                {
                    resultado.Add(palabra);
                }
            }

            return resultado;
        }
    }
}
