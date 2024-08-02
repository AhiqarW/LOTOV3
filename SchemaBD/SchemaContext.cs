using FichesLoto.Shared.Domain;
using Microsoft.EntityFrameworkCore;

namespace SchemaBD
{
    public class SchemaContext: DbContext
    {
        public DbSet<DescriptionGenerale> DescriptionGenerales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = SignalRDatabase");
        }

    }
}
