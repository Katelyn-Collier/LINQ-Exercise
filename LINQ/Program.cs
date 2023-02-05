using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var games = new List<string>() { "The Elder Scrolls V: Skyrim", "League of Legends", "Dead by Daylight", "Civilization VI", "Lost Ark" };

            games = games.OrderBy(g => g.Length).ToList();

            for(int i = 0; i < games.Count; i++)
            {
                Console.WriteLine($"{games[i]}");
            }
        }
    }
}
