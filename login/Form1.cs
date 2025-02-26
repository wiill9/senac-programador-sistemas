using System.Diagnostics.Eventing.Reader;

namespace login
{
    public partial class formlogin : Form
    {
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
            string usuario = textBoxlogin.Text;
            string senha = textsenhabox.Text;

            if (usuario == null || usuario == "")
            {
             labelResultado.Text = "Login Obrigatório!";
                labelResultado.ForeColor = Color.Black;

            }
           else if (usuario == "Wilder.Santos" && senha == "12345")
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
}
