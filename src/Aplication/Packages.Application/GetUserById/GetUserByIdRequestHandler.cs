using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Packages.Application.GetUserById
{
    public class GetUserByIdRequestHandler : IRequestHandler<GetUserByIdRequest, GetUserByIdResponse>
    {
/*        public Task<GetUserByIdResponse> Handle(GetUserByIdRequest request, CancellationToken cancellationToken)
        {
            var user = new GetUserByIdResponse
            {
                Id = request.Id,
                Name = "John"
            };

            return Task.FromResult(user);
        }*/
        Task<GetUserByIdResponse> IRequestHandler<GetUserByIdRequest, GetUserByIdResponse>.Handle(GetUserByIdRequest request, CancellationToken cancellationToken)
        {
            var user = new GetUserByIdResponse
            {
                Id = request.Id,
                Name = "John"
            };

            return Task.FromResult(user);
        }
    }
}
