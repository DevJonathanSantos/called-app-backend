using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Business.UseCases.Users.GetAll;
using ChamadosSetor8.Domain.Entities;
using ChamadosSetor8.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Business.UseCases.Users.GetById;

public class GetByIdHandler : IRequestHandler<GetByIdQuery, ApiResult<User>>
{
    private readonly IUserRepository _userRepository;
    public GetByIdHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<ApiResult<User>> Handle(GetByIdQuery query, CancellationToken cancellationToken)
    {
        var apiResult = new ApiResult<User>();

        return apiResult.SetData(await _userRepository.GetByIdAsync(query.Id));
    }
}
