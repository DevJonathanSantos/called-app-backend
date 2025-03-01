using ChamadosSetor8.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Domain.Interfaces.Repositories
{
    public interface IChurchRepository: IRepositoryBase<Church>
    {
        Task<IList<Church>> GetByIdsAsync(IEnumerable<int> ids);
    }
}
