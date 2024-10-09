using Microsoft.EntityFrameworkCore;

namespace gcodb
{
    public class ContextoBancoDados : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder
                .UseNpgsql("User ID=postgres;Password=SENHABANCODADOS;Host=localhost;Port=5432;Database=NOMEBANCODEDADOS;");
                //.UseSqlServer("Server=localhost;Database=Teste;User Id=sa;Password=Senha;TrustServerCertificate=true");
        }
    }
}