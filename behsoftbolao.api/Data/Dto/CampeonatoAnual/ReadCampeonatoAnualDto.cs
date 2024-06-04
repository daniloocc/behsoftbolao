
namespace DataAccess.Data.Dto;

public class ReadCampeonatoAnualDto
{
    public int Id { get; set; }
    public int Ano { get; set; }
    public DateTime? DataEncerramento { get; set; }
    public ReadCampeonatoDto Campeonato { get; set; }
    public DateTime HoraDaConsulta { get; set; } = DateTime.Now;
}
