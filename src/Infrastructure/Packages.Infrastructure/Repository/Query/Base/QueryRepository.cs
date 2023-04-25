using Packages.Domain.Repositories.Command.Base;
using Packages.Domain.Repositories.Query.Base;
using Packages.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packages.Infrastructure.Repository.Query.Base
{
    public class QueryRepository<T> : IQueryRepository<T> where T : class
    {
        protected readonly PackagesDbContext _context;

        public QueryRepository(PackagesDbContext context)
        {
            _context = context;
        }
    }
}
