using BehSoft.DataAccess.Repository.IRepository;
using Core.Models;

namespace BehSoft.DataAccess.Repository.IRepository;

public interface IBolaoRepository : IRepository<Bolao>
{
    void Update(Bolao bolao);
}
