using APIFilme___Aprendendo.Models;
using Microsoft.EntityFrameworkCore;

namespace APIFilme___Aprendendo.Infraestrutura
{
    public class ConexãoSQL: DbContext
    {
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
             =>
              optionBuilder.UseSqlServer("Data Source=PC03LAB2040\\SENAI;Initial Catalog=DBFilme;User ID=sa;Password=senai.123");

        public DbSet<Filme> Filme { get; set; }
    }


}
