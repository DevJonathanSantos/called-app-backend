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

namespace ChamadosSetor8.Business.UseCases.Churchs.GetAll
{
    public class GetAllChurchHandler : IRequestHandler<GetAllChurchQuery, ApiResult<IEnumerable<Church>>>
    {
        private readonly IChurchRepository _churchRepository;
        public GetAllChurchHandler(IChurchRepository churchRepository)
        {
            _churchRepository = churchRepository;
        }

        public async Task<ApiResult<IEnumerable<Church>>> Handle(GetAllChurchQuery request, CancellationToken cancellationToken)
        {
            var apiResult = new ApiResult<IEnumerable<Church>>();

            return apiResult.SetData(await _churchRepository.GetAllAsync());
        }
    }
}