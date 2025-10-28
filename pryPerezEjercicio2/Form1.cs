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

            // 2. Calcular la distancia total
            double distanciaTotal = distancia * 2;

            // 3. Calcular el precio base
            double precioBase = distanciaTotal * 5;

            // 4. Decidir el precio final
            double precioFinal; // Creamos la variable "vac�a"

            // �La condici�n!
            if (dias >= 7 && distancia >= 100)
            {
                // CAMINO CON DESCUENTO:
                // El precio final es el precio base menos el 50% (o sea, multiplicado por 0.5)
                precioFinal = precioBase * 0.5;
            }
            else
            {
                // CAMINO SIN DESCUENTO:
                // El precio final es simplemente el precio base
                precioFinal = precioBase;
            }

            // 5. Mostrar el resultado
            // El 'ToString("C")' formatea el n�mero como moneda (ej: "$ 55,00")
            MessageBox.Show("El precio total de su boleto (ida y vuelta) es: " + precioFinal.ToString("C"));
        }



    }
}

