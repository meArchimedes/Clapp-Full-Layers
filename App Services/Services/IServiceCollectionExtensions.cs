using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repositories;


namespace App_Services.Services
{
    public static class IServiceCollectionExtensions
    {
        public static void AddAppServices(this IServiceCollection ServiceCollection)
        {
            ServiceCollection.AddScoped<ICleanerService, CleanerService>();
            ServiceCollection.AddScoped<IHousekeeperService, HousekeeperService>();
            ServiceCollection.AddRepositories();
            //return ServiceCollection;
        }
    }
}
