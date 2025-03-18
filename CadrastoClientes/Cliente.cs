using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadrastoClientes
{
    internal class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string datadenascimento { get; set; }
        public string telefone { get; set; }
        public string Email { get; set; }
        public string NomeSocial { get; set; }
        public EnderecoCliente EnderecoCliente { get; set; }
        public GeneroCliente generocliente { get; set; }
        public EtniaCliente Etnia { get; set; }
        bool estrangeiro { get; set; }
        public TipoCliente Tipo { get; set; }
    }
}
