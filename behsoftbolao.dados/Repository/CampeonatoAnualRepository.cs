using BehSoft.DataAccess.Repository.IRepository;
using behsoftbolao.api.Data;
using Core.Models;

namespace BehSoft.DataAccess.Repository;

public class CampeonatoAnualRepository : Repository<CampeonatoAnual>, ICampeonatoAnualRepository
{
    private BolaoDbContext _db;
    public CampeonatoAnualRepository(BolaoDbContext db) : base(db)
    {
        _db = db; 
    }

    public void Update(CampeonatoAnual campeonatoAnual)
    {
        _db.CampeonatoAnual.Update(campeonatoAnual);
    }
}
