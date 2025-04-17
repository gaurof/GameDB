using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameDB.Models;

public class Game
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(255)]
    public string Title { get; set; }

    [ForeignKey("Franchise")]
    public int? FranchiseId { get; set; }

    [ForeignKey("Publisher")]
    public int PublisherId { get; set; }

    public DateOnly? ReleaseDate { get; set; }

    [StringLength(100)]
    public string? Genre { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime EditedAt { get; set; } = DateTime.UtcNow;
    public DateTime? DeletedAt { get; set; }

    public Franchise? Franchise { get; set; }
    public Publisher Publisher { get; set; }
    public List<Save> PlayerSaves { get; set; } = [];
    public List<Achievement> Achievements { get; set; } = [];
}