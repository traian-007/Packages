using Packages.Domain.Entities;
using Packages.Domain.Repositories.Command.Base;

namespace Packages.Domain.Repositories.Command
{
    public interface ICustomerCommandRepository : ICommandRepository<Contact>
    {
    }
}
