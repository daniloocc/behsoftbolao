using Core.Models;
using Microsoft.AspNet.Identity.EntityFramework;
using System.ComponentModel.DataAnnotations;

namespace Database.Models;

public class Usuario : IdentityUser // TODO: testar e retirar o identity user. Como agora temos dois contextos, essa atribuição pode ser inútil
{
    [Required(ErrorMessage = "O nome é Obrigatório")]
    public string Nome { get; set; }
    public string AvatarUrl { get; set; }
    [Required(ErrorMessage = "Forneça uma data de nascimento")]
    public DateTime DataNascimento { get; set; }
    public DateTime CriadoEm { get; set; }
    public virtual ICollection<Participante> Participante { get; set; }
    public virtual ICollection<Bolao> Dono { get; set; }

    public Usuario() : base() { }

}