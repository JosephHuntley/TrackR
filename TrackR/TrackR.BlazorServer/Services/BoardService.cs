using Microsoft.EntityFrameworkCore;
using TrackR.Models.SQL;
using TrackR.DataContext.SQL; // ISqlContext

namespace TrackR.BlazorServer.Services;

public class BoardService
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
}