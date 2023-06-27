using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrackR.Models.SQL;

public class Subtask
{
    [Key]
    public int Id { get; set; }
    
    public int ParentId { get; set; }
    
    [ForeignKey("ParentID")]
    public virtual Task? Parent { get; set; }

    public string Title { get; set; } = null!;

    public string Issue { get; set; } = null!;
    
    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }
}