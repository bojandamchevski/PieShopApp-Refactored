using PieShopApp.DataAccess.Interfaces;
using PieShopApp.Mappers;
using PieShopApp.Services.Interfaces;
using PieShopApp.ViewModels.CategoryViewModels;
using PieShopApp.ViewModels.PieViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PieShopApp.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private ICategoryRepository _categoryRepository;
        private IPieRepository _pieRepository;

        public CategoryService(ICategoryRepository categoryRepository, IPieRepository pieRepository)
        {
            _categoryRepository = categoryRepository;
            _pieRepository = pieRepository;
        }

        public PieListViewModel GetPieList(string category)
        {
            IEnumerable<PieViewModel> pies;
            string currentCategory;
            if (string.IsNullOrEmpty(category))
            {
                pies = _pieRepository.GetAll().Select(x => x.ToPieViewModel()).OrderBy(x => x.IdVM);
                currentCategory = "All pies";
            }
            else
            {
                pies = _pieRepository.GetAll().Where(x => x.Category.CategoryName == category)
                    .Select(x => x.ToPieViewModel()).OrderBy(x => x.IdVM);
                currentCategory = _categoryRepository.GetAll().FirstOrDefault(x => x.CategoryName == category)?.CategoryName;
            }

            return new PieListViewModel() { Pies = pies, CurrentCategory = currentCategory };
        }
    }
}
