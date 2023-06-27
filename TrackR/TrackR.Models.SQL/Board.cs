using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrackR.Models.SQL;

public class Board
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    [InverseProperty("Board")]
    public ICollection<Task> Tasks { get; set; } = null!;

}