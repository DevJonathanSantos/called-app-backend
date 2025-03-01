using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Business.UseCases.Groups.Commands;
using ChamadosSetor8.Domain.Entities;
using ChamadosSetor8.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Business.UseCases.Groups.Handlers
{
    public class UpdateGroupHandler : IRequestHandler<UpdateGroupCommand, ApiResult<Group>>
    {
        private readonly IGroupRepository _groupRepository;

        public UpdateGroupHandler(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }
        public async Task<ApiResult<Group>> Handle(UpdateGroupCommand command, CancellationToken cancellationToken)
        {
            var apiResult = new ApiResult<Group>();

            await _groupRepository.UpdateAsync(command);

            return apiResult;

        }
    }
}
