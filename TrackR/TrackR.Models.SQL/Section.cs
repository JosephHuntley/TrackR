using System.ComponentModel.DataAnnotations;

namespace TrackR.Models.SQL;

public class Section : Model
{
    [Key]
    public int SectionId { get; set; }

    [Required] 
    public string Name { get; set; } = null!;

    public int Position { get; set; }
}