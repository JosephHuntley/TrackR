using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrackR.Models.SQL;

public class Activity : Model
{
    [Key]
    public int TaskId { get; set; }

    public int BoardId { get; set; }
    
    [ForeignKey("BoardId")] 
    public virtual Board Parent { get; set; } = null!;
    public int? UserId { get; set; } = 0;
    
    [ForeignKey("UserId")]
    public virtual User? Owner { get; set; }

    public string Title { get; set; } = null!;

    public string Issue { get; set; } = null!;

    public virtual ICollection<Subtask> Subtasks { get; set; } = null!;
}