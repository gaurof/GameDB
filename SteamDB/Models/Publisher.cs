using System.ComponentModel.DataAnnotations;

namespace GameDB.Models;

public class Publisher
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(255)]
    public string Name { get; set; }

    [StringLength(100)]
    public string? Country { get; set; }

    public int? FoundedYear { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime EditedAt { get; set; } = DateTime.UtcNow;
    public DateTime? DeletedAt { get; set; }

    public List<Franchise> Franchises { get; set; } = [];
    public List<Game> Games { get; set; } = [];
}