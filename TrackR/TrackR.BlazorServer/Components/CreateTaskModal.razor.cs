using Microsoft.AspNetCore.Components;
using TrackR.BlazorServer.Services.Interfaces;
using TrackR.Models.SQL;
using Activity = TrackR.Models.SQL.Activity;

namespace TrackR.BlazorServer.Components;

public partial class CreateTaskModal
{
    [Parameter]
    public Action ToggleModal { get; set; }
    
    public int BoardId { get; set; }

    public string Title { get; set; } = null!;

    public string Issue { get; set; } = null!;
    
    [Parameter]
    public IEnumerable<Board> Boards { get; set; }
    
    [Inject]
    private ITaskService _ts { get; set; } = null!;

    [Inject] private NavigationManager _nm { get; set; } = null!;

    private async void HandleSubmitAsync()
    {
        Activity entity = new()
        {
            Title = Title,
            Issue = Issue,
            BoardId = BoardId,
            //TODO: Update Migrations
            UserId = 1
        };

        await _ts.CreateEntityAsync(entity);
        _nm.NavigateTo(_nm.Uri, forceLoad: true);
    }
}