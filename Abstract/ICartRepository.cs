using System;
using Lesson_2.Models;

namespace Lesson_2.Abstract
{
    public interface ICartRepository
    {
        Cart Get();
        void Add(Game game);

        void DeleteGame(Game game);
    }
}
