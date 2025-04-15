using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ListaAtividade.atividade
{
    internal class Atividade
    {
        public int id {  get; set; }    
        public string Titulo { get; set; } 
        public Situacao Situacao { get; set; }


        public void Criar ()
        {

        }

        public void AtualizarSituacao()
        {

        }

        public Atividade BuscarAtividadeEmaAndamento()
        {
            return new Atividade();
        }
        public List <Atividade> ListarAtividadesPendentes()
        {
            return [];
        }

        private bool ValidarTitulo()
        {
            return string.IsNullOrWhiteSpace(Titulo);
        }

        private Situacao BuscarProximaSituacao()
        {
            return Situacao.Concluido;
        }

    }
}
