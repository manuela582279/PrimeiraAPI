namespace PrimeiraAPI.Models
{
    public class AlunoCursos
    {
        public Guid AlunoCursosId { get; set; }
        public Guid AlunoId { get; set; }
        public Aluno? Aluno { get; set; }

        public Guid CursosId { get; set; }
        public Cursos? Cursos { get; set; }
    }
}


