using AutoMapper;
using BehSoft.DataAccess.Repository.IRepository;
using behsoftbolao.api.Managers.Interfaces;
using Core.Models;
using DataAccess.Data.Dto;
using System.Globalization;

namespace behsoftbolao.api.Managers;

public class BolaoManager : IBolaoManager
{
    private readonly IMapper _mapper;
    private readonly IUnitOfWork _unityOfWork;

    public BolaoManager(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unityOfWork = unitOfWork;
        _mapper = mapper;
    }

    public async Task<List<ReadBolaoDto>> GetAll(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending, int pageNumber, int pageSize)
    {
        var boloes = await _unityOfWork.Bolao.GetAll(filterOn, filterQuery, sortBy, isAscending ?? true, pageNumber, pageSize, includeProperties: "Dono,CampeonatoAnual,CampeonatoAnual.Campeonato");

        // mapear domain model para dto
        List<ReadBolaoDto> boloesDtos = _mapper.Map<List<ReadBolaoDto>>(boloes);

        return boloesDtos;
    }

    public async Task<ReadBolaoDto> GetByCode(string codigo)
    {
        // domain model
        var bolao = await _unityOfWork.Bolao.Get(b => b.Codigo.ToUpper() == codigo.ToUpper(), includeProperties: "Dono,CampeonatoAnual,CampeonatoAnual.Campeonato");

        //if (bolao == null)
        //    return null;

        // map para dto
        ReadBolaoDto bolaoDto = _mapper.Map<ReadBolaoDto>(bolao);
        return bolaoDto;
    }

    public async Task<ReadBolaoDto> InserirBolao(CreateBolaoDto bolaoDto)
    {
        // map dto to domain model
        var dm = _mapper.Map<Bolao>(bolaoDto);

        // use domain model to create region
        await _unityOfWork.Bolao.Add(dm);
        await _unityOfWork.Save();

        // map domain back to dto
        //var result = _mapper.Map<ReadBolaoDto>(dm);

        var result = await _unityOfWork.Bolao.Get(b => b.Codigo == dm.Codigo, includeProperties: "Dono,CampeonatoAnual,CampeonatoAnual.Campeonato");
        return _mapper.Map<ReadBolaoDto>(result);

    }
}
