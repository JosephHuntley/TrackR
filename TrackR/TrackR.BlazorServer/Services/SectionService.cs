using TrackR.BlazorServer.Services.Interfaces;
using TrackR.DataContext.SQL;
using TrackR.Models.SQL;

namespace TrackR.BlazorServer.Services;

public class SectionService : Services<Section>, ISectionService
{
    public SectionService(SqlContext db) : base(db)
    {
        
    }
}