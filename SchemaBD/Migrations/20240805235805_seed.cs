using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchemaBD.Migrations
{
    /// <inheritdoc />
    public partial class seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DescriptionGenerales",
                keyColumn: "NoFicheCadenassage",
                keyValue: new Guid("d2bf7009-0c38-41c0-a0d8-15ff04c0eb2c"));

            migrationBuilder.InsertData(
                table: "DescriptionGenerales",
                columns: new[] { "NoFicheCadenassage", "DateCreation", "DateModification", "DateUtilisation", "DescriptionDepartementEn", "DescriptionDepartementFr", "DescriptionEmplacementEquipementEn", "DescriptionEmplacementEquipementFr", "DescriptionLocalisationEn", "DescriptionLocalisationFr", "EmplacementEquipementAutreSpecifierEn", "EmplacementEquipementAutreSpecifierFr", "InformationsSupplementairesEn", "InformationsSupplementairesFr", "LocalisationAutreSpecifierEn", "LocalisationAutreSpecifierFr", "NoDepartement", "NoEmplacementEquipement", "NoEquipement", "NoFicheCadenassageInterne", "NoFicheCadenassageUtilisation", "NoLocalisation", "NomEquipement", "Photo", "SocieteId", "UsagerDateHeure", "UsagerDescriptionGeneraleRemarques", "UsagerRemarquesGenerales", "UsagerRemarquesGeneralesFait" },
                values: new object[] { new Guid("0fed2105-fda4-4f3d-ac16-16a752f0ebcf"), new DateTime(2024, 7, 31, 16, 58, 4, 22, DateTimeKind.Local).AddTicks(4308), new DateTime(2024, 8, 3, 18, 58, 4, 22, DateTimeKind.Local).AddTicks(4360), new DateTime(2024, 8, 5, 19, 58, 4, 22, DateTimeKind.Local).AddTicks(4363), "105 ECU - Salle de P-11-12-13-16-17-18-19 & compresseur. en", "105 ECU - Salle de P-11-12-13-16-17-18-19 & compresseur. fr", "Salle entreposage équipements # 3 P169 en", "Salle entreposage équipements # 3 P169 fr", "1500 - Salle des pompes (avec réservoir) en", "1500 - Salle des pompes (avec réservoir) fr", null, "ST-370-124/22-01 (Sous-Station électrique 5kV)", null, "<p style=\"background-....", null, "Niveau Plateforme, Quai Central (00-210)", 1, 5, "6131CHU13, 315-CH-012", "COIL VA1-002-9.424-MB", new Guid("4487ae0c-755e-4528-a5b2-603c0076243d"), 3, "Transformateur Portable T-810-EXPLO-6-1 Station électrique ST-810-113-01", "../images/transformateur-portal.jpeg", new Guid("6667c14a-d160-4e9b-9872-e64af24dfaec"), null, "ecriture ici", null, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DescriptionGenerales",
                keyColumn: "NoFicheCadenassage",
                keyValue: new Guid("0fed2105-fda4-4f3d-ac16-16a752f0ebcf"));

            migrationBuilder.InsertData(
                table: "DescriptionGenerales",
                columns: new[] { "NoFicheCadenassage", "DateCreation", "DateModification", "DateUtilisation", "DescriptionDepartementEn", "DescriptionDepartementFr", "DescriptionEmplacementEquipementEn", "DescriptionEmplacementEquipementFr", "DescriptionLocalisationEn", "DescriptionLocalisationFr", "EmplacementEquipementAutreSpecifierEn", "EmplacementEquipementAutreSpecifierFr", "InformationsSupplementairesEn", "InformationsSupplementairesFr", "LocalisationAutreSpecifierEn", "LocalisationAutreSpecifierFr", "NoDepartement", "NoEmplacementEquipement", "NoEquipement", "NoFicheCadenassageInterne", "NoFicheCadenassageUtilisation", "NoLocalisation", "NomEquipement", "Photo", "SocieteId", "UsagerDateHeure", "UsagerDescriptionGeneraleRemarques", "UsagerRemarquesGenerales", "UsagerRemarquesGeneralesFait" },
                values: new object[] { new Guid("d2bf7009-0c38-41c0-a0d8-15ff04c0eb2c"), new DateTime(2024, 7, 31, 16, 53, 39, 737, DateTimeKind.Local).AddTicks(7667), new DateTime(2024, 8, 3, 18, 53, 39, 737, DateTimeKind.Local).AddTicks(7720), new DateTime(2024, 8, 5, 19, 53, 39, 737, DateTimeKind.Local).AddTicks(7723), "105 ECU - Salle de P-11-12-13-16-17-18-19 & compresseur. en", "105 ECU - Salle de P-11-12-13-16-17-18-19 & compresseur. fr", "Salle entreposage équipements # 3 P169 en", "Salle entreposage équipements # 3 P169 fr", "1500 - Salle des pompes (avec réservoir) en", "1500 - Salle des pompes (avec réservoir) fr", null, "ST-370-124/22-01 (Sous-Station électrique 5kV)", null, "<p style=\"background-....", null, "Niveau Plateforme, Quai Central (00-210)", 1, 5, "6131CHU13, 315-CH-012", "COIL VA1-002-9.424-MB", new Guid("5f58e203-bc90-4783-9310-e312b0235051"), 3, "Transformateur Portable T-810-EXPLO-6-1 Station électrique ST-810-113-01", "../images/transformateur-portal.jpeg", new Guid("ce95a929-4b30-4bce-8030-83ba940c9005"), null, "ecriture ici", null, false });
        }
    }
}
