using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Business.UseCases.Groups.Queries;
using ChamadosSetor8.Business.UseCases.Users.GetAll;
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
    public class GetAllGroupHandler : IRequestHandler<GetAllGroupQuery, ApiResult<IEnumerable<Group>>>
    {
        private readonly IGroupRepository _groupRepository;
        public GetAllGroupHandler(IGroupRepository groupRepository)
        {
            _groupRepository= groupRepository;
        }

        public async Task<ApiResult<IEnumerable<Group>>> Handle(GetAllGroupQuery request, CancellationToken cancellationToken)
        {
            var apiResult = new ApiResult<IEnumerable<Group>>();

            return apiResult.SetData(await _groupRepository.GetAllAsync());
        }
    }
}