using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Business.UseCases.Churchs.Delete
{
    public class UpdateChurchHandler : IRequestHandler<DeleteChurchCommand, ApiResult>
    {
        private readonly IChurchRepository _churchRepository;
        public UpdateChurchHandler(IChurchRepository churchRepository)
        {
                _churchRepository = churchRepository;
        }
        public async Task<ApiResult> Handle(DeleteChurchCommand command, CancellationToken cancellationToken)
        {
            await _churchRepository.DeleteAsync(command.Id);

            return new ApiResult();
        }
    }
}
