using TrackR.BlazorServer.Services.Interfaces;
using TrackR.DataContext.SQL;
using Activity = TrackR.Models.SQL.Activity;

namespace TrackR.BlazorServer.Services;

public class TaskService : Services<Activity>, ITaskService
{
    public TaskService(SqlContext db) : base(db)
    {
        
    }
    
}