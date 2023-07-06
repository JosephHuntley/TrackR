using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrackR.Models.SQL;

public class Board : Model
{
    [Key]
    public int BoardId { get; set; }

    public string Name { get; set; } = null!;

    [InverseProperty("Parent")]
    public ICollection<Activity> Tasks { get; set; } = null!;
}