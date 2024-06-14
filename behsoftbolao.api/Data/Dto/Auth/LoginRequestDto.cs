using System.ComponentModel.DataAnnotations;

namespace behsoftbolao.api.Data.Dto.Auth;

public class LoginRequestDto
{
    [Required]
    [DataType(DataType.EmailAddress)]
    public string UserName { get; set; }

    [Required]
    [DataType(DataType.Password)]
    public string Password { get; set; }
}
