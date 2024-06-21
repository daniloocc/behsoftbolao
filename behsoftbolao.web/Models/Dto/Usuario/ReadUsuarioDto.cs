using System.ComponentModel.DataAnnotations;

namespace DataAccess.Data.Dto;

public class ReadUsuarioDto
{
    public string Nome { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    //public string Gid { get; set; }
    public string AvatarUrl { get; set; } = string.Empty;
    public DateTime CriadoEm { get; set; }
    public DateTime HoraDaConsulta { get; } = DateTime.Now;
}
