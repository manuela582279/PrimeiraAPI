using System.ComponentModel.DataAnnotations;

namespace PrimeiraAPI.Models
{
    public class Cursos
    {
        public Guid CursosId { get; set; }
        public string Nome { get; set; }
        public int Semestres { get; set; }
        public bool? Ativo { get; set; }
        [DataType(DataType.Currency)]
        public decimal Mensalidade { get; set; }

        //propriedade de navegação para a relação N:M com Curso
        public ICollection<Disciplina> Disciplinas { get; set; } = new List<Disciplina>();


    }
}
