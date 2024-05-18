




namespace WinFormsInterseccionNumeros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el primer conjunto de n�meros desde el TextBox
                string numbersInput1 = txtPrimerC.Text;
                List<int> numbers1 = numbersInput1.Split(new[] { ',', ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                                                  .Select(int.Parse)
                                                  .ToList();

                // Obtener el segundo conjunto de n�meros desde el TextBox
                string numbersInput2 = txtSegundoC.Text;
                List<int> numbers2 = numbersInput2.Split(new[] { ',', ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries)
                                                  .Select(int.Parse)
                                                  .ToList();

                // Obtener la intersecci�n de los dos conjuntos
                List<int> intersectedNumbers = GetIntersectedNumbers(numbers1, numbers2);

                // Mostrar los resultados en el ListBox
                Resultado.Items.Clear();
                foreach (int num in intersectedNumbers)
                {
                    Resultado.Items.Add(num);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private List<int> GetIntersectedNumbers(List<int> numbers1, List<int> numbers2)
        {
            return numbers1.Intersect(numbers2).ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblNumbers1_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPrimerC.Clear();
            txtSegundoC.Clear();
            Resultado.Items.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}