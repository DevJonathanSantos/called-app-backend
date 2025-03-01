using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Business.UseCases.Churchs.Add;
using ChamadosSetor8.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Business.UseCases.Churchs.Update
{
    public class UpdateChurchCommand : IRequest<ApiResult<Church>>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int GroupId { get; private set; }

        public static implicit operator Church(UpdateChurchCommand command)
        {
            return new Church(command.Id, command.Name, command.Description, command.GroupId);
        }
    }
}
