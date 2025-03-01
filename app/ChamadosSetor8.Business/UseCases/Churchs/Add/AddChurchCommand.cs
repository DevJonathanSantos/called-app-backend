using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Business.UseCases.Churchs.Add
{
    public class AddChurchCommand: IRequest<ApiResult<Church>>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public int GroupId { get;  set; }

        public static implicit operator Church(AddChurchCommand command)
        {
            return new Church(command.Name, command.Description, command.GroupId);
        }

    }
}
