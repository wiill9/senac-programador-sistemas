using System.Diagnostics.Eventing.Reader;

namespace login
{
    public partial class formlogin : Form
    {
        List<string> listausuarios = new List<string>() { "neymar.jr", " pablo.vittar", "sukuna.silva" };

        public formlogin()
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
            string usuarioEncontrado;
             

        for (int i = 0; i < listausuarios.Count; i++)
           if (usuarioBuscado == listausuarios[i])

            {
                    usuarioEncontrado = listausuarios[i];
            }
           
            if (usuarioBuscado == "usuarioEncontrado" && senha == "12345")
            {
                labelResultado.Text = "Autenticado com sucesso!";
                labelResultado.ForeColor = Color.Green;
            }
            else
            {
                labelResultado.Text = "usuario e senha incorretos";
                labelResultado.ForeColor = Color.Red;
            }


        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void treeView2_AfterSelect_1(object sender, TreeViewEventArgs e)
        {

        }
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
}
