using ChamadosSetor8.Business.UseCases.Users;
using ChamadosSetor8.Business.UseCases.Users.Add;
using ChamadosSetor8.Business.UseCases.Users.GetAll;
using ChamadosSetor8.Business.UseCases.Users.GetById;
using ChamadosSetor8.Business.UseCases.Users.Update;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ChamadosSetor8.Api.Controllers;

[Route("api/user")]
[ApiController]
public class UserController : BaseController
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator)
    {
        this._mediator = mediator;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var query = new GetAllQuery();

        return Ok(await _mediator.Send(query));
    }

    [HttpGet("{id:int}")]
    public IActionResult GetbyId(int id)
    {
        var query = new GetByIdQuery
        {
            Id = id
        };

        return Ok(_mediator.Send(query));
    }

    [HttpPost]
    public async Task<IActionResult> Add([FromBody] AddCommand command)
    {
        return Ok(await _mediator.Send(command));
    }

    [HttpPut]
    public IActionResult Update([FromBody] UpdateCommand command)
    {
        return Ok(_mediator.Send(command));
    }

    [HttpDelete]
    public IActionResult Delete([FromBody] AddCommand command)
    {
        return Ok(_mediator.Send(command));
    }
}
