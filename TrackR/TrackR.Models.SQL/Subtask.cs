using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrackR.Models.SQL;

public class Subtask
{
    [Key]
    public int SubtaskId { get; set; }

    public int TaskId { get; set; }

    [ForeignKey("TaskId")] 
    public virtual Activity Parent { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Issue { get; set; } = null!;
    
    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }
}