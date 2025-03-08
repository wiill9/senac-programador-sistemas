using System.Diagnostics.Eventing.Reader;

namespace login
{
    public partial class Formlogin : Form
    {
        List<string> alfabetoMaiusculo = new List<string>() { "A", "B", "C", "D", "E" };
        List<string> alfabetoMinusculo = new List<string>() { "a", "b", "c", "d", "e" };
        List<char> numeros = new List<char>() { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        List<char> especiais = new List<char>() { '!', '@', '#', '$', '%', '&', '*' };



        List<string> listausuarios = new List<string>() { "neymar.jr", "pablo.vittar", "sukuna.silva" };
        List<string> listasenha = new List<string>() { "bruna", "12345", "777" };
        
        

        public Formlogin()
        {
            InitializeComponent();
             
        }

        private void formlogin_Load(object sender, EventArgs e)
        {

        }

        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            string usuarioBuscado = textBoxlogin.Text;
            string senha = textsenhabox.Text;

            int usuarioEncontrado = -1;

            for (int i = 0; i < listausuarios.Count; i++)
                if (usuarioBuscado == listausuarios[i])
                {
                    usuarioEncontrado = i;
                }

            if (usuarioEncontrado > -1 && senha == "12345")
            {
                labelResultado.Text = "Autenticado com sucesso!";
                labelResultado.ForeColor = Color.Green;
            }
            else
            {
                labelResultado.Text = "usuario e senha incorretos";
                labelResultado.ForeColor = Color.Red;
            }
            if (string.IsNullOrWhiteSpace(usuarioBuscado))
            {
                labelResultado.Text = "Login Obrigatorio!";
                labelResultado.ForeColor = Color.DarkRed;

            }
            else if (senha == null || senha == "")
            {
                labelResultado.Text = "Senha Obrigatorio!";
                labelResultado.ForeColor = Color.Red;
            }

        }
        

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView2_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string usuario = textBoxnovomembrojr.Text;
            string senha = textBoxnovasenha.Text;
           

                bool usuarioencontrado = false;
            for (int i = 0; i < listausuarios.Count; i++)
            {
                if (string.IsNullOrWhiteSpace(usuario))
                {
                    labelneymarjrnovo.Text = "Usuario eh obrigatório!!!";
                    return;
                }
                if (string.IsNullOrWhiteSpace(senha))
                {
                   labelResultado.Text = "Senha eh obrigatoria!!!";
                    return;
                }
                if (senha.Length < 8)
                {
                    labelneymarjrnovo.Text = "A senha deve ter pelo menos 8 caracteres";
                    return;
                }
                if (!senha.Any(char.IsUpper))
                {
                    labelneymarjrnovo.Text = "A senha deve ter pelo menos uma letra maiuscula";
                    return;
                }
                if (!senha.Any(char.IsLower))
                {
                    labelneymarjrnovo.Text = "A senha deve ter pelo menos uma letra minuscula";
                    return;
                }
                if (!senha.Any(char.IsDigit))
                {
                    labelneymarjrnovo.Text = "A senha deve ter pelo menos um numero";
                    return;
                }
                if (!senha.Any(char.IsPunctuation))
                {
                    labelneymarjrnovo.Text = "A senha deve ter pelo menos um caracter especial";
                    return;
                }

                if (usuario == listausuarios[i])
                {
                    usuarioencontrado = true;
                }
            }

            if (!usuarioencontrado)
            {

                listausuarios.Add(usuario);
                listasenha.Add(senha);
                labelneymarjrnovo.Text = "usuario cadrastado com sucesso!";
            }
            else
            {
                labelneymarjrnovo.Text = "O usuario ja existe!";
            }







        }

        


        private void textBoxnovasenha_TextChanged(object sender, EventArgs e)
        {

        }

        internal record struct NewStruct(object Item1, object Item2)
        {
            public static implicit operator (object, object)(NewStruct value)
            {
                return (value.Item1, value.Item2);
            }

            public static implicit operator NewStruct((object, object) value)
            {
                return new NewStruct(value.Item1, value.Item2);
            }
        }

        private void TextBoxnovomembrojr_TextChanged(object sender, EventArgs e)
        {


        }

    }
}
