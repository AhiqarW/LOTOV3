using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchemaBD.Migrations
{
    /// <inheritdoc />
    public partial class initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DescriptionGenerales",
                columns: table => new
                {
                    NoFicheCadenassage = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoFicheCadenassageUtilisation = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SocieteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    NoFicheCadenassageInterne = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NomEquipement = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NoEquipement = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    NoLocalisation = table.Column<int>(type: "int", nullable: true),
                    LocalisationAutreSpecifierFr = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    LocalisationAutreSpecifierEn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    NoDepartement = table.Column<int>(type: "int", nullable: true),
                    NoEmplacementEquipement = table.Column<int>(type: "int", nullable: true),
                    EmplacementEquipementAutreSpecifierFr = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    EmplacementEquipementAutreSpecifierEn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    InformationsSupplementairesFr = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    InformationsSupplementairesEn = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Photo = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DateUtilisation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateModification = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DescriptionLocalisationFr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DescriptionLocalisationEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DescriptionDepartementFr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DescriptionDepartementEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DescriptionEmplacementEquipementFr = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DescriptionEmplacementEquipementEn = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    UsagerDescriptionGeneraleRemarques = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    UsagerRemarquesGenerales = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    UsagerRemarquesGeneralesFait = table.Column<bool>(type: "bit", nullable: false),
                    UsagerDateHeure = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DescriptionGenerales", x => x.NoFicheCadenassage);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DescriptionGenerales");
        }
    }
}
