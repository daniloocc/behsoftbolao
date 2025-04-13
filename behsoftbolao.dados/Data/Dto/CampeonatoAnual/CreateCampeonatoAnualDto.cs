using System.ComponentModel.DataAnnotations;

namespace DataAccess.Data.Dto;

public class CreateCampeonatoAnualDto
{
    [Required(ErrorMessage = "Informe um ano para o campeonato ANUAL")]
    public int Ano { get; set; }
    public DateTime? DataEncerramento { get; set; }
    [Required(ErrorMessage = "O campeonato deve ser informado")]
    public int CampeonatoId { get; set; }
}
