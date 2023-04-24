using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packages.Application.AccountAppLayer.UseCases.UserUseCases.GetUserById
{
    internal class GetUserByIdResponse
    {
        public int Id { get; set; }
        public string? Name { get; set; }
    }
}
