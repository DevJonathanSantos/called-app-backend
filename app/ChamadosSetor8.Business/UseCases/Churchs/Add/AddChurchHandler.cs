using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Domain.Entities;
using ChamadosSetor8.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Business.UseCases.Churchs.Add
{
    public class AddChurchHandler : IRequestHandler<AddChurchCommand, ApiResult<Church>>
    {
        private readonly IChurchRepository _churchRepository;

        public AddChurchHandler(IChurchRepository churchRepository)
        {
            _churchRepository = churchRepository;
        }
        public async Task<ApiResult<Church>> Handle(AddChurchCommand command, CancellationToken cancellationToken)
        {
            var apiResult = new ApiResult<Church>();

            apiResult.SetData(await _churchRepository.AddAsync(command));

            await _churchRepository.SaveAsync();

            return apiResult;

        }
    }
}
