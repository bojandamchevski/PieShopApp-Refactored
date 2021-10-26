using PieShopApp.Domain.Models;
using PieShopApp.ViewModels.ShoppingCartItemViewModels;

namespace PieShopApp.Mappers
{
    public static class ShoppingCartItemMapper
    {
        public static ShoppingCartItem ToShoppingCartItem(this ShoppingCartItemViewModel shoppingCartItemViewModel)
        {
            return new ShoppingCartItem()
            {
                Id = shoppingCartItemViewModel.IdVM,
                Amount = shoppingCartItemViewModel.Amount,
                ShoppingCartId = shoppingCartItemViewModel.ShoppingCartId,
                Pie = shoppingCartItemViewModel.Pie.ToPie()
            };
        }
    }
}
