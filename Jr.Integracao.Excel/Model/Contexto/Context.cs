using Jr.Integracao.Excel.Model.Base;
using Microsoft.EntityFrameworkCore;

namespace Jr.Integracao.Excel.Model.Contexto
{
    public class Context : DbContext
    {
        public DbSet<Producao> Producoes { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            //Colocar instancia do postgree sql
            var builder = new DbContextOptionsBuilder<Context>();
            builder.UseNpgsql("Server=localhost;Port=5432;Database=teste;User Id=postgres;Password=Origem@2022;");

            var options = builder.Options;
            using var context = new Context(options);





        }



    



    }
