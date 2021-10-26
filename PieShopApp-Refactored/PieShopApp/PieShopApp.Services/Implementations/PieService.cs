using PieShopApp.DataAccess.Implementations;
using PieShopApp.DataAccess.Interfaces;
using PieShopApp.Domain.Models;
using PieShopApp.Mappers;
using PieShopApp.Services.Interfaces;
using PieShopApp.ViewModels.PieViewModels;
using System.Collections.Generic;
using System.Linq;

namespace PieShopApp.Services.Implementations
{
    public class PieService : IPieService
    {
        private IPieRepository _pieRepository;

        public PieService(IPieRepository pieRepository)
        {
            _pieRepository = pieRepository;
        }

        public PieViewModel GetPieById(int id)
        {
            return _pieRepository.GetPieById(id).ToPieViewModel();
        }

        public List<PieViewModel> GetPiesOfTheWeek() => _pieRepository.GetPiesOfTheWeek().Select(x => x.ToPieViewModel()).ToList();
    }
}
