using System.Collections.Generic;

namespace PieShopApp.DataAccess.Interfaces
{
    public interface IRepository<T>
    {
        IEnumerable<T> GetAll();
    }
}
