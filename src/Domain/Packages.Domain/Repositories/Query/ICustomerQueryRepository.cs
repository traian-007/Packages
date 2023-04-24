using Packages.Domain.Entities;
using Packages.Domain.Repositories.Query.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packages.Domain.Repositories.Query
{
    public interface ICustomerQueryRepository : IQueryRepository<Customer>
    {
        //Custom operation which is not generic
        Task<IReadOnlyList<Customer>> GetAllAsync();
        Task<Customer> GetByIdAsync(Guid id);
        Task<Customer> GetCustomerByEmail(string email);
    }
}
