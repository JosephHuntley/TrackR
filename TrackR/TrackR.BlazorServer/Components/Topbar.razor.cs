using Microsoft.AspNetCore.Components;
using TrackR.Models.SQL;

namespace TrackR.BlazorServer.Components;

public partial class Topbar
{
    [Parameter]
    public IEnumerable<Board> Boards { get; set; } = null!;

    [Parameter] 
    public Board ActiveBoard { get; set; } = null!;

    private bool IsModal { get; set; } = false;

    private bool IsMenu { get; set; } = false;

    private void ToggleModal()
    {
        IsModal = !IsModal;
    }

    private void ToggleMenu()
    {
        IsMenu = !IsMenu;
    }
}