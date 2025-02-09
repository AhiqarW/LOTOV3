﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SchemaBD;

#nullable disable

namespace SchemaBD.Migrations
{
    [DbContext(typeof(SchemaContext))]
    [Migration("20240805225500_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FichesLoto.Shared.Domain.DescriptionGenerale", b =>
                {
                    b.Property<Guid>("NoFicheCadenassage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateModification")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DateUtilisation")
                        .HasColumnType("datetime2");

                    b.Property<string>("DescriptionDepartementEn")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DescriptionDepartementFr")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DescriptionEmplacementEquipementEn")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DescriptionEmplacementEquipementFr")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DescriptionLocalisationEn")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("DescriptionLocalisationFr")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("EmplacementEquipementAutreSpecifierEn")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("EmplacementEquipementAutreSpecifierFr")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("InformationsSupplementairesEn")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("InformationsSupplementairesFr")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LocalisationAutreSpecifierEn")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("LocalisationAutreSpecifierFr")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int?>("NoDepartement")
                        .HasColumnType("int");

                    b.Property<int?>("NoEmplacementEquipement")
                        .HasColumnType("int");

                    b.Property<string>("NoEquipement")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("NoFicheCadenassageInterne")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<Guid>("NoFicheCadenassageUtilisation")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int?>("NoLocalisation")
                        .HasColumnType("int");

                    b.Property<string>("NomEquipement")
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Photo")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("SocieteId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("UsagerDateHeure")
                        .HasColumnType("datetime2");

                    b.Property<string>("UsagerDescriptionGeneraleRemarques")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<string>("UsagerRemarquesGenerales")
                        .HasMaxLength(2000)
                        .HasColumnType("nvarchar(2000)");

                    b.Property<bool>("UsagerRemarquesGeneralesFait")
                        .HasColumnType("bit");

                    b.HasKey("NoFicheCadenassage");

                    b.ToTable("DescriptionGenerales");
                });
#pragma warning restore 612, 618
        }
    }
}
