using Microsoft.AspNetCore.Components;
using TrackR.Models.SQL;

namespace TrackR.BlazorServer.Components;

public partial class Topbar
{
    [Parameter]
    public IEnumerable<Board> Boards { get; set; } = null!;

    [Parameter] 
    public Board ActiveBoard { get; set; } = null!;

    public bool IsModal { get; set; } = false;

    public void ToggleModal()
    {
        IsModal = !IsModal;
    }
}