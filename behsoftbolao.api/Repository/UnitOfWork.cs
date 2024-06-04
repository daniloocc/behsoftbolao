using BehSoft.DataAccess.Repository.IRepository;
using behsoftbolao.api.Data;

namespace BehSoft.DataAccess.Repository;

public class UnitOfWork : IUnitOfWork
{
    private BolaoDbContext _db;
    public ICampeonatoRepository Campeonato { get; private set; }
    public ICampeonatoAnualRepository CampeonatoAnual { get; private set; }
    public IBolaoRepository Bolao { get; private set; }

    public UnitOfWork(BolaoDbContext db)
    {
        _db = db;
        Campeonato = new CampeonatoRepository(_db);
        Bolao = new BolaoRepository(_db);
        CampeonatoAnual = new CampeonatoAnualRepository(_db);
    }
    public void Save()
    {
        _db.SaveChanges();
    }
}
