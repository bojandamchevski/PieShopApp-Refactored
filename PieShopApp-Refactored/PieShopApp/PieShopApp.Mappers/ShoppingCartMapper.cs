using PieShopApp.Domain.Models;
using PieShopApp.ViewModels.ShoppingCartViewModels;
using System.Linq;

namespace PieShopApp.Mappers
{
    public static class ShoppingCartMapper
    {
        public static ShoppingCart ToShoppingCart(this ShoppingCartViewModel shoppingCartViewModel)
        {
            return new ShoppingCart()
            {
                Id = shoppingCartViewModel.IdVM,
                ShoppingCartItems = shoppingCartViewModel.ShoppingCartItems.Select(x=>x.ToShoppingCartItem()).ToList()
            };
        }
    }
}
