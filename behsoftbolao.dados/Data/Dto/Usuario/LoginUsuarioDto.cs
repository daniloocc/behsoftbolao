using System.ComponentModel.DataAnnotations;

namespace DataAccess.Data.Dto;

public class LoginUsuarioDto
{
    [Required]
    public string UserName { get; set; }
    [Required]
    public string Password { get; set; }
}
