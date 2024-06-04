using System.ComponentModel.DataAnnotations;

namespace DataAccess.Data.Dto;

public class ReadBolaoDto
{
    // TODO: -> remover relacionamentos desnecessarios no dto ["virtual", "icollection"]
    // TODO: -> ReadUsuarioDto
    public string Titulo { get; set; }
    public string Codigo { get; set; }
    public DateTime CriadoEm { get; set; }
    public bool Updated { get; set; }
    public ReadUsuarioDto? Dono { get; set; }
    public ReadCampeonatoAnualDto CampeonatoAnual { get; set; }
    //public virtual ICollection<Participante> Participantes { get; set; }
}
