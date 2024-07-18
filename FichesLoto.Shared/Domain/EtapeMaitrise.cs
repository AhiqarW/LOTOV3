using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichesLoto.Shared.Domain
{
    public class EtapeMaitrise
    {
        public Guid EtapeMaitriseId { get; set; }
        
        // 1 = Cadenassage, 2 = Décadenassage
        public int? CategorieEtapeMaitrise { get; set; }

        public Guid NoFicheCadenassage { get; set; }

        public Guid? EtapeMaitriseDepotId { get; set; }

        public Guid? NoCategorieInstruction { get; set; }

        public Guid? NoElement { get; set; }

        public Guid? NoActionAPoser { get; set; }

        public Guid? NoSourceEnergie { get; set; }

        public Guid? NoPositionCadenassage { get; set; }

        public int? NoEtape { get; set; }
        [StringLength(200)]
        public string? NoIdentification { get; set; }

        [StringLength(2000)]
        public string? Emplacement { get; set; }

        //[StringLength(100)]
        //public string? Photo { get; set; }

        [StringLength(100)]
        public string? PhotoSourceEnergie { get; set; }

        [StringLength(4000)]
        public string? InformationsSupplementaires { get; set; }

        public DateTime? DateCreation { get; set; }
        public DateTime? DateModification { get; set; }

        public Guid? NoPositionNormaleOperation { get; set; }

        [StringLength(100)]
        public string? DescriptionCategorieInstructionFr { get; set; }

        [StringLength(100)]
        public string? DescriptionCategorieInstructionEn { get; set; }

        [StringLength(100)]
        public string? DescriptionElementFr { get; set; }

        [StringLength(100)]
        public string? DescriptionElementEn { get; set; }

        [StringLength(100)]
        public string? DescriptionActionAPoserFr { get; set; }

        [StringLength(100)]
        public string? DescriptionActionAPoserEn { get; set; }
        
        [StringLength(100)]
        public string? DescriptionActionAPoserInverseFr { get; set; }

        [StringLength(100)]
        public string? DescriptionActionAPoserInverseEn { get; set; }


        [StringLength(100)]
        public string? DescriptionSourceEnergieFr { get; set; }

        [StringLength(100)]
        public string? DescriptionSourceEnergieEn { get; set; }

        [StringLength(100)]
        public string? DescriptionPositionCadenassageFr { get; set; }

        [StringLength(100)]
        public string? DescriptionPositionCadenassageEn { get; set; }

        [StringLength(100)]
        public string? DescriptionPositionCadenassagePositionNormaleFr { get; set; }

        [StringLength(100)]
        public string? DescriptionPositionCadenassagePositionNormaleEn { get; set; }

        [StringLength(2000)]
        public string? UsagerEtapeMaitriseRemarques { get; set; }

        public bool UsagerEtapeMaitriseFait { get; set; }

        public DateTime? UsagerDateHeure { get; set; }
    }
}
