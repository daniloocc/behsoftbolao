using Core.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Database.Models;

public class Usuario : IdentityUser
{
    [Required(ErrorMessage = "O nome é Obrigatório")]
    public string Nome { get; set; }
    [Required(ErrorMessage = "Forneça uma data de nascimento")]
    public DateTime DataNascimento { get; set; }

    public virtual ICollection<Participante> Participante { get; set; }
    public virtual ICollection<Bolao> Dono { get; set; }

    public Usuario(): base() { }

}