using PieShopApp.Domain.Models;
using PieShopApp.ViewModels.PieViewModels;
using System.Collections.Generic;

namespace PieShopApp.Services.Interfaces
{
    public interface IPieService
    {
        List<PieViewModel> GetPiesOfTheWeek();
        PieViewModel GetPieById(int id);
    }
}
