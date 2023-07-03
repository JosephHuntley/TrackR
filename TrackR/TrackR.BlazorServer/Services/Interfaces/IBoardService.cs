using TrackR.Models.SQL;

namespace TrackR.BlazorServer.Services.Interfaces;

public interface IBoardService
{
    public IEnumerable<Board> GetBoards();
}