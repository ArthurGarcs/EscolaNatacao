namespace EscolaNatacao
{
    public class MarcacaoAula
    {
        public DateTime DataAula { get; set; }
        public string Horario { get; set; }
        public Aula AulaMarcacao { get; set; }
        public Aluno AlunoMarcacao { get; set; }
    }
}
