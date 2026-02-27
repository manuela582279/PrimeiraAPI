namespace PrimeiraAPI.Models
{
    public class Disciplina
    {
        public Guid DisciplinaId { get; set; }
        public string Nome { get; set; }
        public int CargaHoraria { get; set; }
        public int? Semestre { get; set; }
        public ICollection<Cursos> Curso { get; set; } = new List<Cursos>();
        

    }
}
