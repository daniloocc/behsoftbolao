using Database.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models;

public class Jogo
{
    public Guid Id { get; set; }
    public DateTime? Data { get; set; }
    public int? PlacarTimeUm { get; set; }
    public int? PlacarTimeDois { get; set; }
    public Guid CampeonatoAnualId { get; set; }
    public virtual CampeonatoAnual CampeonatoAnual { get; set; }
    public Guid? TimeUmId { get; set; }
    public virtual Time TimeUm { get; set; }
    public Guid? TimeDoisId { get; set; }
    public virtual Time TimeDois { get; set; }

    public virtual ICollection<Palpite> Plapites { get; set; }
}
