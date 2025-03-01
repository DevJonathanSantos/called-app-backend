using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Business.UseCases.Groups.Queries;
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
    public class GetByIdGroupHandler : IRequestHandler<GetByIdGroupQuery, ApiResult<Group>>
    {
        private readonly IGroupRepository _groupRepository;
        public GetByIdGroupHandler(IGroupRepository groupRepository)
        {
            _groupRepository = groupRepository;
        }
        public async Task<ApiResult<Group>> Handle(GetByIdGroupQuery request, CancellationToken cancellationToken)
        {
            var apiResul = new ApiResult<Group>();

            return apiResul.SetData(await _groupRepository.GetByIdAsync(request.Id));
        }
    }
}