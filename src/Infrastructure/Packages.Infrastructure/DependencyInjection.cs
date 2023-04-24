using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Packages.Application.StoryAppLayer.Gateway;
using Packages.Domain.Repositories.Command.Base;
using Packages.Domain.Repositories.Command;
using Packages.Domain.Repositories.Query.Base;
using Packages.Domain.Repositories.Query;
using Packages.Infrastructure.Data;
using Packages.Infrastructure.Repository.Command.Base;
using Packages.Infrastructure.Repository.Command;
using Packages.Infrastructure.Repository.Query.Base;
using Packages.Infrastructure.Repository.Query;
using Packages.Repository.StoryRepositories;

namespace Packages.Repository
{
    public static class DependencyInjection
    {
        public static void AddRepository(this IServiceCollection services,
        IConfiguration configuration)
        {
            services.AddDbContext<PackagesDbContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("MyDbConnectionString"));
            });
            services.AddScoped<PackagesDbContext>();
            /*services.AddScoped<IStoryRepository, StoryRepository>();*/

/*            services.AddScoped(typeof(IQueryRepository<>), typeof(QueryRepository<>));*/
            services.AddTransient<ICustomerQueryRepository, CustomerQueryRepository>();
          /*  services.AddScoped(typeof(ICommandRepository<>), typeof(CommandRepository<>));*/
            services.AddTransient<ICustomerCommandRepository, CustomerCommandRepository>();

        }
    }
}
