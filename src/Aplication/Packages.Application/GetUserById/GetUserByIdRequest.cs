using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packages.Application.GetUserById
{
    public class GetUserByIdRequest : IRequest<GetUserByIdResponse>
    {
        public int Id { get; set; }
    }
}
