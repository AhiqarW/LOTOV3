using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FichesLoto.Shared.Domain;

public class Participant
{
    public Guid ParticipantId { get; set; }

    public Guid UserId { get; set; }

    public Guid? StatutParticipant { get; set; }

    [StringLength(100)]
    public string? Prenom { get; set; }

    [StringLength(100)]
    public string? Nom { get; set; }

    [StringLength(100)]
    public string? StatutParticipantDescription { get; set; }

    public bool ParticipantActif { get; set; }

    public DateTime? DateParticipant { get; set; }

    public DateTime? DateHeure { get; set; }
}

