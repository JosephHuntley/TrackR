using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrackR.Models.SQL;

public class Activity : Model
{
    [Key]
    public int ActivityId { get; set; }
    
    [ForeignKey(nameof(Section))]
    public int SectionId { get; set; }

    public virtual Section Section { get; set; } = null!;

    public int BoardId { get; set; }

    [ForeignKey(nameof(BoardId))]
    public virtual Board? Parent { get; set; }

    public int? UserId { get; set; }

    [ForeignKey(nameof(UserId))]
    public virtual User? Owner { get; set; }

    [MaxLength(50)]
    public string Title { get; set; } = null!;

    public string Issue { get; set; } = null!;

    public virtual ICollection<Subtask> Subtasks { get; set; } = new List<Subtask>();
}