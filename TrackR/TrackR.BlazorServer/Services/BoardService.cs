using Microsoft.EntityFrameworkCore;
using TrackR.BlazorServer.Services.Interfaces;
using TrackR.Models.SQL;
using TrackR.DataContext.SQL; // ISqlContext

namespace TrackR.BlazorServer.Services;

public class BoardService : IBoardService
{
    private SqlContext _db;
    public BoardService(SqlContext db)
    {
        _db = db;
    }

    public IEnumerable<Board> GetBoards()
    {
        return _db.Boards.ToList();
    }

    public async Task CreateBoardAsync(Board b)
    {
        b.CreatedDate = DateTime.Now;
        b.UpdatedDate = DateTime.Now;
        
        await _db.Boards.AddAsync(b);
        await _db.SaveChangesAsync();

        return;
    }
}