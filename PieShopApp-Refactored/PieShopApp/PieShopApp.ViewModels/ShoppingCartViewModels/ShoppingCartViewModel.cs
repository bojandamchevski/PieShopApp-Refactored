using PieShopApp.ViewModels.ShoppingCartItemViewModels;
using System.Collections.Generic;

namespace PieShopApp.ViewModels.ShoppingCartViewModels
{
    public class ShoppingCartViewModel
    {
        public int IdVM { get; set; }
        public List<ShoppingCartItemViewModel> ShoppingCartItems { get; set; }
    }
}
