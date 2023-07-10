using Microsoft.AspNetCore.Components;
using TrackR.BlazorServer.Services;
using TrackR.BlazorServer.Services.Interfaces;
using TrackR.Models.SQL;

namespace TrackR.BlazorServer.Pages;

public partial class Index : ComponentBase
{
    private List<Board> Boards { get; set; } = new List<Board>();
    private Board ActiveBoard { get; set; } = null!;
    [Inject] 
    private IBoardService _bs { get; set; } = null!;
    [Inject]
    private ISectionService _ss { get; set; } = null!;
    
    // Tasks are seperated by status
    private Dictionary<string, List<Activity>> Tasks { get; set; } = new();

    private bool IsColumnModal { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        // Initialize the Boards property by calling a method from the injected service
        Boards = await _bs.GetEntitiesAsync();
        ActiveBoard = Boards.ToList()[0];

        List<Section> sections = await _ss.GetEntitiesAsync();

        foreach (Section s in sections)
        {
            
            Tasks.Add(s.Name, ActiveBoard.Tasks.Where(t => t.SectionId == s.SectionId).ToList());
        }
    }

    private string SubtaskCount(Activity task)
    {
        int completed = 0;
        
        foreach(Subtask st in task.Subtasks)
        {
            if (st.Completed)
            {
                completed++;
            }   
        }

        return $"{completed} of {task.Subtasks.Count()}";
    }

    private void ToggleModal()
    {
        IsColumnModal = !IsColumnModal;
    }

    

    
    
    
}