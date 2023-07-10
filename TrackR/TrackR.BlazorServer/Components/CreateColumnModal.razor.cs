using Microsoft.AspNetCore.Components;
using TrackR.BlazorServer.Services.Interfaces;
using TrackR.Models.SQL;

namespace TrackR.BlazorServer.Components;

public partial class CreateColumnModal
{
    [Inject]
    private ISectionService _ss { get; set; } = null!;

    [Inject] 
    private NavigationManager _nm { get; set; } = null!;
    
    [Parameter]
    public Action ToggleModal { get; set; }

    private string Name { get; set; } = null!;
    
    private int Position { get; set; }

    private int HighestPosition { get; set; }

    
    
    private async Task HandelCreateColumnAsync()
    {
        HighestPosition = await _ss.RetrieveMaxPositionAsync() + 1;
        
        Section entity = new()
        {
            Name = Name,
            Position = HighestPosition
        };

        await _ss.CreateEntityAsync(entity);
        
        _nm.NavigateTo(_nm.Uri, forceLoad: true);
    }
}