using Microsoft.EntityFrameworkCore;
using TrackR.BlazorServer.Services.Interfaces;
using TrackR.Models.SQL;
using TrackR.DataContext.SQL; // ISqlContext

namespace TrackR.BlazorServer.Services;

public class BoardService : Services<Board>, IBoardService
{
    private SqlContext _db;
    public BoardService(SqlContext dbContext) : base(dbContext)
    {
        _db = dbContext;
    }

    public async Task<List<Board>> GetEntitiesAsync()
    {
        return await _db.Boards
            .Include(b => b.Tasks)
                .ThenInclude(t => t.Subtasks)
            .ToListAsync();
    }
}