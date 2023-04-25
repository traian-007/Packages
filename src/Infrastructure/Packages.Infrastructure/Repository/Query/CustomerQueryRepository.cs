using Microsoft.EntityFrameworkCore;
using Packages.Domain.Entities;
using Packages.Domain.Repositories.Command;
using Packages.Domain.Repositories.Query;
using Packages.Infrastructure.Data;
using Packages.Infrastructure.Repository.Query.Base;

namespace Packages.Infrastructure.Repository.Query
{
    public class CustomerQueryRepository : QueryRepository<Customer>, ICustomerQueryRepository
    {
        private readonly PackagesDbContext _context;

        public CustomerQueryRepository(PackagesDbContext context) : base(context)
        {
            _context = context;
        }
        public async Task<IReadOnlyList<Customer>> GetAllAsync()
        {
            return await _context.Customer.ToListAsync();
        }

        public async Task<Customer> GetByIdAsync(Guid id)
        {
            var customer = await _context.Customer.FirstOrDefaultAsync(x => x.Id == id);
            if (customer == null)
            {
                return null;
            }

            return customer;
        }

        public async Task<Customer> GetCustomerByEmail(string email)
        {
            var customer = await _context.Customer.FirstOrDefaultAsync(x => x.Email == email);
            if (customer == null)
            {
                return null;
            }

            return customer;
        }
    }
}
