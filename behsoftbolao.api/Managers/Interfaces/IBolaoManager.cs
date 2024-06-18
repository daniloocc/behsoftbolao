using DataAccess.Data.Dto;

namespace behsoftbolao.api.Managers.Interfaces;

public interface IBolaoManager
{
    Task<List<ReadBolaoDto>> GetAll(string? filterOn, string? filterQuery, string? sortBy, bool? isAscending, int pageNumber, int pageSize);
    Task<ReadBolaoDto> GetByCode(string codigo);
    Task<ReadBolaoDto> InserirBolao(CreateBolaoDto bolaoDto);
    
}
