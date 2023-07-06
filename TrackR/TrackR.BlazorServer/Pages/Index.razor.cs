using Microsoft.AspNetCore.Components;
using TrackR.BlazorServer.Services;
using TrackR.BlazorServer.Services.Interfaces;
using TrackR.Models.SQL;

namespace TrackR.BlazorServer.Pages;

public partial class Index : ComponentBase
{
    private List<Board> Boards { get; set; } = new List<Board>();
    public Board ActiveBoard { get; set; } = null!;
    [Inject] 
    private IBoardService _bs { get; set; } = null!;

    public bool CreateModal { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        // Initialize the Boards property by calling a method from the injected service
        Boards = await _bs.GetEntitiesAsync();
        ActiveBoard = Boards.ToList()[0];
    }

    private void HandleBoardClick(Board b)
    {
        ActiveBoard = b;
    }

    private void HandleCreateModal()
    {
        CreateModal = !CreateModal;
    }
    
    
}