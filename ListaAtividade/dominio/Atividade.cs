using ListaAtividade.repositorio;
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


        private readonly AtividadeRepositorio repositorio = new();
        public bool Criar ()
        {
            if (!ValidarTitulo())
            {
                return false;

            }

            repositorio.Criar(Titulo);
            return true;
        }

        public bool AtualizarSituacao()
        {
            if (!Validarid())
            {

                return false;
            }
            if (!ValidarSituacao())
            {
                return false;
            }
            Atividade atividadeEmAndamento = BuscarAtividadeEmAndamento();
            Situacao novaSituacao = BuscarProximaSituacao();

            if (atividadeEmAndamento.id > 0 && atividadeEmAndamento.Situacao == novaSituacao)
            {
                return false;
            }
            repositorio.AtualizarSituacao(id, (int)novaSituacao); ;
            return true;
        }
            

        public Atividade BuscarAtividadeEmAndamento()
        {
            return repositorio.BuscarAtividadeEmAndamento();
        }
        public List <Atividade> ListarAtividadesPendentes()
        {
            return repositorio.ListarAtividadesPendesntes();
        }
        private bool Validarid()
        {
            return id > 0;
        }

        private bool ValidarTitulo()
        {
            return !string.IsNullOrWhiteSpace(Titulo);
        }
        private bool ValidarSituacao()
        {
            return Situacao != Situacao.Concluido;
        }

        private Situacao BuscarProximaSituacao() 
        {
            /*if (Situacao == Situacao.Pendente)
            {
                return Situacao.Realizando;
            }

            return Situacao.Concluido;
            */
            return Situacao == Situacao.Pendente ? Situacao.Realizando : Situacao.Concluido;
            


        }

    }
}
