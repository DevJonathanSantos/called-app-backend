using ChamadosSetor8.Business.UseCases.Churchs.Add;
using ChamadosSetor8.Business.UseCases.Groups.Commands;
using ChamadosSetor8.Business.UseCases.Groups.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChamadosSetor8.Api.Controllers
{
    [Route("api/group")]
    [ApiController]
    public class GroupController : ControllerBase
    {
        private readonly IMediator _mediator;

        public GroupController(IMediator mediator)
        {
            this._mediator = mediator;

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllGroupQuery();

            return Ok(await _mediator.Send(query));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetbyId(int id)
        {
            var query = new GetByIdGroupQuery
            {
                Id = id
            };

            return Ok(await _mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddGroupCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateGroupCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] AddGroupCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}
