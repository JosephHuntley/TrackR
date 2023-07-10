using Microsoft.EntityFrameworkCore;
using TrackR.BlazorServer.Services.Interfaces;
using TrackR.DataContext.SQL;
using Activity = TrackR.Models.SQL.Activity;

namespace TrackR.BlazorServer.Services;

public class TaskService : Services<Activity>, ITaskService
{
    private SqlContext _db;
    public TaskService(SqlContext db) : base(db)
    {
        _db = db;
    }

    public async Task<int> GetSectionIdPositionOneAsync()
    {
        return await  _db.Sections
            .Where(s => s.Position == 1)
            .Select(s => s.SectionId)
            .FirstOrDefaultAsync();
    }
    
}