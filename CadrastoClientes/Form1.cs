namespace CadrastoClientes
{
    public partial class Form1 : Form
    {
        public static void main()
        {
            List<Cliente> listacliente = new List<Cliente>();
            listacliente.Add(new Cliente
            {
                Id = 1,
                Nome = "Neymar Junior",
                telefone = "(11) 98765-4321",
                Email = "neymar.jr@email.com",
                NomeSocial = "Ney jr",
                datadenascimento = "05/02/1992",
                EnderecoCliente = new EnderecoCliente { logradouro = "endereco do neymar", Numero = "11", Complemento = "Apartamento", Bairro = "Centro", Municipio = "São Paulo", Estado = "SP", Cep = "01234-567"},










            });

        }
        public Form1()
        {
            InitializeComponent();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void buttoncadastro_Click(object sender, EventArgs e)
        {
            int id = int.Parse(textboxID.Text);
            string nome = textboxName.Text;
            string datadenascimemto = datadenascimento.Text;
            string telefone = textboxtelefone.Text;
            string email = textBoxemail.Text;
            string nomesocial = textBoxnomesocial.Text;
            string genero = comboBoxGenero.SelectedText.ToString();
            string etnia = combobox01.SelectedText.ToString();
            bool estrangeiro = cheeckEstrangeiro.Checked;
            string endereco = textBoxendereco.Text;
            string logradouro = textBoxlogradouro.Text;
            string bairro = textBoxbairro.Text;
            string municipio = textboxmunicipio.Text;
            string estado = textBoxEstado.Text;
            string numero = textboxnumero.Text;



            Labelresultado.Text = "Cliente Cadrastado com sucesso!";


        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
