namespace EscolaNatacao
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label6 = new Label();
            listBoxAlunos = new ListBox();
            btnAlunoSalvar = new Button();
            dtpAlunoDataNascimento = new DateTimePicker();
            label5 = new Label();
            txtAlunoCPF = new MaskedTextBox();
            txtAlunoTelefone = new MaskedTextBox();
            label4 = new Label();
            label3 = new Label();
            txtAlunoEndereco = new TextBox();
            txtAlunoNome = new TextBox();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            label7 = new Label();
            listBoxProfessores = new ListBox();
            btnProfessorSalvar = new Button();
            dtpProfessorDataNascimento = new DateTimePicker();
            label8 = new Label();
            txtProfessorEndereco = new TextBox();
            txtProfessorNome = new TextBox();
            label9 = new Label();
            label10 = new Label();
            tabPage3 = new TabPage();
            label14 = new Label();
            listBoxAulas = new ListBox();
            btnAulaSalvar = new Button();
            label13 = new Label();
            nupAulaQuantidadeMaxima = new NumericUpDown();
            label12 = new Label();
            cmbAulaProfessor = new ComboBox();
            txtAulaNome = new TextBox();
            label11 = new Label();
            tabPage4 = new TabPage();
            label19 = new Label();
            dataGridViewMarcacoes = new DataGridView();
            btnMarcacaoAula = new Button();
            label18 = new Label();
            label17 = new Label();
            label16 = new Label();
            label15 = new Label();
            cmbMarcacaoAluno = new ComboBox();
            cmbMarcacaoAula = new ComboBox();
            txtMarcacaoHorario = new MaskedTextBox();
            dtpMarcacaoData = new DateTimePicker();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nupAulaQuantidadeMaxima).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMarcacoes).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1052, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(listBoxAlunos);
            tabPage1.Controls.Add(btnAlunoSalvar);
            tabPage1.Controls.Add(dtpAlunoDataNascimento);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(txtAlunoCPF);
            tabPage1.Controls.Add(txtAlunoTelefone);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtAlunoEndereco);
            tabPage1.Controls.Add(txtAlunoNome);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1044, 422);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cadastro Alunos";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(538, 19);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 12;
            label6.Text = "Alunos Cadastrados";
            // 
            // listBoxAlunos
            // 
            listBoxAlunos.DisplayMember = "Nome";
            listBoxAlunos.FormattingEnabled = true;
            listBoxAlunos.ItemHeight = 15;
            listBoxAlunos.Location = new Point(540, 40);
            listBoxAlunos.Name = "listBoxAlunos";
            listBoxAlunos.Size = new Size(280, 349);
            listBoxAlunos.TabIndex = 11;
            listBoxAlunos.SelectedIndexChanged += listBoxAlunos_SelectedIndexChanged;
            // 
            // btnAlunoSalvar
            // 
            btnAlunoSalvar.Location = new Point(33, 316);
            btnAlunoSalvar.Name = "btnAlunoSalvar";
            btnAlunoSalvar.Size = new Size(75, 23);
            btnAlunoSalvar.TabIndex = 10;
            btnAlunoSalvar.Text = "Salvar";
            btnAlunoSalvar.UseVisualStyleBackColor = true;
            btnAlunoSalvar.Click += btnAlunoSalvar_Click;
            // 
            // dtpAlunoDataNascimento
            // 
            dtpAlunoDataNascimento.Location = new Point(33, 268);
            dtpAlunoDataNascimento.Name = "dtpAlunoDataNascimento";
            dtpAlunoDataNascimento.Size = new Size(249, 23);
            dtpAlunoDataNascimento.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 250);
            label5.Name = "label5";
            label5.Size = new Size(114, 15);
            label5.TabIndex = 8;
            label5.Text = "Data de Nascimento";
            // 
            // txtAlunoCPF
            // 
            txtAlunoCPF.Location = new Point(33, 203);
            txtAlunoCPF.Mask = "000.000.000-00";
            txtAlunoCPF.Name = "txtAlunoCPF";
            txtAlunoCPF.Size = new Size(100, 23);
            txtAlunoCPF.TabIndex = 7;
            // 
            // txtAlunoTelefone
            // 
            txtAlunoTelefone.Location = new Point(33, 150);
            txtAlunoTelefone.Mask = "(99) 0000-0000";
            txtAlunoTelefone.Name = "txtAlunoTelefone";
            txtAlunoTelefone.Size = new Size(100, 23);
            txtAlunoTelefone.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(33, 185);
            label4.Name = "label4";
            label4.Size = new Size(28, 15);
            label4.TabIndex = 5;
            label4.Text = "CPF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 132);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 4;
            label3.Text = "Telefone";
            // 
            // txtAlunoEndereco
            // 
            txtAlunoEndereco.Location = new Point(33, 95);
            txtAlunoEndereco.Name = "txtAlunoEndereco";
            txtAlunoEndereco.Size = new Size(374, 23);
            txtAlunoEndereco.TabIndex = 3;
            // 
            // txtAlunoNome
            // 
            txtAlunoNome.Location = new Point(33, 40);
            txtAlunoNome.Name = "txtAlunoNome";
            txtAlunoNome.Size = new Size(200, 23);
            txtAlunoNome.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 77);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 1;
            label2.Text = "Endereço";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 19);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label7);
            tabPage2.Controls.Add(listBoxProfessores);
            tabPage2.Controls.Add(btnProfessorSalvar);
            tabPage2.Controls.Add(dtpProfessorDataNascimento);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(txtProfessorEndereco);
            tabPage2.Controls.Add(txtProfessorNome);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label10);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1044, 422);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cadastro de Professores";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(491, 26);
            label7.Name = "label7";
            label7.Size = new Size(112, 15);
            label7.TabIndex = 21;
            label7.Text = "Alunos Cadastrados";
            // 
            // listBoxProfessores
            // 
            listBoxProfessores.DisplayMember = "Nome";
            listBoxProfessores.FormattingEnabled = true;
            listBoxProfessores.ItemHeight = 15;
            listBoxProfessores.Location = new Point(493, 47);
            listBoxProfessores.Name = "listBoxProfessores";
            listBoxProfessores.Size = new Size(280, 349);
            listBoxProfessores.TabIndex = 20;
            listBoxProfessores.SelectedIndexChanged += listBoxProfessores_SelectedIndexChanged;
            // 
            // btnProfessorSalvar
            // 
            btnProfessorSalvar.Location = new Point(20, 207);
            btnProfessorSalvar.Name = "btnProfessorSalvar";
            btnProfessorSalvar.Size = new Size(75, 23);
            btnProfessorSalvar.TabIndex = 19;
            btnProfessorSalvar.Text = "Salvar";
            btnProfessorSalvar.UseVisualStyleBackColor = true;
            btnProfessorSalvar.Click += btnProfessorSalvar_Click;
            // 
            // dtpProfessorDataNascimento
            // 
            dtpProfessorDataNascimento.Location = new Point(20, 159);
            dtpProfessorDataNascimento.Name = "dtpProfessorDataNascimento";
            dtpProfessorDataNascimento.Size = new Size(249, 23);
            dtpProfessorDataNascimento.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 141);
            label8.Name = "label8";
            label8.Size = new Size(114, 15);
            label8.TabIndex = 17;
            label8.Text = "Data de Nascimento";
            // 
            // txtProfessorEndereco
            // 
            txtProfessorEndereco.Location = new Point(20, 102);
            txtProfessorEndereco.Name = "txtProfessorEndereco";
            txtProfessorEndereco.Size = new Size(374, 23);
            txtProfessorEndereco.TabIndex = 16;
            // 
            // txtProfessorNome
            // 
            txtProfessorNome.Location = new Point(20, 47);
            txtProfessorNome.Name = "txtProfessorNome";
            txtProfessorNome.Size = new Size(200, 23);
            txtProfessorNome.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(20, 84);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 14;
            label9.Text = "Endereço";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(20, 26);
            label10.Name = "label10";
            label10.Size = new Size(40, 15);
            label10.TabIndex = 13;
            label10.Text = "Nome";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label14);
            tabPage3.Controls.Add(listBoxAulas);
            tabPage3.Controls.Add(btnAulaSalvar);
            tabPage3.Controls.Add(label13);
            tabPage3.Controls.Add(nupAulaQuantidadeMaxima);
            tabPage3.Controls.Add(label12);
            tabPage3.Controls.Add(cmbAulaProfessor);
            tabPage3.Controls.Add(txtAulaNome);
            tabPage3.Controls.Add(label11);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(1044, 422);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Cadastro de Aulas";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(483, 37);
            label14.Name = "label14";
            label14.Size = new Size(103, 15);
            label14.TabIndex = 24;
            label14.Text = "Aulas Cadastradas";
            // 
            // listBoxAulas
            // 
            listBoxAulas.DisplayMember = "Nome";
            listBoxAulas.FormattingEnabled = true;
            listBoxAulas.ItemHeight = 15;
            listBoxAulas.Location = new Point(485, 58);
            listBoxAulas.Name = "listBoxAulas";
            listBoxAulas.Size = new Size(280, 349);
            listBoxAulas.TabIndex = 23;
            listBoxAulas.SelectedIndexChanged += listBoxAulas_SelectedIndexChanged;
            // 
            // btnAulaSalvar
            // 
            btnAulaSalvar.Location = new Point(27, 265);
            btnAulaSalvar.Name = "btnAulaSalvar";
            btnAulaSalvar.Size = new Size(75, 23);
            btnAulaSalvar.TabIndex = 22;
            btnAulaSalvar.Text = "Salvar";
            btnAulaSalvar.UseVisualStyleBackColor = true;
            btnAulaSalvar.Click += btnAulaSalvar_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(27, 192);
            label13.Name = "label13";
            label13.Size = new Size(115, 15);
            label13.TabIndex = 21;
            label13.Text = "Quantidade Máxima";
            // 
            // nupAulaQuantidadeMaxima
            // 
            nupAulaQuantidadeMaxima.Location = new Point(27, 210);
            nupAulaQuantidadeMaxima.Name = "nupAulaQuantidadeMaxima";
            nupAulaQuantidadeMaxima.Size = new Size(200, 23);
            nupAulaQuantidadeMaxima.TabIndex = 20;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(27, 114);
            label12.Name = "label12";
            label12.Size = new Size(56, 15);
            label12.TabIndex = 19;
            label12.Text = "Professor";
            // 
            // cmbAulaProfessor
            // 
            cmbAulaProfessor.DisplayMember = "Nome";
            cmbAulaProfessor.FormattingEnabled = true;
            cmbAulaProfessor.Location = new Point(27, 132);
            cmbAulaProfessor.Name = "cmbAulaProfessor";
            cmbAulaProfessor.Size = new Size(200, 23);
            cmbAulaProfessor.TabIndex = 18;
            // 
            // txtAulaNome
            // 
            txtAulaNome.Location = new Point(27, 58);
            txtAulaNome.Name = "txtAulaNome";
            txtAulaNome.Size = new Size(200, 23);
            txtAulaNome.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(27, 37);
            label11.Name = "label11";
            label11.Size = new Size(40, 15);
            label11.TabIndex = 16;
            label11.Text = "Nome";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label19);
            tabPage4.Controls.Add(dataGridViewMarcacoes);
            tabPage4.Controls.Add(btnMarcacaoAula);
            tabPage4.Controls.Add(label18);
            tabPage4.Controls.Add(label17);
            tabPage4.Controls.Add(label16);
            tabPage4.Controls.Add(label15);
            tabPage4.Controls.Add(cmbMarcacaoAluno);
            tabPage4.Controls.Add(cmbMarcacaoAula);
            tabPage4.Controls.Add(txtMarcacaoHorario);
            tabPage4.Controls.Add(dtpMarcacaoData);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(1044, 422);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Marcação de Aula";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(344, 26);
            label19.Name = "label19";
            label19.Size = new Size(64, 15);
            label19.TabIndex = 10;
            label19.Text = "Marcações";
            // 
            // dataGridViewMarcacoes
            // 
            dataGridViewMarcacoes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMarcacoes.Location = new Point(344, 44);
            dataGridViewMarcacoes.Name = "dataGridViewMarcacoes";
            dataGridViewMarcacoes.RowTemplate.Height = 25;
            dataGridViewMarcacoes.Size = new Size(675, 334);
            dataGridViewMarcacoes.TabIndex = 9;
            // 
            // btnMarcacaoAula
            // 
            btnMarcacaoAula.Location = new Point(24, 265);
            btnMarcacaoAula.Name = "btnMarcacaoAula";
            btnMarcacaoAula.Size = new Size(75, 23);
            btnMarcacaoAula.TabIndex = 8;
            btnMarcacaoAula.Text = "Marcar";
            btnMarcacaoAula.UseVisualStyleBackColor = true;
            btnMarcacaoAula.Click += btnMarcacaoAula_Click;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(24, 201);
            label18.Name = "label18";
            label18.Size = new Size(39, 15);
            label18.TabIndex = 7;
            label18.Text = "Aluno";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(24, 143);
            label17.Name = "label17";
            label17.Size = new Size(31, 15);
            label17.TabIndex = 6;
            label17.Text = "Aula";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(24, 87);
            label16.Name = "label16";
            label16.Size = new Size(47, 15);
            label16.TabIndex = 5;
            label16.Text = "Horário";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(24, 22);
            label15.Name = "label15";
            label15.Size = new Size(31, 15);
            label15.TabIndex = 4;
            label15.Text = "Data";
            // 
            // cmbMarcacaoAluno
            // 
            cmbMarcacaoAluno.DisplayMember = "Nome";
            cmbMarcacaoAluno.FormattingEnabled = true;
            cmbMarcacaoAluno.Location = new Point(24, 219);
            cmbMarcacaoAluno.Name = "cmbMarcacaoAluno";
            cmbMarcacaoAluno.Size = new Size(187, 23);
            cmbMarcacaoAluno.TabIndex = 3;
            // 
            // cmbMarcacaoAula
            // 
            cmbMarcacaoAula.DisplayMember = "Nome";
            cmbMarcacaoAula.FormattingEnabled = true;
            cmbMarcacaoAula.Location = new Point(24, 161);
            cmbMarcacaoAula.Name = "cmbMarcacaoAula";
            cmbMarcacaoAula.Size = new Size(191, 23);
            cmbMarcacaoAula.TabIndex = 2;
            // 
            // txtMarcacaoHorario
            // 
            txtMarcacaoHorario.Location = new Point(24, 105);
            txtMarcacaoHorario.Mask = "00:00";
            txtMarcacaoHorario.Name = "txtMarcacaoHorario";
            txtMarcacaoHorario.Size = new Size(100, 23);
            txtMarcacaoHorario.TabIndex = 1;
            txtMarcacaoHorario.ValidatingType = typeof(DateTime);
            // 
            // dtpMarcacaoData
            // 
            dtpMarcacaoData.Location = new Point(24, 44);
            dtpMarcacaoData.Name = "dtpMarcacaoData";
            dtpMarcacaoData.Size = new Size(200, 23);
            dtpMarcacaoData.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Marcação de aulas";
            Load += Form1_Load;
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nupAulaQuantidadeMaxima).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMarcacoes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TextBox txtAlunoEndereco;
        private TextBox txtAlunoNome;
        private Label label2;
        private Label label1;
        private MaskedTextBox txtAlunoCPF;
        private MaskedTextBox txtAlunoTelefone;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpAlunoDataNascimento;
        private Label label5;
        private Button btnAlunoSalvar;
        private Label label6;
        private ListBox listBoxAlunos;
        private Label label7;
        private ListBox listBoxProfessores;
        private Button btnProfessorSalvar;
        private DateTimePicker dtpProfessorDataNascimento;
        private Label label8;
        private TextBox txtProfessorEndereco;
        private TextBox txtProfessorNome;
        private Label label9;
        private Label label10;
        private Label label13;
        private NumericUpDown nupAulaQuantidadeMaxima;
        private Label label12;
        private ComboBox cmbAulaProfessor;
        private TextBox txtAulaNome;
        private Label label11;
        private Label label14;
        private ListBox listBoxAulas;
        private Button btnAulaSalvar;
        private DateTimePicker dtpMarcacaoData;
        private MaskedTextBox txtMarcacaoHorario;
        private Button btnMarcacaoAula;
        private Label label18;
        private Label label17;
        private Label label16;
        private Label label15;
        private ComboBox cmbMarcacaoAluno;
        private ComboBox cmbMarcacaoAula;
        private DataGridView dataGridViewMarcacoes;
        private Label label19;
    }
}