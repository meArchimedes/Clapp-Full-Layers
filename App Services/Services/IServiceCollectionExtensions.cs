using App_Services.Profiles;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repositories;


namespace App_Services.Services
{
    public static class IServiceCollectionExtensions
    {
        public static void AddAppServices(this IServiceCollection ServiceCollection)
        {
            ServiceCollection.AddScoped<IUserService,UserService>();
            ServiceCollection.AddScoped<IAddressService, AddressService>();
            ServiceCollection.AddScoped<ICleanerService, CleanerService>();
            ServiceCollection.AddScoped<IHousekeeperService, HousekeeperService>();
            ServiceCollection.AddAutoMapper(config => config.AddProfile<UserProfile>());
            ServiceCollection.AddAutoMapper(config => config.AddProfile<AddressProfile>());
            ServiceCollection.AddAutoMapper(config => config.AddProfile<CleanerProfile>());
            ServiceCollection.AddAutoMapper(config => config.AddProfile<HousekeeperProfile>());
            ServiceCollection.AddRepositories();
            //return ServiceCollection;
        }
    }
}
