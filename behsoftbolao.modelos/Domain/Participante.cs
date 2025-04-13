using Database.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models;

public class Participante
{
    public Guid Id { get; set; }
    public int? Pontuacao { get; set; }
    public DateTime CriadoEm { get; set; }
    public Guid BolaoId { get; set; }
    public virtual Bolao Bolao { get; set; }
    public string UsuarioId { get; set; }
    public virtual Usuario Usuario { get; set; }
    public virtual ICollection<Palpite> Palpites { get; set;}
}
