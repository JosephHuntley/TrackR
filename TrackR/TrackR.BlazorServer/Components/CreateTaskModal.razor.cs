using Microsoft.AspNetCore.Components;
using System.ComponentModel.DataAnnotations; // [MaxLength]
using TrackR.BlazorServer.Services.Interfaces;
using TrackR.Models.SQL;
using Activity = TrackR.Models.SQL.Activity;

namespace TrackR.BlazorServer.Components;

public partial class CreateTaskModal
{
    [Parameter]
    public Action ToggleModal { get; set; }

    private int BoardId { get; set; }

    [MaxLength(50)]
    private string Title { get; set; } = null!;

    private string Issue { get; set; } = null!;
    
    [Parameter]
    public IEnumerable<Board> Boards { get; set; }
    
    [Inject]
    private ITaskService _ts { get; set; } = null!;

    [Inject] 
    private NavigationManager _nm { get; set; } = null!;

    private async void HandleSubmitAsync()
    {
        Activity entity = new()
        {
            Title = Title,
            Issue = Issue,
            BoardId = BoardId,
            SectionId = 1,
            UserId = 1
        };

        await _ts.CreateEntityAsync(entity);
        _nm.NavigateTo(_nm.Uri, forceLoad: true);
    }
}