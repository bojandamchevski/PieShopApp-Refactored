using Microsoft.AspNetCore.Mvc;
using PieShopApp.DataAccess.Interfaces;
using PieShopApp.Mappers;
using System.Linq;

namespace PieShopApp.Components
{
    public class CategoryMenu : ViewComponent
    {
        private ICategoryRepository _categoryRepository;

        public CategoryMenu(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        public IViewComponentResult Invoke()
        {
            var categories = _categoryRepository.GetAll().Select(x=>x.ToCategoryViewModel()).OrderBy(x => x.CategoryName).ToList();

            return View(categories);
        }
    }
}
