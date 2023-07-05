namespace EscolaNatacao
{
    public partial class Form1 : Form
    {
        List<Aluno> alunos = new List<Aluno>();
        List<Professor> professores = new List<Professor>();
        List<Aula> aulas = new List<Aula>();
        List<MarcacaoAula> marcacoes = new List<MarcacaoAula>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAlunoSalvar_Click(object sender, EventArgs e)
        {
            Aluno aluno = new Aluno();
            aluno.Nome = txtAlunoNome.Text;
            aluno.DataNascimento = dtpAlunoDataNascimento.Value;
            aluno.Telefone = txtAlunoTelefone.Text;
            aluno.Documento = txtAlunoCPF.Text;
            aluno.Endereco = txtAlunoEndereco.Text;

            alunos.Add(aluno);

            listBoxAlunos.Items.Add(aluno);
            cmbMarcacaoAluno.Items.Add(aluno);
        }

        private void listBoxAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aluno alunoSelecionado = listBoxAlunos.SelectedItem as Aluno;

            txtAlunoNome.Text = alunoSelecionado.Nome;
            dtpAlunoDataNascimento.Value = alunoSelecionado.DataNascimento;
            txtAlunoTelefone.Text = alunoSelecionado.Telefone;
            txtAlunoCPF.Text = alunoSelecionado.Documento;
            txtAlunoEndereco.Text = alunoSelecionado.Endereco;
        }

        public void MockupAlunos()
        {
            Aluno aluno = new Aluno();
            aluno.Nome = "João";
            aluno.DataNascimento = new DateTime(2005, 01, 01);
            aluno.Telefone = "(64)9999-9999";
            aluno.Documento = "000.000.000-00";
            aluno.Endereco = "Rua de teste 01";

            alunos.Add(aluno);
            listBoxAlunos.Items.Add(aluno);
            cmbMarcacaoAluno.Items.Add(aluno);

            aluno = new Aluno();
            aluno.Nome = "Maria";
            aluno.DataNascimento = new DateTime(2002, 02, 02);
            aluno.Telefone = "(64)8888-8888";
            aluno.Documento = "111.111.111-11";
            aluno.Endereco = "Rua de teste 02";

            alunos.Add(aluno);
            listBoxAlunos.Items.Add(aluno);
            cmbMarcacaoAluno.Items.Add(aluno);

            aluno = new Aluno();
            aluno.Nome = "Tiaga";
            aluno.DataNascimento = new DateTime(2003, 03, 03);
            aluno.Telefone = "(64)7777-7777";
            aluno.Documento = "222.222.222-22";
            aluno.Endereco = "Rua de teste 03";

            alunos.Add(aluno);
            listBoxAlunos.Items.Add(aluno);
            cmbMarcacaoAluno.Items.Add(aluno);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MockupAlunos();
            MockupProfessor();
            MockupAulas();
        }

        private void btnProfessorSalvar_Click(object sender, EventArgs e)
        {
            Professor professor = new Professor();
            professor.Nome = txtProfessorNome.Text;
            professor.DataNascimento = dtpProfessorDataNascimento.Value;
            professor.Endereco = txtProfessorEndereco.Text;

            professores.Add(professor);

            listBoxProfessores.Items.Add(professor);

            cmbAulaProfessor.Items.Add(professor);
        }

        public void MockupProfessor()
        {
            Professor professor = new Professor();
            professor.Nome = "Douglas";
            professor.DataNascimento = new DateTime(2000, 01, 01);
            professor.Endereco = "Rua de teste professor 01";

            professores.Add(professor);
            listBoxProfessores.Items.Add(professor);
            cmbAulaProfessor.Items.Add(professor);

            professor = new Professor();
            professor.Nome = "Janaina";
            professor.DataNascimento = new DateTime(2000, 02, 02);
            professor.Endereco = "Rua de teste professor 02";

            professores.Add(professor);
            listBoxProfessores.Items.Add(professor);
            cmbAulaProfessor.Items.Add(professor);

            professor = new Professor();
            professor.Nome = "Laisa";
            professor.DataNascimento = new DateTime(2000, 03, 03);
            professor.Endereco = "Rua de teste professor 03";

            professores.Add(professor);
            listBoxProfessores.Items.Add(professor);
            cmbAulaProfessor.Items.Add(professor);

        }

        private void listBoxProfessores_SelectedIndexChanged(object sender, EventArgs e)
        {
            Professor professorSelecionado = listBoxProfessores.SelectedItem as Professor;

            txtProfessorEndereco.Text = professorSelecionado.Endereco;
            txtProfessorNome.Text = professorSelecionado.Nome;
            dtpProfessorDataNascimento.Value = professorSelecionado.DataNascimento;
        }

        private void btnAulaSalvar_Click(object sender, EventArgs e)
        {
            Aula aula = new Aula();

            aula.Nome = txtAulaNome.Text;
            aula.ProfessorAula = cmbAulaProfessor.SelectedItem as Professor;
            aula.QuantidadeMaxima = Convert.ToInt32(nupAulaQuantidadeMaxima.Value);

            aulas.Add(aula);
            listBoxAulas.Items.Add(aula);
            cmbMarcacaoAula.Items.Add(aula);
        }

        private void listBoxAulas_SelectedIndexChanged(object sender, EventArgs e)
        {
            Aula aulaSelecionada = listBoxAulas.SelectedItem as Aula;
            txtAulaNome.Text = aulaSelecionada.Nome;
            nupAulaQuantidadeMaxima.Value = aulaSelecionada.QuantidadeMaxima;
            cmbAulaProfessor.SelectedItem = aulaSelecionada.ProfessorAula;

        }

        public void MockupAulas()
        {
            Aula aula = new Aula();
            aula.Nome = "Aula melhor idade";
            aula.QuantidadeMaxima = 2;
            //Pega o primeiro professor da lista
            aula.ProfessorAula = professores.First();
            aulas.Add(aula);
            listBoxAulas.Items.Add(aula);
            cmbMarcacaoAula.Items.Add(aula);

            aula = new Aula();
            aula.Nome = "Aula 2 a 6 anos";
            aula.QuantidadeMaxima = 5;
            //Pega o último professor da lista
            aula.ProfessorAula = professores.Last();
            aulas.Add(aula);
            listBoxAulas.Items.Add(aula);
            cmbMarcacaoAula.Items.Add(aula);

            aula = new Aula();
            aula.Nome = "Aula Teens";
            aula.QuantidadeMaxima = 5;
            //Pega o primeiro professor da lista pulando 1
            aula.ProfessorAula = professores.Skip(1).FirstOrDefault();
            aulas.Add(aula);
            listBoxAulas.Items.Add(aula);
            cmbMarcacaoAula.Items.Add(aula);
        }

        private void btnMarcacaoAula_Click(object sender, EventArgs e)
        {
            Aula aulaMarcacao = cmbMarcacaoAula.SelectedItem as Aula;
            Aluno alunoMarcacao = cmbMarcacaoAluno.SelectedItem as Aluno;

            MarcacaoAula marcacao = new MarcacaoAula();
            marcacao.DataAula = dtpMarcacaoData.Value.Date;
            marcacao.Horario = txtMarcacaoHorario.Text;
            marcacao.AulaMarcacao = aulaMarcacao;
            marcacao.AlunoMarcacao = alunoMarcacao;

            //Pesquisar aulas marcadas da mesma aula, data e horário
            var aulasMarcadas = marcacoes.Where(m => m.AulaMarcacao.Nome == aulaMarcacao.Nome
                                                && m.DataAula == marcacao.DataAula
                                                && m.Horario == marcacao.Horario);

            //Se retornou que existe uma ou mais aulas marcadas com as mesmas características
            //E a quantidade máxima dessa aula é igual a quantidade já marcada
            if (aulasMarcadas.Any() &&
                marcacao.AulaMarcacao.QuantidadeMaxima == aulasMarcadas.Count())
            {
                MessageBox.Show("A aula já está com sua capacidade máxima",
                    "Capacidade excedida",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                marcacoes.Add(marcacao);

                PreencheDataGridView();

                string mensagem = "A aula foi marcada com sucesso." +
                "\nAula: " + marcacao.AulaMarcacao.Nome +
                "\nAluno: " + marcacao.AlunoMarcacao.Nome +
                "\nData: " + marcacao.DataAula.ToShortDateString() +
                "\nHorário: " + marcacao.Horario;

                MessageBox.Show(mensagem);
            }
        }

        public void PreencheDataGridView()
        {
            List<MarcacoesExibicao> marcacoesExibicao = new List<MarcacoesExibicao>();
            //Passo por todas as marcações
            foreach (MarcacaoAula marcacao in marcacoes)
            {
                MarcacoesExibicao exibicao = new MarcacoesExibicao();
                exibicao.Aula = marcacao.AulaMarcacao.Nome;
                exibicao.Aluno = marcacao.AlunoMarcacao.Nome;
                exibicao.Professor = marcacao.AulaMarcacao.ProfessorAula.Nome;
                exibicao.Data = marcacao.DataAula.ToShortDateString();
                exibicao.Horario = marcacao.Horario;

                marcacoesExibicao.Add(exibicao);
            }

            dataGridViewMarcacoes.DataSource = marcacoesExibicao;
        }
    }
}