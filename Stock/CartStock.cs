using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Lesson_2.Models;

namespace Lesson_2.Stock
{
    public class CartStock
    {
        public ICollection<Cart> Carts { get; }
        public object Games { get; internal set; }

        string jsonPath = "~\\Storage\\CartStock.json";

        public CartStock()
        {
            Carts = JsonSerializer.Deserialize<List<Cart>>(new StreamReader(jsonPath).ReadToEnd());
        }

        public void Save()
        {
            using (StreamWriter writter = new StreamWriter(jsonPath))
            {
                writter.WriteLine(JsonSerializer.Serialize<ICollection<Game>>(Carts));
            }
        }
    }
}
