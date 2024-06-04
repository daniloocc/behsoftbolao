using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehSoft.DataAccess.Repository.IRepository;

public interface IUnitOfWork
{
    ICampeonatoRepository Campeonato { get; }
    ICampeonatoAnualRepository CampeonatoAnual { get; }
    IBolaoRepository Bolao { get; }
    Task Save();
}
