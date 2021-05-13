using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_2.Models
{
    public class Cart
    {
        public Guid Id { get; set; }
        public IList<Game> Games { get; set; }
        public string Total => $"{Games.Sum(game => game.Price)}";

        public Cart()
        {
            Id = Guid.NewGuid();
        }
    }
}
