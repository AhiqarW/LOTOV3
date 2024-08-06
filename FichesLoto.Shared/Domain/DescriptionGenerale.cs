using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichesLoto.Shared.Domain
{
    public class DescriptionGenerale
    {
        [Key]
        public Guid  NoFicheCadenassage { get; set; }

        public Guid NoFicheCadenassageUtilisation { get; set; }
        
        public Guid  SocieteId { get; set; }

        [StringLength(50)]
        public string?  NoFicheCadenassageInterne { get; set; }

        [StringLength(200)]
        public string?  NomEquipement { get; set; }

        [StringLength(150)]
        public string?  NoEquipement { get; set; }

        public int?  NoLocalisation { get; set; }

        [StringLength(200)]
        public string?  LocalisationAutreSpecifierFr { get; set; }

        [StringLength(200)]
        public string? LocalisationAutreSpecifierEn { get; set; }

        public int?  NoDepartement { get; set; }

        public int?  NoEmplacementEquipement { get; set; }

        [StringLength(200)]
        public string?  EmplacementEquipementAutreSpecifierFr { get; set; }

        [StringLength(200)]
        public string? EmplacementEquipementAutreSpecifierEn { get; set; }

        [StringLength(200)]
        public string?  InformationsSupplementairesFr { get; set; }

        [StringLength(200)]
        public string? InformationsSupplementairesEn { get; set; }

        [StringLength(100)]
        public string?  Photo { get; set; }

        public DateTime? DateUtilisation { get; set; }

        public DateTime?  DateCreation { get; set; }
        public DateTime?  DateModification { get; set; }

        // Valeur tlkp
        [StringLength(100)]
        public string?  DescriptionLocalisationFr { get; set; }

        [StringLength(100)]
        public string?  DescriptionLocalisationEn { get; set; }

        [StringLength(100)]
        public string?  DescriptionDepartementFr { get; set; }

        [StringLength(100)]
        public string?  DescriptionDepartementEn { get; set; }

        [StringLength(100)]
        public string?  DescriptionEmplacementEquipementFr { get; set; }

        [StringLength(100)]
        public string?  DescriptionEmplacementEquipementEn { get; set; }

       
        [StringLength(2000)]
        public string? UsagerDescriptionGeneraleRemarques { get; set; }

        [StringLength(2000)]
        public string? UsagerRemarquesGenerales { get; set; }

        public bool UsagerRemarquesGeneralesFait { get; set; }

        public DateTime? UsagerDateHeure { get; set; }

    }
}
