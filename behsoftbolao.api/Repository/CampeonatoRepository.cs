using BehSoft.DataAccess.Repository.IRepository;
using behsoftbolao.api.Data;
using Database.Models;

namespace BehSoft.DataAccess.Repository;

public class CampeonatoRepository : Repository<Campeonato>, ICampeonatoRepository
{
    private BolaoDbContext _db;
    public CampeonatoRepository(BolaoDbContext db) : base(db)
    {
        _db = db; 
    }

    public void Update(Campeonato campeonato)
    {
        _db.Campeonato.Update(campeonato);
    }
}
