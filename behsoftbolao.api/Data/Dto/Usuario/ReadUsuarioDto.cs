using System.ComponentModel.DataAnnotations;

namespace DataAccess.Data.Dto;

public class ReadUsuarioDto
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Gid { get; set; }
    public string AvatarUrl { get; set; }
    public DateTime CriadoEm { get; set; }
    public DateTime HoraDaConsulta { get; } = DateTime.Now;
}
