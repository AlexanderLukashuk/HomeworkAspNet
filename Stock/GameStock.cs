using System;
using System.Collections.Generic;
using System.IO;
using Lesson_2.Models;
using Microsoft.Extensions.Configuration;
using System.Text.Json;

namespace Lesson_2.Stock
{
    public class GameStock
    {
        //public ICollection<Game> Games { get; set; }
        public ICollection<Game> Games { get; set; }
        //private readonly string _jsonPath;
        //private readonly IConfiguration configuration;
        string jsonPath = "~\\Storage\\GameStock.json";

        public GameStock()
        {
            /*Games = new List<Game>
            {
                new Game(1, "Call of Duty. Modern Warfare", "Cool FPS action game", "FPS", 15000m),
                new Game(2, "Diablo 3. Reaper of Souls", "The legendary RPG game from Blizzard", "RPG", 23000m),
                new Game(3, "Overwatch", "Beatiful and dynamic FPS action game", "FPS", 5000m),
                new Game(4, "Civilization 6", "The king of p2p strategy games", "Strategy", 2500m),
                new Game(5, "Star Craft", "Awake your nastalgy and save the galaxy", "RTS", 1200m)
            };*/

            //string projectDirectory = Directory.GetParent(Environment.CurrentDirectory)?.Parent?.Parent?.FullName;
            //_jsonPath = $@"{projectDirectory}\{_}"

            Games = JsonSerializer.Deserialize<List<Game>>(new StreamReader(jsonPath).ReadToEnd());
        }

        public void Save()
        {
            using (StreamWriter writter = new StreamWriter(jsonPath))
            {
                writter.WriteLine(JsonSerializer.Serialize<ICollection<Game>>(Games));
            }
        }
    }
}
