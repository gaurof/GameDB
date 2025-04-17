using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GameDB.Models;

public class Achievement
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Player")]
    public int PlayerId { get; set; }
    public bool IsAchieved { get; set; }
    public DateTime UnlockedAt { get; set; } = DateTime.UtcNow;

    public required Game Game { get; set; }
}