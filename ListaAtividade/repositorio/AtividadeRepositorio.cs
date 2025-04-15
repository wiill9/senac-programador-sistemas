using ListaAtividade.atividade;
using ListaAtividade.bando_de_dados;
using MySqlConnector;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;

namespace ListaAtividade.repositorio
{
    internal class AtividadeRepositorio
    {
        public void Criar(string titulo)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "insert into atividade (titulo) values (@titulo);";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@titulo", titulo);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        public void AtualizarSituacao(int id, int novaSituacao)
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = "update atividade set situacao = @situacao where  id = @id;";

                using (var cmd = new MySqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@situacao", novaSituacao);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

            }
        }

        public Atividade BuscarAtividadeEmAndamento()
        {
            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = $"SELECT * FROM atividade WHERE situacao = 1{Situacao.Realizando};";

                using (var cmd = new MySqlCommand(query, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Atividade()
                            {
                                id = reader.GetInt32("id"),
                                Titulo = reader.GetString("titulo"),
                                Situacao = (Situacao)reader.GetInt32("situacao")
                            };
                        }
                        return new Atividade();
                    }
                }
            }
        }
        public List<Atividade> ListarAtividadesPendesntes()
        {
            List<Atividade> atividades = [];

            using (var con = DataBase.GetConnection())
            {
                con.Open();

                string query = $"SELECT * FROM atividade WHERE situacao = 0{Situacao.Pendente};";

                using (var cmd = new MySqlCommand(query, con))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            atividades.Add(new Atividade()
                            {
                                id = reader.GetInt32("id"),
                                Titulo = reader.GetString("Titulo"),
                                Situacao = (Situacao)reader.GetInt32("Situacao")
                            });
                        }
                    }
                }
            }
            return atividades;
        }

    }
  
}

    
  




