using DAL_Repositories.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repositories.Models;
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
            ServiceCollection.AddScoped<ICleanerRepository, CleanerRepository>();
            ServiceCollection.AddScoped<IHousekeeperRepository, HousekeeperRepository>();
            ServiceCollection.AddDbContext<ClappContext>();
            //return ServiceCollection;
        }
    }
}
