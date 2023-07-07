using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrackR.Models.SQL;

public class Subtask : Model
{
    [Key]
    public int SubtaskID { get; set; }
    
    public StatusEnum Status { get; set; }

    public int TaskId { get; set; }

    [ForeignKey(nameof(TaskId))]
    public virtual Activity Parent { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Issue { get; set; } = null!;
}