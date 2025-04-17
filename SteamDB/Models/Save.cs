using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace GameDB.Models;

public class Save
{
    [Key]
    public int Id { get; set; }

    [ForeignKey("Player")]
    public int PlayerId { get; set; }

    [ForeignKey("Game")]
    public int GameId { get; set; }

    public required string SaveData { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    public DateTime? EditedAt { get; set; }
    public DateTime? DeletedAt { get; set; }
}