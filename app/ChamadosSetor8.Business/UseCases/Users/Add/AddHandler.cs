using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Business.UseCases.Users.GetById;
using ChamadosSetor8.Domain.Entities;
using ChamadosSetor8.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Business.UseCases.Users.Add;

public class AddHandler : IRequestHandler<AddCommand, ApiResult<User>>
{
    private readonly IUserRepository _userRepository;
    private readonly IChurchRepository _churchRepository;
    public AddHandler(IUserRepository userRepository, IChurchRepository churchRepository)
    {
        _userRepository = userRepository;
        _churchRepository = churchRepository;
    }

    public async Task<ApiResult<User>> Handle(AddCommand command, CancellationToken cancellationToken)
    {

        var apiResult = new ApiResult<User>();


        var user = ((User)command);

        var churchs = await _churchRepository.GetByIdsAsync(command.ChurchIds);

        var userResponse = await _userRepository.AddAsync(user);

        await _userRepository.SaveAsync();

        return apiResult.SetData(userResponse);
    }
}
