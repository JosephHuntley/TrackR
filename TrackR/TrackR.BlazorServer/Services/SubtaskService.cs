using TrackR.BlazorServer.Services.Interfaces;
using TrackR.DataContext.SQL;
using TrackR.Models.SQL;

namespace TrackR.BlazorServer.Services;

public class SubtaskService : Services<Subtask>, ISubtaskService
{
    public SubtaskService(SqlContext db) : base(db)
    {
        
    }
    
}