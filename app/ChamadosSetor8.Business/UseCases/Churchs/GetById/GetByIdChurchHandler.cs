using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Domain.Entities;
using ChamadosSetor8.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Business.UseCases.Churchs.GetById
{
    public class GetByIdGroupHandler : IRequestHandler<GetByIdChurchQuery, ApiResult<Church>>
    {
        private readonly IChurchRepository _churchRepository;
        public GetByIdGroupHandler(IChurchRepository churchRepository)
        {
            _churchRepository = churchRepository;
        }
        public async Task<ApiResult<Church>> Handle(GetByIdChurchQuery request, CancellationToken cancellationToken)
        {
            var apiResul = new ApiResult<Church>();

            return apiResul.SetData(await _churchRepository.GetByIdAsync(request.Id));
        }
    }
}