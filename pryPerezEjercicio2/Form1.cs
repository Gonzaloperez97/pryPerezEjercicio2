using System.Windows.Forms;

namespace pryPerezEjercicio2
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            // 1. Leemos los d�as. (int) convierte el valor a un n�mero entero.
            // Supongamos que tu control se llama numericUpDown1
            int dias = (int)nudCantidad.Value;

            // 2. Leemos la distancia. double.Parse() convierte el texto a un n�mero con decimales.
            // Supongamos que tu control se llama txtDistancia
            double distancia = double.Parse(txtDistancia.Text);

            // --- Aqu� haremos los c�lculos ---



        }
    }
}
