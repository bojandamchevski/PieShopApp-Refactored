using Microsoft.EntityFrameworkCore;
using PieShopApp.DataAccess.Interfaces;
using PieShopApp.Domain.Models;
using System.Collections.Generic;

namespace PieShopApp.DataAccess.Implementations
{
    public class CategoryRepository : ICategoryRepository
    {
        private AppDbContext _appDbContext;

        public CategoryRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Category> GetAll() => _appDbContext.Categories.Include(x => x.Pies);
    }
}
