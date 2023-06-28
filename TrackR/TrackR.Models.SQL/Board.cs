using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TrackR.Models.SQL;

public class Board
{
    [Key]
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    [InverseProperty("Parent")]
    public ICollection<Activity> Tasks { get; set; } = null!;
    
    public DateTime CreatedDate { get; set; }

    public DateTime UpdatedDate { get; set; }

}