using System;
using System.Linq;
using Lesson_2.Abstract;
using Lesson_2.Models;
using Lesson_2.Stock;

namespace Lesson_2.Services
{
    public class CartRepository :ICartRepository
    {
        private readonly CartStock _cartStock;

        public CartRepository(CartStock cartStock)
        {
            _cartStock = cartStock;
        }

        public CartRepository() {}

        public Cart Get()
        {
            return _cartStock.Carts.First();
        }

        public void Add(Game game)
        {
            Cart cart;

            if (_cartStock.Carts.Any())
            {
                cart = _cartStock.Carts.First();
                cart.Games.Add(game);
            }
            else
            {
                cart = new Cart();
                cart.Games.Add(game);
                _cartStock.Carts.Add(cart);
            }

            _cartStock.Save();
        }

        public void DeleteGame(Game game)
        {
            //_cartStock.Games.Remove(game);
            _cartStock.Carts.First().Games.Remove(game);
            _cartStock.Save();
        }
    }
}
