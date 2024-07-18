using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichesLoto.Shared.Domain
{
    public class EtapeMaitriseAccessoire
    {

        public Guid? EtapeMaitriseAccessoireId { get; set; }

        public Guid EtapeMaitriseId { get; set; }

        public Guid AccessoireId { get; set; }

        [StringLength(50)]
        public string? DescriptionAccessoireFr { get; set; }

        [StringLength(50)]
        public string? DescriptionAccessoireEn { get; set; }

        [StringLength(200)]
        public string? PhotoAccessoire { get; set; }

        public int? Quantite { get; set; }
    }
}
