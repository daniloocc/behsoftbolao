using Core.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models;

public class Time
{
    [Key]
    public Guid Id { get; set; }
    [Required(ErrorMessage ="O nome do Time é Obrigatório")]
    public string Nome { get; set; }
    [Required(ErrorMessage = "A sigla do Time é Obrigatório")]
    public string Sigla { get; set; }
    public string IconeBandeira { get; set; }
    [InverseProperty("TimeUm")]
    public virtual ICollection<Jogo> TimesUm { get; set; }
    [InverseProperty("TimeDois")]
    public virtual ICollection<Jogo> TimesDois { get; set; }
}
