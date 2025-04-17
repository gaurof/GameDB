using System.ComponentModel.DataAnnotations;

namespace GameDB.Models;

public class Player
{
    [Key]
    public int Id { get; set; }

    [Required]
    [StringLength(12)]
    public string Username { get; set; }

    [Required]
    [StringLength(255)]
    public string Email { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime DeletedAt { get; set; } = DateTime.UtcNow;

    public List<Game> OwnedGames { get; set; } = [];
    public List<Achievement> Achievements { get; set; } = [];
    public List<Player> Friends { get; set; } = [];
}