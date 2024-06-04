using Core.Models;

namespace BehSoft.DataAccess.Repository.IRepository;

public interface ICampeonatoAnualRepository : IRepository<CampeonatoAnual>
{
    void Update(CampeonatoAnual campeonatoAnual);
}
