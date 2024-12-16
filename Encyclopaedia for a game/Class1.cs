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
            public static readonly string Filepath = @"C:\Users\solly\source\repos\Encyclopaedia for a game\Encyclopaedia for a game\Data\GameEntries.json";
        }
    }

    public class GameEntry
    {
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public string? Length { get; set; }
    }
}
