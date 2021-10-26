namespace PieShopApp.Domain.Models
{
    public class ShoppingCartItem : BaseEntity
    {
        public Pie Pie { get; set; }
        public int Amount { get; set; }
        public string ShoppingCartId { get; set; }
    }
}
