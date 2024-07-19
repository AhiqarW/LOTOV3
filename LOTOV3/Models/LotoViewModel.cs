using FichesLoto.Shared.Domain;

namespace LOTOV3.Models
{
    public class LotoViewModel
    {

        public DescriptionGenerale DescriptionGenerale { get; set; }
        public List<Accessoire> Accessoires { get; set; }
        public List<PreparationEtapeControle> PreparationsEtapeControle { get; set; }
        public List<EtapeMaitrise> EtapeMaitrise { get; set; }
        public List<EtapeMaitriseAccessoire> EtapeMaitriseAccessoire { get; set; }
        public List<EtapeMaitrisePhoto> EtapeMaitrisePhoto { get; set; }
        public List<Participant> Participant { get; set; }


    }
}
