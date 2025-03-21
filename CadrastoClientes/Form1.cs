using System.Windows.Forms;

namespace CadrastoClientes
{
    public partial class Form1 : Form
    {
        private readonly List<Cliente> Clientes = [];
        private readonly BindingSource BindingSource = [];
        
        public Form1()
        {
            InitializeComponent();
           
            EnderecoCliente endereconeymar = new EnderecoCliente { logradouro = "endereco do neymar", Numero = "11", Complemento = "Apartamento", Bairro = "Centro", Municipio = "São Paulo", Estado = "SP", Cep = "01234-567" };
            Cliente neymar = new Cliente() { Id = 1, Nome = "Neymar Junior", datadenascimento = "05/02/1992", Etnia = EtniaCliente.outros, generocliente = GeneroCliente.masculino, Tipo = TipoCliente.PF, EnderecoCliente = endereconeymar };
            Cliente.Add(neymar);

            EnderecoCliente enderecoyuri = new EnderecoCliente { logradouro = "endereco do yuri", Numero = "9", Complemento = "Apartamento", Bairro = "Centro", Municipio = "São Paulo", Estado = "SP", Cep = "01456-567" };
            Cliente yuri = new Cliente() { Id = 2, Nome = "Yuri Alberto", datadenascimento = "18/03/2001", Etnia = EtniaCliente.branco, generocliente = GeneroCliente.masculino, Tipo = TipoCliente.PF, EnderecoCliente = enderecoyuri };
            Cliente.Add(yuri);

            EnderecoCliente enderecothais = new EnderecoCliente { logradouro = "endereco da thais", Numero = "98", Complemento = "Casa", Bairro = "Centro", Municipio = "São Paulo", Estado = "SP", Cep = "07895-567" };
            Cliente thais = new Cliente() { Id = 2, Nome = "Thais Ribeiro", datadenascimento = "28/02/1997", Etnia = EtniaCliente.branco, generocliente = GeneroCliente.feminino, Tipo = TipoCliente.PF, EnderecoCliente = enderecothais};
            Cliente.Add(thais);

            BindingSource.DataSource = Clientes;
            dataGridViewclientes.DataSource = BindingSource;




        }
    }

       