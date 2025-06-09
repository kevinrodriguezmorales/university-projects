using System.Collections;
using System.Data;

namespace Calculadora
{
    public partial class Calculadora : Form
    {
        public string operationSummary;
        public string currentDigit;
        public string operationFinal;
        public string operationPartial;
        public Boolean resetOperationPartial = false;
        public string lastValueEntered;
        public Boolean resetOperationTotal = false;

        public Calculadora()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void MostrarResumen(string input)
        {
            operationSummary = currentDigit + input;
            lblResumen.Text = operationSummary;
        }

        private void ConcatenarDigito(string input)
        {
            currentDigit += input;
            lblActual.Text = currentDigit;
        }

        private void DetectarCaracter(string caracter)
        {
            operationFinal += caracter;

            var value = char.Parse(caracter);

            if (!char.IsDigit(value) && caracter != "")
            {
                MostrarResumen(caracter);
                resetOperationPartial = true;
            }
            else
            {
                if (!resetOperationPartial)
                {
                    ConcatenarDigito(caracter);
                    lblActual.Text = currentDigit;
                }
                else
                {
                    currentDigit = "";
                    resetOperationPartial = false;
                    ConcatenarDigito(caracter);
                }
            }
        }

        private void ResetearCalculadora()
        {
            operationSummary = "";
            currentDigit = "";
            operationFinal = "";
            resetOperationPartial = false;
            resetOperationTotal = false;

            lblActual.Text = "0";
            lblResumen.Text = "";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            string initialValue = lblActual.Text;

            // Validar que concatene siempre y cuando sea diferente de cero
            if (initialValue != "0")
            {
                if (resetOperationTotal) ResetearCalculadora();
                DetectarCaracter("0");
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (resetOperationTotal) ResetearCalculadora();
            DetectarCaracter("1");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (resetOperationTotal) ResetearCalculadora();
            DetectarCaracter("2");
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (resetOperationTotal) ResetearCalculadora();
            DetectarCaracter("3");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (resetOperationTotal) ResetearCalculadora();
            DetectarCaracter("4");
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (resetOperationTotal) ResetearCalculadora();
            DetectarCaracter("5");
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (resetOperationTotal) ResetearCalculadora();
            DetectarCaracter("6");
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (resetOperationTotal) ResetearCalculadora();
            DetectarCaracter("7");
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (resetOperationTotal) ResetearCalculadora();
            DetectarCaracter("8");
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (resetOperationTotal) ResetearCalculadora();
            DetectarCaracter("9");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            DetectarCaracter("/");
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            DetectarCaracter("*");
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            DetectarCaracter("-");
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            DetectarCaracter("+");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetearCalculadora();
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            operationPartial = operationFinal;
            lblResumen.Text = operationPartial;

            if (operationFinal == null || operationFinal == "")
            {
                MessageBox.Show(
                    "Por favor, ingresa una operación válida. Ejemplo: 2+2",
                    "Sin selección",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            var resultado = new DataTable().Compute(operationFinal, null);
            lblActual.Text = resultado?.ToString() ?? "0";

            ListaDoble lista = new ListaDoble();
            lista.InsertarAlFinal(int.Parse(resultado?.ToString()));

            ArrayList datos = lista.Mostrar();
            foreach (var item in datos)
            {
                lbHistorial.Items.Add(item);
            }

            resetOperationTotal = true;
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }
    }
}
