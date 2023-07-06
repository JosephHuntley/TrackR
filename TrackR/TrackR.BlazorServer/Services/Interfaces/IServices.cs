using TrackR.Models.SQL;

namespace TrackR.BlazorServer.Services.Interfaces;

public interface IServices<T> where T : Model 
{
    public Task<List<T>> GetEntitiesAsync();
    public Task CreateEntityAsync(T entity);
}