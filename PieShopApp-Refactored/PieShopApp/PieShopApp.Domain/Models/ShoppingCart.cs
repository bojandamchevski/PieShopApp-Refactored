using System.Collections.Generic;

namespace PieShopApp.Domain.Models
{
    public class ShoppingCart : BaseEntity
    {
        public List<ShoppingCartItem> ShoppingCartItems { get; set; }
    }
}
