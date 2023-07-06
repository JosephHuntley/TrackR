using Microsoft.AspNetCore.Components;
using TrackR.Models.SQL;

namespace TrackR.BlazorServer.Components;

public partial class Sidebar
{
    [Parameter] 
    public List<Board>? Boards { get; set; } = new();

    [Parameter] 
    public Board ActiveBoard { get; set; } = null!;

    private bool CreateModal { get; set; } = false;
    
    private void HandleCreateModal()
    {
        CreateModal = !CreateModal;
    }
    
    private void HandleBoardClick(Board b)
    {
        ActiveBoard = b;
    }

}