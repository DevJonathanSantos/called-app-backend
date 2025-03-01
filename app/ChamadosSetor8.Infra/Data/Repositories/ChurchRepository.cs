using ChamadosSetor8.Domain.Entities;
using ChamadosSetor8.Domain.Interfaces.Repositories;
using ChamadosSetor8.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ChamadosSetor8.Infra.Data.Repositories
{
    public class ChurchRepository : RepositoryBase<Church>, IChurchRepository
    {
        private readonly Sector8CallsContext _context;

        public ChurchRepository(Sector8CallsContext context) : base(context)
        {

            _context = context;
        }

        public async Task<IList<Church>> GetByIdsAsync(IEnumerable<int> ids)
        {
            return await _context.Church
                .AsNoTracking()
                .Where(x=> ids.Contains(x.Id))
                .ToListAsync();
        }
    }
}
