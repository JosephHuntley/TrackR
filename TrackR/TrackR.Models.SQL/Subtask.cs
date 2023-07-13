using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrackR.Models.SQL;

public class Subtask : Model
{
    [Key]
    public int SubtaskId { get; set; }
    
    [ForeignKey(nameof(Section))]
    public int SectionId { get; set; }

    public virtual Section Section { get; set; } = null!;

    public int TaskId { get; set; }

    [ForeignKey(nameof(TaskId))]
    public virtual Activity Parent { get; set; } = null!;

    [MaxLength(50)]
    public string Title { get; set; } = null!;

    public string Issue { get; set; } = null!;

    public bool Completed { get; set; } = false;

    public User? Owner { get; set; }
}