﻿using System.Drawing.Text;
using System.Windows.Forms;

namespace CadrastoClientes
{
    public partial class Form1 : Form
    {
        private readonly List<Cliente> Clientes = new List<Cliente>();
        private readonly BindingSource BindingSource = new BindingSource();

        public Form1()
        {
            InitializeComponent();

            EnderecoCliente endereconeymar = new EnderecoCliente
            {
                logradouro = "endereco do neymar",
                Numero = "11",
                Complemento = "Apartamento",
                Bairro = "Centro",
                Municipio = "São Paulo",
                Estado = "SP",
                Cep = "01234-567"
            };

            Cliente neymar = new Cliente()
            {
                Id = 1,
                Nome = "Neymar Junior",
                datadenascimento = "05/02/1992",
                Etnia = EtniaCliente.branco,
                generocliente = GeneroCliente.masculino,
                Tipo = TipoCliente.PF,
                telefone = "(11) 98765 - 4321",
                Email = "neymar.jr@email.com",
                NomeSocial = "Ney Jr",
                EnderecoCliente = endereconeymar
            };
            EnderecoCliente enderecoyuri = new EnderecoCliente
            {
                logradouro = "endereco do yuri",
                Numero = "9",
                Complemento = "Apartamento",
                Bairro = "Centro",
                Municipio = "São Paulo",
                Estado = "SP",
                Cep = "07894-567"
            };

            Cliente yuri = new Cliente()
            {
                Id = 2,
                Nome = "Yuri Alberto",
                datadenascimento = "18/03/2001",
                Etnia = EtniaCliente.branco,
                generocliente = GeneroCliente.masculino,
                Tipo = TipoCliente.PF,
                telefone = "(11) 98765-0124",
                Email = "yurialberto@email.com",
                NomeSocial = "alberto",
                EnderecoCliente = enderecoyuri
            };
            EnderecoCliente enderecothais = new EnderecoCliente
            {
                logradouro = "endereco da thais",
                Numero = "98",
                Complemento = "Casa",
                Bairro = "Jd Santo amaro",
                Municipio = "São Paulo",
                Estado = "SP",
                Cep = "012874-987"
            };


            Cliente thais = new Cliente()
            {
                Id = 3,
                Nome = "Thais Ribeiro",
                datadenascimento = "21/12/1997",
                Etnia = EtniaCliente.branco,
                generocliente = GeneroCliente.masculino,
                Tipo = TipoCliente.PF,
                telefone = "(11) 91235-0124",
                Email = "thaisribeiro@email.com",
                NomeSocial = "ribeiro",
                EnderecoCliente = endereconeymar

            };
            BindingSource.DataSource = Clientes;
            dataGridViewclientes.DataSource = BindingSource;


        }

        private void buttoncadastro_Click(object sender, EventArgs e)
        {
            CampoNaoPreechido();
            MessageBox.Show("Por favor, preencha todos os campos obrigatórios.");
            return;
        }


        private void CampoNaoPreechido()
        {
            if (string.IsNullOrEmpty(textboxID.Text) ||
            string.IsNullOrEmpty(textboxName.Text) ||
            string.IsNullOrWhiteSpace(datadenascimento.Text) ||
            string.IsNullOrWhiteSpace(textboxtelefone.Text) ||
            string.IsNullOrWhiteSpace(textBoxendereco.Text) ||
            string.IsNullOrWhiteSpace(textBoxemail.Text) ||
            string.IsNullOrWhiteSpace(textBoxnomesocial.Text) ||
            comboBoxGenero.SelectedIndex == -1 ||
            combobox01.SelectedIndex == -1 ||
            string.IsNullOrWhiteSpace(textBoxlogradouro.Text) ||
            string.IsNullOrWhiteSpace(textboxcep.Text) ||
            string.IsNullOrWhiteSpace(textBoxbairro.Text) ||
            string.IsNullOrWhiteSpace(textboxmunicipio.Text) ||
            string.IsNullOrWhiteSpace(textBoxEstado.Text) ||
            string.IsNullOrWhiteSpace(textboxnumero.Text))

            {

            }

        }
    }

}

