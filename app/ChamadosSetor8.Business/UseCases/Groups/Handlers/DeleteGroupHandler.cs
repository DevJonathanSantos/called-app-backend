using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Business.UseCases.Groups.Commands;
using ChamadosSetor8.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChamadosSetor8.Business.UseCases.Groups.Handlers
{
    public class DeleteGroupHandler : IRequestHandler<DeleteGroupCommand, ApiResult>
    {
        private readonly IGroupRepository _groupRepository;
        public DeleteGroupHandler(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }
        public async Task<ApiResult> Handle(DeleteGroupCommand command, CancellationToken cancellationToken)
        {
            await _groupRepository.DeleteAsync(command.Id);

            return new ApiResult<Group>();
        }
    }
}
