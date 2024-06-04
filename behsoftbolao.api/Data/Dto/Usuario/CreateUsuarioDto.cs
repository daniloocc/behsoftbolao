using System.ComponentModel.DataAnnotations;

namespace DataAccess.Data.Dto;

public class CreateUsuarioDto
{

    [Required(ErrorMessage = "O nome do Jogador é obrigatório")]
    public string Nome { get; set; }
    public string UserName { get; set; }
    [Required]
    public DateTime DataNascimento { get; set; }
    [Required(ErrorMessage = "O email é obrigatório")]
    public string Email { get; set; }
    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
    [Required]
    [Compare("Password")]
    public string ConfirmPassword { get; set; }
}
