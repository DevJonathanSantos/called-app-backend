using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Business.UseCases.Churchs.Add;
using ChamadosSetor8.Business.UseCases.Churchs.Delete;
using ChamadosSetor8.Domain.Entities;
using ChamadosSetor8.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Business.UseCases.Churchs.Update
{
    public class UpdateGroupHandler : IRequestHandler<UpdateChurchCommand, ApiResult<Church>>
    {
        private readonly IChurchRepository _churchRepository;

        public UpdateGroupHandler(IChurchRepository churchRepository)
        {
            _churchRepository = churchRepository;
        }
        public async Task<ApiResult<Church>> Handle(UpdateChurchCommand command, CancellationToken cancellationToken)
        {
            var apiResult = new ApiResult<Church>();

            await _churchRepository.UpdateAsync(command);

            return apiResult;

        }
    }
}