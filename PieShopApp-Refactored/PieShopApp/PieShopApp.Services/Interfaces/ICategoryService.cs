using PieShopApp.ViewModels.CategoryViewModels;
using System.Collections.Generic;

namespace PieShopApp.Services.Interfaces
{
    public interface ICategoryService
    {
        PieListViewModel GetPieList(string category);
    }
}
