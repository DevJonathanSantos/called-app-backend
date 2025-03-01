using ChamadosSetor8.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Domain.Interfaces.Repositories;

public interface IUserRepository : IRepositoryBase<User>
{
    public Task<IList<User>> GetAllCompleteAsync();

}
