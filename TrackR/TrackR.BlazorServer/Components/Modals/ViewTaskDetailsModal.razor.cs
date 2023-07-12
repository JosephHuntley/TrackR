using Microsoft.AspNetCore.Components;
using TrackR.BlazorServer.Services.Interfaces;
using TrackR.Models.SQL;

namespace TrackR.BlazorServer.Components.Modals;

public partial class ViewTaskDetailsModal
{
    [Parameter] 
    public Action ToggleModal { get; set; } = null!;

    [Parameter] 
    public Activity ActiveTask { get; set; } = null!;
    [Parameter]
    public List<Section> Sections { get; set; } = null!;

    
}