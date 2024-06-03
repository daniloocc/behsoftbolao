using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models;

public class Palpite
{
    public Guid Id { get; set; }
    public int? PontosTimeUm { get; set; }
    public int? PontosTimeDois { get; set; }
    public DateTime CriadoEm { get; set; }
    public Guid ParticipanteID { get; set; }
    public virtual Participante Participante { get; set; }
    public Guid JogoId { get; set; }
    public virtual Jogo Jogo { get; set;}
}
