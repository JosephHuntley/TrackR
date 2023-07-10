using TrackR.Models.SQL;
namespace TrackR.BlazorServer.Services.Interfaces;

public interface ITaskService : IServices<Activity>
{
    public Task<int> GetSectionIdPositionOneAsync();

}