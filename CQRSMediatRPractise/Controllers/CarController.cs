using System.Threading.Tasks;
using CQRSMediatRPractise.MediatR.Commands;
using CQRSMediatRPractise.MediatR.Queries;
using CQRSMediatRPractise.Models;
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

        [HttpGet("id")]
        public async Task<IActionResult> Get(int id)
        {
            var query = new GetCarByIdQuery
            {
                Id = id
            };
            return Ok(await _mediator.Send(query));
        }
        [HttpGet()]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllCarQuery();
            return Ok(await _mediator.Send(query));
        }

        [HttpPost()]
        public async Task<IActionResult> Post(Car car)
        {
            var command = new CreateCarCommand
            {
                Name = car.Name,
                HP = car.HP,
                Weight = car.Weight
            };
            return Ok(await _mediator.Send(command));
        }
    }
}
