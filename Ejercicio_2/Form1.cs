using Ejercicio_2WF;

namespace Ejercicio_2
{
    /// <summary>
    /// Hacer una calculadora que permita las siguientes operaciones:
    /// Sumar, restar, multiplicar y dividir.
    /// </summary>
    public partial class Form1 : Form
    {
        public decimal Acumulado { get; set; }
        public decimal Numero1 { get; set; }
        public Operador? Operacion { get; set; }


        public Form1()
        {
            InitializeComponent();

            txtResultado.Text = string.Empty;
            txtAcumulado.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = string.Empty;
            txtAcumulado.Text = "0";
            Numero1 = 0;
            Acumulado = 0;


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == string.Empty)

                txtResultado.Text = "1";

            else
                txtResultado.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == string.Empty)

                txtResultado.Text = "2";

            else
                txtResultado.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == string.Empty)

                txtResultado.Text = "3";

            else
                txtResultado.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == string.Empty)

                txtResultado.Text = "4";

            else
                txtResultado.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == string.Empty)

                txtResultado.Text = "5";

            else
                txtResultado.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == string.Empty)

                txtResultado.Text = "6";

            else
                txtResultado.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == string.Empty)

                txtResultado.Text = "7";

            else
                txtResultado.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == string.Empty)

                txtResultado.Text = "8";

            else
                txtResultado.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == string.Empty)

                txtResultado.Text = "9";

            else
                txtResultado.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == string.Empty)

                txtResultado.Text = "0";

            else
                txtResultado.Text += "0";
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text == string.Empty)

                txtResultado.Text = "0,";

            else
            {
                if (!txtResultado.Text.Contains(","))
                {
                    txtResultado.Text += ",";
                }
            }
        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            if (txtResultado.Text != string.Empty)
            {
                Operacion = Operador.Mas;

                Numero1 = Convert.ToDecimal(txtResultado.Text);
                Acumulado += Numero1;

                txtAcumulado.Text = Acumulado.ToString();
                txtResultado.Text = string.Empty;

            }


        }

        private void btnMenos_Click(object sender, EventArgs e)
        {

            if (txtResultado.Text != string.Empty)
            {
                Operacion = Operador.Menos;

                Numero1 = Convert.ToDecimal(txtResultado.Text);

                if (txtAcumulado.Text =="0")
                    Acumulado = Numero1;

                else
                Acumulado -= Numero1;

                txtAcumulado.Text = Acumulado.ToString();
                txtResultado.Text = string.Empty;

            }


        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {

            if (txtResultado.Text != string.Empty)
            {
                Operacion = Operador.Por;

                Numero1 = Convert.ToDecimal(txtResultado.Text);
                if (Acumulado != 0)
                    Acumulado *= Numero1;
                else
                    Acumulado = Numero1;


                txtAcumulado.Text = Acumulado.ToString();
                txtResultado.Text = string.Empty;

            }


        }

        private void btnDividir_Click(object sender, EventArgs e)
        {

            if (txtResultado.Text != string.Empty)
            {
                Operacion = Operador.Dividir;

                Numero1 = Convert.ToDecimal(txtResultado.Text);
                if (Acumulado != 0)
                Acumulado /= Numero1;

                else
                    Acumulado = Numero1;

                txtAcumulado.Text = Acumulado.ToString();
                txtResultado.Text = string.Empty;

            }


        }

        private void btnIgual_Click(object sender, EventArgs e)
        {

            if (txtResultado.Text != string.Empty)
            {

                Numero1 = Convert.ToDecimal(txtResultado.Text);

                switch (Operacion)
                {
                    case Operador.Mas:
                        Acumulado += Numero1;
                        break;
                    case Operador.Menos:
                        Acumulado -= Numero1;
                        break;
                    case Operador.Por:
                        Acumulado *= Numero1;
                        break;
                    case Operador.Dividir:
                        Acumulado /= Numero1;
                        break;

                    default:
                        break;

                }
                txtAcumulado.Text = "0";
                txtResultado.Text = Acumulado.ToString();
                Acumulado = 0;
                Operacion = null;
                Numero1 = 0;
            }
            Operacion = null;
            Numero1 = 0;

        }

    }
}