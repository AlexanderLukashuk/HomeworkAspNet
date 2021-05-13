using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson_2.Abstract;
using Lesson_2.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lesson_2.Controllers
{
    public class GamesController : Controller
    {
        private readonly IGameRepository _gameRepository;

        public GamesController(IGameRepository gameRepository)
        {
            _gameRepository = gameRepository;
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var game = _gameRepository.GetById(id);
            return View(game);
        }

        public IActionResult Edit(int id)
        {
            var game = _gameRepository.GetById(id);
            return View(game);
        }

        [HttpPost]
        public IActionResult Edit([FromForm] Game editedGame)
        {
            return RedirectToAction("Details", "Games",
                new { id = editedGame.GameId });
        }

        [HttpPost]
        public IActionResult CreateGame(string name, string description, string categpry, decimal price)
        {
            Game game = new Game(_gameRepository.GetLastGameId(), name, description,categpry, price);
            return View(game);
        }
    }
}
