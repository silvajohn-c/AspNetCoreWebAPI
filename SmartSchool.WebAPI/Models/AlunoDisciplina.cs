namespace SmartSchool.WebAPI.Models
{
    public class AlunoDisciplina
    {
        public AlunoDisciplina() { }
        public AlunoDisciplina(int alunoId, int disciplinaId)
        {
            this.AlunoId = alunoId;
            this.DisciplinaId = disciplinaId;

        }
        public Aluno Aluno { get; set; }
        public int AlunoId { get; set; }
        public Disciplina Disciplina { get; set; }
        public int DisciplinaId { get; set; }
    }
}