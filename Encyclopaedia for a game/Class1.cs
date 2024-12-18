using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encyclopaedia_for_a_game
{
    internal class GameEntries
    {
        public static class GameEnriesFile
        {
            public static string Direct = Directory.GetCurrentDirectory();
            public static string Filepath = Path.Combine(Direct,"GameEntries.json");
        }
    }
    public class GameEntry
    {
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public string? Length { get; set; }
    }
}
