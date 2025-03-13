namespace calculadora
{
    public partial class Calculadora : Form
    {
        public decimal resultado { get; set; }
        public decimal valor { get; set; }
        private Operacao OperacaoSelecionada { get; set; }
        private enum Operacao
        {
            adicao,
            subtracao,
            multiplicacao,
            divisao,
        }


        public Calculadora()
        {
            InitializeComponent();
        }

        private void Calculadora_Load(object sender, EventArgs e)
        {

        }

        private void button0_Click(object sender, EventArgs e)
        {
            textresultado.Text += "0";
        }

        private void button09_Click(object sender, EventArgs e)
        {
            textresultado.Text += "9";
        }

        private void button07_Click(object sender, EventArgs e)
        {
            textresultado.Text += "7";
        }

        private void button06_Click(object sender, EventArgs e)
        {
            textresultado.Text += "6";
        }

        private void button05_Click(object sender, EventArgs e)
        {
            textresultado.Text += "5";
        }

        private void button04_Click(object sender, EventArgs e)
        {
            textresultado.Text += "4";
        }

        private void button03_Click(object sender, EventArgs e)
        {
            textresultado.Text += "3";
        }

        private void button02_Click(object sender, EventArgs e)
        {
            textresultado.Text += "2";
        }

        private void button01_Click(object sender, EventArgs e)
        {
            textresultado.Text += "1";

        }

        private void button08_Click(object sender, EventArgs e)
        {
            textresultado.Text += "8";
        }

        private void buttonAdição_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.adicao;
            valor = Convert.ToDecimal(textresultado.Text);
            textresultado.Text = " ";
        }

        private void buttonSubtração_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.subtracao;
            valor = Convert.ToDecimal(textresultado.Text);
            textresultado.Text = " ";
        }

        private void buttonMultiplicação_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.multiplicacao;
            valor = Convert.ToDecimal(textresultado.Text);
            textresultado.Text = " ";
        }

        private void buttonDivisão_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.divisao;
            valor = Convert.ToDecimal(textresultado.Text);
            textresultado.Text = " ";

        }

        private void buttonIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.adicao:
                    resultado = valor + Convert.ToDecimal(textresultado.Text);
                    break;
                case Operacao.subtracao:
                    resultado = valor - Convert.ToDecimal(textresultado.Text);
                    break;
                case Operacao.multiplicacao:
                    resultado = valor * Convert.ToDecimal(textresultado.Text);
                    break;
                case Operacao.divisao:
                    resultado = valor / Convert.ToDecimal(textresultado.Text);
                    break;
            }
            textresultado.Text = Convert.ToString(resultado);

        }

        private void buttonVirgula_Click(object sender, EventArgs e)
        {
            if (!textresultado.Text.Contains(","))
                textresultado.Text += ",";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textresultado.Text = " ";
        }
    }
    
}
