using Microsoft.EntityFrameworkCore;
using GameDB.Models;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace GameDB;

public class GameDBContext : DbContext
{
    public DbSet<Publisher> Publishers { get; set; }
    public DbSet<Franchise> Franchises { get; set; }
    public DbSet<Game> Games { get; set; }
    public DbSet<Player> Players { get; set; }
    public DbSet<Save> PlayerSaves { get; set; }
    public DbSet<Achievement> Achievements { get; set; }
    public DbSet<Achievement> PlayerAchievements { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Save>()
            .HasIndex(ps => new { ps.PlayerId, ps.GameId })
            .IsUnique();

        modelBuilder.Entity<Achievement>()
            .HasIndex(pa => new { pa.PlayerId, pa.Id })
            .IsUnique();
    }
    public GameDBContext()
    {
        Database.EnsureCreated();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        var connectionString = "Server=localhost;Database=game_db;Uid=root;Pwd=123qweasd;";
        optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }
}