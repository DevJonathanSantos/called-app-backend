using ChamadosSetor8.Domain.Entities;
using ChamadosSetor8.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChamadosSetor8.Business.Common;

namespace ChamadosSetor8.Business.UseCases.Users.GetAll;

public class GetAllHandler : IRequestHandler<GetAllQuery, ApiResult<IEnumerable<GetAllResponse>>>
{
    private readonly IUserRepository _userRepository;
    public GetAllHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<ApiResult<IEnumerable<GetAllResponse>>> Handle(GetAllQuery request, CancellationToken cancellationToken)
    {
        var apiResult = new ApiResult<IEnumerable<GetAllResponse>>();

        var users = await _userRepository.GetAllCompleteAsync();

        var userResponse = users.Select(x => new GetAllResponse
        {
            Id = x.Id,
            Name = x.Name,
            Email = x.EmailAddress,
            CreationDate = x.CreationDate,
            UpdateDate = x.UpdateDate,
            DepartmentId = x.Department.Id,
            DepartmentName = x.Department.Name,
            ProfileId = x.Profile.Id,
            ProfileName = x.Profile.Name,
        });

        return apiResult.SetData(userResponse);
    }
}
