using PieShopApp.ViewModels.PieViewModels;
using System.Collections.Generic;

namespace PieShopApp.ViewModels.CategoryViewModels
{
    public class PieListViewModel
    {
        public IEnumerable<PieViewModel> Pies { get; set; }
        public string CurrentCategory { get; set; }
    }
}
