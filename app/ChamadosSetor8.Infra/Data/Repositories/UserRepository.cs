using ChamadosSetor8.Domain.Interfaces.Repositories;
using ChamadosSetor8.Domain.Entities;
using ChamadosSetor8.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Identity.Client;
using Microsoft.EntityFrameworkCore;
using System.Collections;
using ChamadosSetor8.Domain.Interfaces;

namespace ChamadosSetor8.Infra.Data.Repositories;

public class UserRepository : RepositoryBase<User>, IUserRepository
{

    private readonly Sector8CallsContext _context;
    public UserRepository(Sector8CallsContext context) : base(context)
    {
        _context = context;
    }

    public async Task<IList<User>> GetAllCompleteAsync()
    {
        return await _context.User
            .Include(x => x.Profile)
            .Include(x => x.Department)
            .AsNoTracking()
            .ToListAsync();
    }
}
