using System.ComponentModel.DataAnnotations;

namespace DataAccess.Data.Dto;

public class UpdateUsuarioDto
{
    [Required(ErrorMessage = "O nome do usuário é obrigatório")]
    public string Nome { get; set; }
    [Required(ErrorMessage = "O email é obrigatório")]
    public string Email { get; set; }
    public string Gid { get; set; }
    public string AvatarUrl { get; set; }

}
