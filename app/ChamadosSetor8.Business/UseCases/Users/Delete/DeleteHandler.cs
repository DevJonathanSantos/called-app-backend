using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Business.UseCases.Users.Delete;
using ChamadosSetor8.Business.UseCases.Users.Update;
using ChamadosSetor8.Domain.Entities;
using ChamadosSetor8.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Business.UseCases.Users.Delete;


public class DeleteHandler : IRequestHandler<DeleteCommand, ApiResult>
{
    private readonly IUserRepository _userRepository;
    public DeleteHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<ApiResult> Handle(DeleteCommand command, CancellationToken cancellationToken)
    {
        var apiResult = new ApiResult();

        await _userRepository.DeleteAsync(command.Id);

        return apiResult;
    }
}
