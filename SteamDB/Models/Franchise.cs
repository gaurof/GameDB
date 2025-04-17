using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameDB.Models;

public class Franchise
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(255)]
    public required string Name { get; set; }

    [ForeignKey("Publisher")]
    public int PublisherId { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime EditedAt { get; set; } = DateTime.UtcNow;
    public DateTime? DeletedAt { get; set; }

    public required Publisher Publisher { get; set; }
    public List<Game> Games { get; set; } = [];
}