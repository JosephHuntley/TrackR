using Microsoft.EntityFrameworkCore;
using TrackR.BlazorServer.Services.Interfaces;
using TrackR.DataContext.SQL;
using TrackR.Models.SQL;

namespace TrackR.BlazorServer.Services;

public class Services<T> : IServices<T> where T : Model
{
    private SqlContext _db;
    private DbSet<T> _dbSet;
    
    public Services(){}
    
    public Services(SqlContext db)
    {
        _db = db;
        _dbSet = _db.Set<T>();
    }
    
    public async Task<List<T>> GetEntitiesAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task CreateEntityAsync(T entity)
    {
        entity.CreatedDate = DateTime.Now;
        entity.UpdatedDate = DateTime.Now;

        await _db.AddAsync(entity);
        await _db.SaveChangesAsync();
    }
}