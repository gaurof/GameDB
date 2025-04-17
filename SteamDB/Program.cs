using GameDB.Models;
namespace GameDB;

internal class Program
{
    static void Main()
    {
        using var dbContext = new GameDBContext();

        var valve = new Publisher() { Name = "VALVe", Country = "USA", FoundedYear = 1996 };

        dbContext.Publishers.Add(valve);


    }
}
