using System.Drawing.Text;

namespace Calculadora.sx
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool Validarform()
        {
            if (string.IsNullOrEmpty(textBoxValor1.Text))
            {
                labelresultado.Text = "o valor 1 eh obrigatorio";
                textBoxValor1.Focus();

            }
        }

        private void textBoxValor1_TextChanged(object sender, EventArgs e)
        { 
            if (string.IsNullOrEmpty(textBoxValor1.Text))
            {
                labelresultado.Text = "o valor 1 eh obrigatorio";
                textBoxValor1.Focus();
               
            }

        }
    }
}

