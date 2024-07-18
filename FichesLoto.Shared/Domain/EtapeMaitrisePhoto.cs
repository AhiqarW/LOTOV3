using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichesLoto.Shared.Domain;

public class EtapeMaitrisePhoto
{
    public Guid EtapeMaitrisePhotoId { get; set; }

    public Guid EtapeMaitriseId { get; set; }

    [StringLength(100)]
    public string? Photo { get; set; }

    [StringLength(1000)]
    public string? DescriptionPhotoFr { get; set; }

    [StringLength(1000)]
    public string? DescriptionPhotoEn { get; set; }

    public DateTime? DateCreation { get; set; }
}
