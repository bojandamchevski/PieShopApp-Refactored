using PieShopApp.Domain.Models;
using System.Collections.Generic;

namespace PieShopApp.DataAccess.Interfaces
{
    public interface IPieRepository : IRepository<Pie>
    {
        IEnumerable<Pie> GetPiesOfTheWeek();
        Pie GetPieById(int pieId);
    }
}
