using ListaAtividade.atividade;

namespace ListaAtividade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ListaAtividades_Load(object sender, EventArgs e)
        {
            labelErro.Text = string.Empty;

            CarregaratividadeEmAndamento();
            CarregarListaAtividades();

        }
        private void buttonfinalizar_Click(object sender, EventArgs e)
        {
            if (atividadeEmAndamento == null || atividadeEmAndamento.id <= 0)
            {
                labelErro.Text = "Não Há atividade no andamento";
                return;
            }

            if (!atividadeEmAndamento.AtualizarSituacao())
            {
                labelErro.Text = "Não foi possivel finalizar ativadade";
                return;
            }

            labelErro.Text = string.Empty;
            CarregaratividadeEmAndamento();

        }

        private void buttonatualizar_Click(object sender, EventArgs e)
        {
            if (dataGridViewatividades.SelectedRows.Count <= 0)
            {
                labelErro.Text = "Selecione uma atividade";
                return;
            }

            var linhaSelecionada = dataGridViewatividades.SelectedRows[0];

            Atividade atividade = new()
            {
                id = (int)linhaSelecionada.Cells[0].Value,
                Titulo = (String)linhaSelecionada.Cells[1].Value,
                Situacao = (Situacao)linhaSelecionada.Cells[2].Value,
            };




        }

        private void buttoncriar_Click(object sender, EventArgs e)
        {

        }
    }
