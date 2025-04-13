using Database.Models;
using System.ComponentModel.DataAnnotations;

namespace Core.Models;

public class Bolao
{
    [Required]
    [Key]
    public Guid Id { get; set; }
    public string Titulo { get; set; }
    [Required]
    [MaxLength(6)]
    public string Codigo { get; set; }
    public DateTime CriadoEm { get; set; }
    public bool Updated { get; set; }
    public string DonoId { get; set; }
    public virtual Usuario Dono { get; set; }
    [Required]
    public Guid CampeonatoAnualId { get; set; }
    public virtual CampeonatoAnual CampeonatoAnual { get; set; }
    public virtual ICollection<Participante> Participantes { get; set; }
}
