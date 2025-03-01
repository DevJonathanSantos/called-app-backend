using ChamadosSetor8.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Infra.Data.Repositories;

public class RepositoryBase<T> where T : class
{
    private Sector8CallsContext _context;
    private DbSet<T> _table;

    public RepositoryBase(Sector8CallsContext context)
    {
        this._context = context;

        this._table = _context.Set<T>();
    }

    public virtual async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _table.AsNoTracking().ToListAsync();
    }

    public virtual async Task<T> GetByIdAsync(object id)
    {
        return await _table.FindAsync(id);
    }

    public virtual async Task<T> AddAsync(T entity)
    {
        await _table.AddAsync(entity);

        return entity;
    }

    public virtual async Task UpdateAsync(T entity)
    {
        _table.Attach(entity);
        _context.Entry(entity).State = EntityState.Modified;
    }

    public virtual async Task DeleteAsync(object id)
    {
        T existing = await _table.FindAsync(id);
        _table.Remove(existing);
    }

    public virtual async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }
}
