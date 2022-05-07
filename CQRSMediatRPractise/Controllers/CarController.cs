using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CQRSMediatRPractise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CarController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
