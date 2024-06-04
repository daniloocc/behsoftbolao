using Core.Utils;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Data.Dto;

public class CreateBolaoDto
{

    [Required(ErrorMessage = "O título do Bolão é obrigatório")]
    [StringLength(50, ErrorMessage = "O titulo do bolão deve ter até 50 caracteres")]
    public string Titulo { get; set; }
    public string Codigo { get; } = StringUtils.RandomString(6);
    public DateTime CriadoEm { get; } = DateTime.Now;
    public bool Updated { get; } = false;
    public string? DonoId { get; set; }
    [Required(ErrorMessage = "O código do campeonato anual é obrigatório")]
    public Guid CampeonatoAnualId { get; set; }
}
