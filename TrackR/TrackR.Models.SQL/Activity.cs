using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrackR.Models.SQL;

public class Activity
{
    [Key]
    public int Id { get; set; }
    
    public int BoardId { get; set; }

    [ForeignKey("BoardId")] 
    public Board Parent { get; set; } = null!;
    
    public int UserId { get; set; }
    
    [ForeignKey("UserId")]
    public virtual User? Owner { get; set; }

    public string Title { get; set; } = null!;

    public string Issue { get; set; } = null!;

    public ICollection<Subtask> Subtasks { get; set; } = null!;

    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }
}