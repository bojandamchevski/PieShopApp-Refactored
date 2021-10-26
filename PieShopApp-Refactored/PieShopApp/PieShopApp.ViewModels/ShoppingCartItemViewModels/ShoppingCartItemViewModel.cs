using PieShopApp.ViewModels.PieViewModels;

namespace PieShopApp.ViewModels.ShoppingCartItemViewModels
{
    public class ShoppingCartItemViewModel
    {
        public int IdVM { get; set; }
        public PieViewModel Pie { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
