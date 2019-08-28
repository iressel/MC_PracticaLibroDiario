using Microsoft.EntityFrameworkCore;
using PracticaLibroDiarioTemplate.Models.BusinessModel;

namespace PracticaLibroDiarioTemplate.Models.Contexts
{
    // Hay 3 schemas de diseño de base de datos.
    // Code First: Es crear codigo C# que se transforma en BD. Update-Database. Esto crea Versionamiento en la bd.
    // Model First: Existia un diseñador .edmx era recomendado para gente con poco conocimiento c# y poco conocimiento sql
    // Database First: Crea tu BD , y esto te va a generar el codigo C# con las clases.



    public class LibroDiarioContext : DbContext
    {
        public LibroDiarioContext(DbContextOptionsBuilder optionsBuilder)
        {
            OnConfiguring(optionsBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlite("Data Source=blogging.db");
            //optionsBuilder.UseInMemoryDatabase(databaseName: "LibrosContables");
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFProviders.InMemory;Trusted_Connection=True;ConnectRetryCount=0");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<AsientoLibroMayor> LibroMayor { get; set; }
        public DbSet<AsientoLibroDiario> LibroDiario { get; set; }
    }
}
