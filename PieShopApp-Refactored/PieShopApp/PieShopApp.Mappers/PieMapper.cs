using PieShopApp.Domain.Models;
using PieShopApp.ViewModels.CategoryViewModels;
using PieShopApp.ViewModels.PieViewModels;
using System.Collections.Generic;

namespace PieShopApp.Mappers
{
    public static class PieMapper
    {
        public static Pie ToPie(this PieViewModel pieViewModel)
        {
            return new Pie()
            {
                Id = pieViewModel.IdVM,
                AllergyInformation = pieViewModel.AllergyInformation,
                Category = pieViewModel.Category.ToCategory(),
                CategoryId = pieViewModel.CategoryId,
                ImageThumbnailUrl = pieViewModel.ImageThumbnailUrl,
                ImageUrl = pieViewModel.ImageUrl,
                InStock = pieViewModel.InStock,
                IsPieOfTheWeek = pieViewModel.IsPieOfTheWeek,
                LongDescription = pieViewModel.LongDescription,
                Name = pieViewModel.Name,
                Notes = pieViewModel.Notes,
                Price = pieViewModel.Price,
                ShortDescription = pieViewModel.ShortDescription
            };
        }

        public static PieViewModel ToPieViewModel(this Pie pie)
        {
            //CategoryViewModel category = pie.Category.ToCategoryViewModel();
            return new PieViewModel()
            {
                IdVM = pie.Id,
                AllergyInformation = pie.AllergyInformation,
                //Category = category,
                CategoryId = pie.CategoryId,
                ImageThumbnailUrl = pie.ImageThumbnailUrl,
                ImageUrl = pie.ImageUrl,
                InStock = pie.InStock,
                IsPieOfTheWeek = pie.IsPieOfTheWeek,
                LongDescription = pie.LongDescription,
                Name = pie.Name,
                Notes = pie.Notes,
                Price = pie.Price,
                ShortDescription = pie.ShortDescription
            };
        }
    }
}
