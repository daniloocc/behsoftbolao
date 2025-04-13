using BehSoft.DataAccess.Repository.IRepository;
using behsoftbolao.negocio.Managers.Interface;
using Database.Models;

namespace behsoftbolao.negocio.Managers;

public class CampeonatoManager : ICampeonatoManager
{
    private readonly IUnitOfWork _unityOfWork;

    public CampeonatoManager(IUnitOfWork unitOfWork)
    {
        _unityOfWork = unitOfWork;
    }

    public async Task<List<Campeonato>> GetAll(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending, int pageNumber, int pageSize)
    {
        var campeonatos = await _unityOfWork.Campeonato.GetAll(filterOn, filterQuery, sortBy, isAscending ?? true, pageNumber, pageSize, includeProperties: "Dono,CampeonatoAnual,CampeonatoAnual.Campeonato");

        // mapear domain model para dto
        //List<ReadBolaoDto> boloesDtos = _mapper.Map<List<ReadBolaoDto>>(camponatos);

        return campeonatos;
    }

    public async Task<Campeonato> GetByCode(string codigo)
    {
        // domain model
        var campeonatos = await _unityOfWork.Campeonato.Get(b => b.Codigo.ToUpper() == codigo.ToUpper(), includeProperties: "Dono,CampeonatoAnual,CampeonatoAnual.Campeonato");

        //if (bolao == null)
        //    return null;

        // map para dto
        //ReadBolaoDto bolaoDto = _mapper.Map<ReadBolaoDto>(bolao);
        return campeonatos;
    }

    public async Task<Campeonato> InserirBolao(Campeonato bolaoDto)
    {
        /*
        // map dto to domain model
        var dm = _mapper.Map<Bolao>(bolaoDto);

        // use domain model to create region
        await _unityOfWork.Bolao.Add(dm);
        await _unityOfWork.Save();

        // map domain back to dto
        //var result = _mapper.Map<ReadBolaoDto>(dm);

        var result = await _unityOfWork.Bolao.Get(b => b.Codigo == dm.Codigo, includeProperties: "Dono,CampeonatoAnual,CampeonatoAnual.Campeonato");
        return _mapper.Map<ReadBolaoDto>(result);
        //*/
        return null;
    }
}
