using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichesLoto.Shared.Domain;

public class PreparationEtapeControle
{
    public Guid PreparationEtapeControleId { get; set; }
    public Guid SocieteId { get; set; }

    [StringLength(200)]
    public string? DescriptionPreparationEtapeControleFr { get; set; }

    [StringLength(200)]
    public string? DescriptionPreparationEtapeControleEn { get; set; }

    public bool FaitPreparationEtapeControle { get; set; }

    // 1 = Cadenassage, 2 = Décadenassage
    public int? CategoriePreparationEtapeControle { get; set; }

    public DateTime? DateHeure { get; set; }
}
