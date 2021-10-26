using Microsoft.EntityFrameworkCore;
using PieShopApp.DataAccess.Interfaces;
using PieShopApp.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace PieShopApp.DataAccess.Implementations
{
    public class PieRepository : IPieRepository
    {
        private AppDbContext _appDbContext;

        public PieRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Pie> GetAll() => _appDbContext.Pies.Include(x => x.Category);

        public Pie GetPieById(int pieId) => _appDbContext.Pies.FirstOrDefault(x => x.Id == pieId);

        public IEnumerable<Pie> GetPiesOfTheWeek() => _appDbContext.Pies
            .Include(x => x.Category)
            .Where(x => x.IsPieOfTheWeek);
    }
}
