using System;
using System.Collections.Generic;

namespace AppTechnicien.Models;

public partial class Detecteur
{
    public int Id { get; set; }

    public DateTime DatePose { get; set; }

    public decimal? ValeurReleve { get; set; }

    public string NomPiece { get; set; } = null!;

    public DateTime? DateRetrait { get; set; }

    public int IdEtablissement { get; set; }

    public virtual Etablissement IdEtablissementNavigation { get; set; } = null!;
}
