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

    private Subtask ActiveSubtask { get; set; } = null!;

    private bool ToggleSubtaskModal { get; set; } = false;

    private Subtask NewSt { get; set; } = new();

    [Inject] 
    private ISubtaskService _ss { get; set; } = null!;

    [Inject] private ITaskService _ts { get; set; } = null!;

    private bool IsStCreate { get; set; } = false;

    private void ToggleStModal(Subtask? st = null)
    {
        if(st is not null){
            ActiveSubtask = st;
        }
        ToggleSubtaskModal = !ToggleSubtaskModal;
    }

    private async void HandleSubtaskCreation()
    {
        // Flag for visual
        IsStCreate = true;
        
        //Add the values user doesn't select
        NewSt.Parent = ActiveTask;
        NewSt.TaskId = ActiveTask.ActivityId;
        NewSt.SectionId = await _ts.GetSectionIdPositionOneAsync();

        _ss.CreateEntityAsync(NewSt);
        
        //Reset visual flag and newST
        NewSt = new();
        IsStCreate = false;
        StateHasChanged();
    }
}