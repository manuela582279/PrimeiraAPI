using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using PrimeiraAPI.Models;

namespace PrimeiraAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        // DbSet => Representa uma coleção de entidades do tipo especificado, permitindo realizar operações de consulta e manipulação de dados.
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Cursos> Cursos { get; set; }
        public DbSet<AlunoCursos> AlunosCursos { get; set; }


    }
}
