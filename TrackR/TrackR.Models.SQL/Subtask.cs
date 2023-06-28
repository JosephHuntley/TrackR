using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrackR.Models.SQL;

public class Subtask
{
    [Key]
    public int Id { get; set; }
    
    public int ActivityId { get; set; }

    [ForeignKey("ActivityId")] 
    public virtual Activity Parent { get; set; } = null!;

    public string Title { get; set; } = null!;

    public string Issue { get; set; } = null!;
    
    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }
}