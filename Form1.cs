namespace ejercicio_3_practica_2
{
    public partial class Form1 : Form
    {
        private int suma = 0;
        private int cantidad = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int numero = Convert.ToInt32(txtboxnum.Text);

            if (numero == 0)
            {
                // Reiniciar valores
                suma = 0;
                cantidad = 0;

                txtboxnum.Clear();
                lblsuma.Text = "";
                lblcantidad.Text = "";
                lblpromedio.Text = "";
            }
            else
            {
                // Acumular
                suma += numero;
                cantidad++;

                // Mostrar resultados en etiquetas
                lblsuma.Text = suma.ToString();
                lblcantidad.Text = cantidad.ToString();
                lblpromedio.Text = (suma / (double)cantidad).ToString("0.00");

                txtboxnum.Clear();
            }

            txtboxnum .Focus();
        }
    }
}
