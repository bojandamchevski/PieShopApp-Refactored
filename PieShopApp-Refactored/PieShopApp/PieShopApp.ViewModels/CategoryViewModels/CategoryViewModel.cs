using PieShopApp.ViewModels.PieViewModels;
using System.Collections.Generic;

namespace PieShopApp.ViewModels.CategoryViewModels
{
    public class CategoryViewModel
    {
        public int IdVM { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<PieViewModel> Pies { get; set; }
    }
}
