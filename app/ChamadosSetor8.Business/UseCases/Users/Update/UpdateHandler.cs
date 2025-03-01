using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Business.UseCases.Users.Add;
using ChamadosSetor8.Domain.Entities;
using ChamadosSetor8.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Business.UseCases.Users.Update;

public class UpdateHandler : IRequestHandler<UpdateCommand, ApiResult<User>>
{
    private readonly IUserRepository _userRepository;
    public UpdateHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<ApiResult<User>> Handle(UpdateCommand command, CancellationToken cancellationToken)
    {
        var apiResult = new ApiResult<User>();
        var user = (User)command;

        await _userRepository.UpdateAsync(user);

        return apiResult;
    }
}
