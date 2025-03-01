using ChamadosSetor8.Business.UseCases.Churchs.Add;
using ChamadosSetor8.Business.UseCases.Churchs.GetAll;
using ChamadosSetor8.Business.UseCases.Churchs.GetById;
using ChamadosSetor8.Business.UseCases.Churchs.Update;
using ChamadosSetor8.Business.UseCases.Users.Add;
using ChamadosSetor8.Business.UseCases.Users.GetAll;
using ChamadosSetor8.Business.UseCases.Users.GetById;
using ChamadosSetor8.Business.UseCases.Users.Update;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChamadosSetor8.Api.Controllers
{
    [Route("api/church")]
    [ApiController]
    public class ChurchController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ChurchController(IMediator mediator)
        {
            this._mediator = mediator;

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllChurchQuery();

            return Ok(await _mediator.Send(query));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetbyId(int id)
        {
            var query = new GetByIdChurchQuery
            {
                Id = id
            };

            return Ok(await _mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddChurchCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateChurchCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] AddChurchCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
