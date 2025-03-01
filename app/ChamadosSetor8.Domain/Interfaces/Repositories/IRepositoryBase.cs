using ChamadosSetor8.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Domain.Interfaces.Repositories;

public interface IRepositoryBase<T> where T : class, IEntity
{
    Task<IEnumerable<T>> GetAllAsync();

    Task<T> GetByIdAsync(object id);

    Task<T> AddAsync(T entity);

    Task UpdateAsync(T entity);

    Task DeleteAsync(object id);

    Task SaveAsync();
}