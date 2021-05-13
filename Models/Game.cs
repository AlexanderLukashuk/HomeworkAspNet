using System;
namespace Lesson_2.Models
{
    public class Game
    {
        public Game() {}
        public int GameId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }

        public Game(int gameId, string name, string description, string category, decimal price)
        {
            GameId = gameId;
            Name = name;
            Description = description;
            Category = category;
            Price = price;
        }
    }
}
