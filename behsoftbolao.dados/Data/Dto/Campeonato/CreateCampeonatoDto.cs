using System.ComponentModel.DataAnnotations;

namespace DataAccess.Data.Dto;

public class CreateCampeonatoDto
{
    [Required(ErrorMessage = "O nome do campeonato é obrigatório")]
    [MaxLength(150, ErrorMessage = "O nome deve ter até 150 Caracteres")]
    public string Nome { get; set; }
    [Required(ErrorMessage = "A sigla é obrigatória")]
    [MaxLength(5, ErrorMessage = "A sigla pode ter até 3 caracteres")]
    public string Sigla { get; set; }
}
