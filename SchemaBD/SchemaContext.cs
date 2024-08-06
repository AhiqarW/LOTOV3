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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DescriptionGenerale>().HasData(new DescriptionGenerale
            {
                NoFicheCadenassage = Guid.NewGuid(),
                NoFicheCadenassageUtilisation = Guid.NewGuid(),
                SocieteId = Guid.NewGuid(),
                NoFicheCadenassageInterne = "COIL VA1-002-9.424-MB",
                NomEquipement = "Transformateur Portable T-810-EXPLO-6-1 Station électrique ST-810-113-01",
                NoEquipement = "6131CHU13, 315-CH-012",
                NoLocalisation = 3,
                LocalisationAutreSpecifierFr = "Niveau Plateforme, Quai Central (00-210)",
                NoDepartement = 1,
                NoEmplacementEquipement = 5,
                EmplacementEquipementAutreSpecifierFr = "ST-370-124/22-01 (Sous-Station électrique 5kV)",
                InformationsSupplementairesFr = "<p style=\"background-....",
                Photo = "../images/transformateur-portal.jpeg",
                DateCreation = DateTime.Now.AddDays(-5).AddHours(-3),
                DateModification = DateTime.Now.AddDays(-2).AddHours(-1),
                DescriptionLocalisationFr = "1500 - Salle des pompes (avec réservoir) fr",
                DescriptionLocalisationEn = "1500 - Salle des pompes (avec réservoir) en",
                DescriptionDepartementFr = "105 ECU - Salle de P-11-12-13-16-17-18-19 & compresseur. fr",
                DescriptionDepartementEn = "105 ECU - Salle de P-11-12-13-16-17-18-19 & compresseur. en",
                DescriptionEmplacementEquipementFr = "Salle entreposage équipements # 3 P169 fr",
                DescriptionEmplacementEquipementEn = "Salle entreposage équipements # 3 P169 en",
                DateUtilisation = DateTime.Now,
                UsagerDescriptionGeneraleRemarques = "ecriture ici"
            });
        }

    }
}
