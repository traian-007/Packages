using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Packages.Api.Controllers.SeedWork
{
    [ApiController]
    [Route("[controller]")]
    public class PackagesBaseController: ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();
    }
}
