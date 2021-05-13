using System;
using System.Collections.Generic;
using Lesson_2.Models;

namespace Lesson_2.Abstract
{
    public interface IGameRepository
    {
        IEnumerable<Game> Get();

        Game GetById(int id);

        void Add(Game game);

        void Delete(Game game);

        void Update(Game game);
    }
}
