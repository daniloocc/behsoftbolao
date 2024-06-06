using AutoMapper;
using Core.Models;
using DataAccess.Data.Dto;
using Database.Models;

namespace behsoftbolao.api.Mappings;

public class AutoMapperProfiles : Profile
{
    public AutoMapperProfiles()
    {
        CreateMap<Bolao, ReadBolaoDto>()
            //.ForMember(b => b.Dono, d => d.MapFrom( e => e.))
            .ReverseMap();

        CreateMap<CreateBolaoDto, Bolao>()
            .ReverseMap();

        CreateMap<Usuario, ReadUsuarioDto>()
            .ReverseMap();

        CreateMap<CampeonatoAnual,  ReadCampeonatoAnualDto>()
            .ReverseMap();

        CreateMap<Campeonato, ReadCampeonatoDto>()
            .ReverseMap();

    }
}
