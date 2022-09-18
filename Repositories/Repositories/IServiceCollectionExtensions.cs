using DAL_Repositories;
using DAL_Repositories.Models;
using DAL_Repositories.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public static class IServiceCollectionExtensions
    {
        public static void AddRepositories(this IServiceCollection ServiceCollection)
        {
            ServiceCollection.AddScoped<IUserRepository, UserRepository>();
            ServiceCollection.AddScoped<IAddressRepository, AddressRepository>();
            ServiceCollection.AddScoped<ICleanerRepository, CleanerRepository>();
            ServiceCollection.AddScoped<IHousekeeperRepository, HousekeeperRepository>();
            ServiceCollection.AddDbContext<ClappContext>();
            //return ServiceCollection;
        }
    }
}
