using API_Funcionarios.Models;
using Microsoft.EntityFrameworkCore;

namespace API_Funcionarios.Model
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }

        public DbSet<Funcionario> Funcionarios { get; set; }

    }
}
