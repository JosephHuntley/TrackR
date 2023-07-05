using Microsoft.AspNetCore.Components;
using TrackR.BlazorServer.Services;
using TrackR.Models.SQL;

namespace TrackR.BlazorServer.Pages;

public partial class Index : ComponentBase
{
    public IEnumerable<Board> Boards { get; private set; } = null!;
    public int ActiveBoard { get; set; } = 1;
    [Inject] 
    private BoardService _bs { get; set; } = null!;

    public bool Modal { get; set; } = false;

    protected override void OnInitialized()
    {
        // Initialize the Boards property by calling a method from the injected service
        Boards = _bs.GetBoards();
    }

    private void HandleBoardClick(int id)
    {
        ActiveBoard = id;
    }

    private void HandleModal()
    {
        
    }
}