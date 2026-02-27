namespace PrimeiraAPI.Models
{
    public class DisciplinaCurso
    {
        public Guid DisciplinaCursoId { get; set; }
        public Guid CursosId { get; set; }
        public Guid DisciplinaId { get; set; }
        //propriedades de navegação
        public Cursos Curso { get; set; }
        public Disciplina Disciplina { get; set; }
        public ICollection<Disciplina> Disciplinas { get; set; } = new List<Disciplina>();
    }
}
