using ChamadosSetor8.Business.UseCases.Departments.Commands;
using ChamadosSetor8.Business.UseCases.Departments.Queries;
using ChamadosSetor8.Business.UseCases.Groups.Commands;
using ChamadosSetor8.Business.UseCases.Groups.Queries;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChamadosSetor8.Api.Controllers
{
    [Route("api/department")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public DepartmentController(IMediator mediator)
        {
            this._mediator = mediator;

        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var query = new GetAllDepartmentQuery();

            return Ok(await _mediator.Send(query));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetbyId(int id)
        {
            var query = new GetByIdDepartmentQuery
            {
                Id = id
            };

            return Ok(await _mediator.Send(query));
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] AddDepartmentCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateDepartmentCommand command)
        {
            return Ok(await _mediator.Send(command));
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody] AddDepartmentCommand command)
        {
            return Ok(await _mediator.Send(command));
        }
    }
}