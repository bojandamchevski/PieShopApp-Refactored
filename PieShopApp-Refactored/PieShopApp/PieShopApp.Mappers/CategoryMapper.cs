using PieShopApp.Domain.Models;
using PieShopApp.ViewModels.CategoryViewModels;
using PieShopApp.ViewModels.PieViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PieShopApp.Mappers
{
    public static class CategoryMapper
    {
        public static Category ToCategory(this CategoryViewModel categoryViewModel)
        {
            return new Category()
            {
                Id = categoryViewModel.IdVM,
                CategoryName = categoryViewModel.CategoryName,
                Description = categoryViewModel.Description,
                Pies = categoryViewModel.Pies.Select(x => x.ToPie()).ToList()
            };
        }

        public static CategoryViewModel ToCategoryViewModel(this Category category)
        {
            List<PieViewModel> pies = category.Pies.Select(x => x.ToPieViewModel()).ToList();
            return new CategoryViewModel()
            {
                IdVM = category.Id,
                CategoryName = category.CategoryName,
                Description = category.Description,
                Pies = pies
            };
        }

        public static PieListViewModel ToPieListViewModel(this Category category)
        {
            return new PieListViewModel()
            {
                Pies = category.Pies.Select(x => x.ToPieViewModel()),
                CurrentCategory = category.CategoryName
            };
        }
    }
}
