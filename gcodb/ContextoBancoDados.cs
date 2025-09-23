using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace gcodb
{
    public class ContextoBancoDados : DbContext
    {
        private readonly IConfiguration _configuration;

        public ContextoBancoDados()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables();

            _configuration = builder.Build();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            //Usando a string de conexão via appsettings.json
            optionsBuilder
                //.UseNpgsql(configuration.GetConnectionString("DefaultConnection"));
                .UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));


            //EVITAR: Versão usando o PostgreSQL e a string de conexão hardcoded
            //optionsBuilder
            //.UseNpgsql("User ID=postgres;Password=SENHABANCODADOS;Host=localhost;Port=5432;Database=NOMEBANCODEDADOS;");
            //.UseSqlServer("Server=SERVIDOR-SQL-SERVER;Database=BANCO-DE-DADOS;User Id=USUARIO;Password=SENHA;TrustServerCertificate=true");
        }
    }
}