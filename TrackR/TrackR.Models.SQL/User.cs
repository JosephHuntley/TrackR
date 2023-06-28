
using System.ComponentModel.DataAnnotations;

namespace TrackR.Models.SQL;

public class User
{
    [Key]
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Password { get; set; } = null!;

    public byte[] Salt { get; set; } = null!;

    public DateTime CreatedDate { get; set; }
    
    public DateTime UpdatedDate { get; set; }

}