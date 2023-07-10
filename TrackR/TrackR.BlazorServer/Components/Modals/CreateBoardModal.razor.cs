using Microsoft.AspNetCore.Components;
using TrackR.BlazorServer.Services.Interfaces;
using TrackR.Models.SQL;

namespace TrackR.BlazorServer.Components.Modals;

public partial class CreateBoardModal
{
    private string Name { get; set; } = null!;
    [Inject] 
    private IBoardService _bs { get; set; } = null!;
    [Parameter]
    public Action ToggleModal { get; set; }

    private async Task HandelCreateBoard()
    {
        Board b = new();
        b.Name = Name;
        await _bs.CreateEntityAsync(b);
        _nm.NavigateTo(_nm.Uri, forceLoad: true);
    }
}