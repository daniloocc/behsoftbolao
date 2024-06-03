using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models;

public class CampeonatoAnual
{
    public Guid Id { get; set; }
    public int Ano { get; set; }
    public DateTime? DataEncerramento { get; set; }
    public Guid CampeonatoId { get; set; }
    public virtual Campeonato Campeonato { get; set; }
    public virtual ICollection<Bolao> Boloes { get; set; }
    public virtual ICollection<Jogo> Jogos { get; set; }

}
