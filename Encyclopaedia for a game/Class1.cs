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
            static public string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            static public string Filepath = Path.Combine(path, "GameEntries.json");
        }
    }
    public class GameEntry
    {
        public string? Title { get; set; }
        public string? Genre { get; set; }
        public string? Length { get; set; }
    }
}
