using Microsoft.EntityFrameworkCore;
using TrackR.BlazorServer.Services.Interfaces;
using TrackR.Models.SQL;
using TrackR.DataContext.SQL; // ISqlContext

namespace TrackR.BlazorServer.Services;

public class BoardService : Services<Board>, IBoardService
{
    public BoardService(SqlContext dbContext) : base(dbContext)
    {
    }
}