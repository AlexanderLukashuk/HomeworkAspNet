using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lesson_2.Abstract;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Lesson_2.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartRepository _cartRepository;
        private readonly IGameRepository _gameRepository;

        public CartController(ICartRepository cartRepository, IGameRepository gameRepository)
        {
            _cartRepository = cartRepository;
            _gameRepository = gameRepository;
        }

        public IActionResult Index()
        {
            var cart = _cartRepository.Get();
            return View(cart);
        }

        public void Add(int gameId)
        {
            var game = _gameRepository.GetById(gameId);
            _cartRepository.Add(game);
        }
    }
}
