namespace usuario
{
    public partial class Form1 : Form
    {

        List<string> alfabetoMaiusculo = new List<string>() { "A", "B", "C", "D", "E" };
        List<string> alfabetoMinusculo = new List<string>() { "a", "b", "c", "d", "e" };
        List<char> numeros = new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        List<char> especiais = new List<char>() { '!', '@', '#', '$', '%', '&', '*' };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonEntrar1_Click(object sender, EventArgs e)
        {
            string usuario = textboxlogin1.Text;
            string senha = textboxsenha2.Text;

            if (string.IsNullOrWhiteSpace(usuario))
            {
                labelresultado.Text = "Usuario eh obrigatorio!";
                labelresultado.ForeColor = Color.Red;
                return;
            }

            if (string.IsNullOrWhiteSpace(senha))
            {
                labelresultado.Text = "Senha eh obrigatoria!";
                labelresultado.ForeColor = Color.Red;
                return;
            }

            bool autenticado = false;

            if (!autenticado)
            {
                labelresultado.Text = "Usuario ou senha incorretos";
                labelresultado.ForeColor = Color.Red;
                return;
            }
            labelresultado.Text = "Autenticado com Sucesso!";
            labelresultado.ForeColor = Color.Green;

            textboxlogin1.Clear();
            textboxsenha2.Clear();
        }

        private void buttonCadrasto4_Click(object sender, EventArgs e)
        {
            string novousuario = textBoxlogin2.Text;
            string novasenha = textboxsenha3.Text;

            if (string.IsNullOrWhiteSpace(novousuario))
            {
                labelresultadocadrasto.Text = "Usuario eh Obrigatotio!";
                return;
            }
            if (string.IsNullOrWhiteSpace(novasenha))
            {
                labelresultadocadrasto.Text = "Senha eh Obrigatoria";
            }
            if (novasenha.Length > 8)
            {
                labelresultadocadrasto.Text = "A senha deve ter pelo menos 8 caracteres";
                return;
            }
            if (!novasenha.Any(char.IsUpper))
            {
                labelresultadocadrasto.Text = "A senha deve ter pelo menos uma letra maiuscula";
                return;
            }
            if (!novasenha.Any(char.IsLower))
            {
                labelresultadocadrasto.Text = "A senha deve ter pelo menos uma letra minuscula";
                return;
            }
            if (!novasenha.Any(char.IsNumber))
            {
                labelresultadocadrasto.Text = "A senha deve ter pelo menos um nuemro";
                return;
            }
            if (!novasenha.Any(char.IsPunctuation) && !novasenha.Any(char.IsSymbol) && !novasenha.Contains('@'))
            {
                labelresultadocadrasto.Text = "A senha deve ter pelo menos um caracter especial";
                return;
            }
            if (novasenha.Any(char.IsWhiteSpace))
            {
                labelresultadocadrasto.Text = "A senha nao deve ter espacos em branco";
                return;

            }

            bool encontrado = false;
            if (encontrado)
            {
                labelresultado.Text = "Já existe um usuário cadrastado";
                return;
            }
        }
    }
}
