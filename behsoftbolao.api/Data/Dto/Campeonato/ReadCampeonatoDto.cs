namespace DataAccess.Data.Dto;

public class ReadCampeonatoDto
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Sigla { get; set; }
    public DateTime HoraConsulta { get; } = DateTime.Now;
}
