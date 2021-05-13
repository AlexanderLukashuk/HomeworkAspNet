using System;
using Lesson_2.Services;
using Lesson_2.Abstract;
using Lesson_2.Models;
using System.Collections.Generic;
using Lesson_2.Stock;
using System.Linq;

namespace Lesson_2.Services
{
    public class GameRepository : IGameRepository
    {
        private readonly GameStock _gameStock;

        public GameRepository(GameStock gameStock)
        {
            _gameStock = gameStock;
        }

        public void Add(Game game)
        {
            _gameStock.Games.Add(game);
        }

        public void Delete(Game game)
        {
            _gameStock.Games.Remove(game);
        }

        public IEnumerable<Game> Get()
        {
            return _gameStock.Games.AsEnumerable();
        }

        Game IGameRepository.GetById(int id)
        {
            return _gameStock.Games.FirstOrDefault(x => x.GameId == id);
        }

        int IGameRepository.GetLastGameId()
        {
            return _gameStock.Games.Count();
        }
    }
}
