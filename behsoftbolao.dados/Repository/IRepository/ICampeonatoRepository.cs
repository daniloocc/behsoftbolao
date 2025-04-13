using BehSoft.DataAccess.Repository.IRepository;
using Database.Models;

namespace BehSoft.DataAccess.Repository.IRepository;

public interface ICampeonatoRepository : IRepository<Campeonato>
{
    void Update(Campeonato category);
}
