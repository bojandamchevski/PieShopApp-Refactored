using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PieShopApp.DataAccess;
using PieShopApp.DataAccess.Implementations;
using PieShopApp.DataAccess.Interfaces;
using PieShopApp.Services.Implementations;
using PieShopApp.Services.Interfaces;

namespace PieShopApp.Helpers
{
    public static class DependencyInjectionHelper
    {
        public static void InjectRepositories(IServiceCollection services)
        {
            services.AddScoped<IPieRepository, PieRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
        }
        
        public static void InjectServices(IServiceCollection services)
        {
            services.AddScoped<IPieService, PieService>();
            services.AddScoped<ICategoryService, CategoryService>();
        }

        public static void InjectDbContext(IServiceCollection services, string connectionString)
        {
            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(connectionString));
        }
    }
}
