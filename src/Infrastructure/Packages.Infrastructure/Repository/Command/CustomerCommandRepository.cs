using Packages.Domain.Entities;
using Packages.Domain.Repositories.Command;
using Packages.Infrastructure.Data;
using Packages.Infrastructure.Repository.Command.Base;

namespace Packages.Infrastructure.Repository.Command
{
    public class CustomerCommandRepository : CommandRepository<Customer>, ICustomerCommandRepository
    {
        public CustomerCommandRepository(PackagesDbContext context) : base(context)
        {
            
        }
    }
}
