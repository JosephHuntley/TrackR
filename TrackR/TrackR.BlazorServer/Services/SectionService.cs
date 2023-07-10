using Microsoft.EntityFrameworkCore;
using TrackR.BlazorServer.Services.Interfaces;
using TrackR.DataContext.SQL;
using TrackR.Models.SQL;

namespace TrackR.BlazorServer.Services;

public class SectionService : Services<Section>, ISectionService
{
    private SqlContext _db;
    public SectionService(SqlContext db) : base(db)
    {
        _db = db;
    }

    public override async Task<List<Section>> GetEntitiesAsync()
    {
         List<Section> entites = await _db.Sections.OrderBy(e => e.Position).ToListAsync();

         return entites;
    }

    public async Task<int> RetrieveMaxPositionAsync()
    {
        return await _db.Sections.MaxAsync(s => s.Position);
    }
}