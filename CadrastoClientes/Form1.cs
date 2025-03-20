namespace CadrastoClientes
{
    public partial class Form1 : Form
    {
        public static void main()
        {
            List<Cliente> listaCliente = new List<Cliente>();
            listaCliente.Add(new Cliente
            {
                Id = 1,
                Nome = "Neymar Junior",
                telefone = "(11) 98765-4321",
                Email = "neymar.jr@email.com",
                NomeSocial = "Ney jr",
                datadenascimento = "05/02/1992",
                EnderecoCliente = new EnderecoCliente { logradouro = "endereco do neymar", Numero = "11", Complemento = "Apartamento", Bairro = "Centro", Municipio = "São Paulo", Estado = "SP", Cep = "01234-567" },
                Tipo = TipoCliente.PF,
                Etnia = EtniaCliente.branco,
                generocliente = GeneroCliente.masculino,
            });
            listaCliente.Add(new Cliente
            {
                Id = 2,
                Nome = "Yuri Alberto",
                telefone = "(11) 98765-0124",
                Email = "yurialberto@email.com",
                NomeSocial = "alberto",
                datadenascimento = "18/03/2001",
                EnderecoCliente = new EnderecoCliente { logradouro = "endereco do yuri", Numero = "9", Complemento = "Apartamento", Bairro = "itaquera", Municipio = "São Paulo", Estado = "SP", Cep = "08965-567" },
                Tipo = TipoCliente.PF,
                Etnia = EtniaCliente.branco,
                generocliente = GeneroCliente.masculino,
            });
            listaCliente.Add(new Cliente
            {
                Id = 3,
                Nome = "Thais Ribeiro",
                telefone = "(11) 91235-0124",
                Email = "thaisribeiro@email.com",
                NomeSocial = "ribeiro",
                datadenascimento = "30/10/1990",
                EnderecoCliente = new EnderecoCliente { logradouro = "jd santo amaro", Numero = "98", Complemento = "Casa", Bairro = "Cohab", Municipio = "São Paulo", Estado = "SP", Cep = "05456-567" },
                Tipo = TipoCliente.PF,
                Etnia = EtniaCliente.branco,
                generocliente = GeneroCliente.feminino,
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
            try
            {
                Cliente listacliente = new Cliente();
                (
                   textboxID.Text,
                   textboxName.Text,
                   datadenascimento.Text,
                   textboxtelefone.Text,
                   textBoxemail.Text,
                   textBoxnomesocial.Text,
                   comboBoxGenero.Text,
                   combobox01.Text,
                   textBoxendereco.Text,
                   textBoxlogradouro.Text,
                   textBoxbairro.Text,
                   textboxmunicipio.Text,
                   textBoxEstado.Text,
                   textboxnumero.Text,
                   cheeckEstrangeiro.Checked,
               );

            }

        }



        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
