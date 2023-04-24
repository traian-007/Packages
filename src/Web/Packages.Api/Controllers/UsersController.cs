using MediatR;
using Microsoft.AspNetCore.Mvc;
using Packages.Api.Controllers.SeedWork;
using Packages.Application.AccountAppLayer.UseCases.UserUseCases.GetUserById;

namespace Packages.Api.Controllers
{
    public class UsersController : PackagesBaseController
    {
        [HttpGet("{id}")] //user/id
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var request = new GetUserByIdRequest { Id = id };
            var user = await Mediator.Send(request);
            return Ok(user);
        }
    }
}
