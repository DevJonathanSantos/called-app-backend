using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Business.UseCases.Churchs.Add;
using ChamadosSetor8.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Business.UseCases.Groups.Commands
{
    public class UpdateGroupCommand: IRequest<ApiResult<Group>>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
       

        public static implicit operator Group(UpdateGroupCommand command)
        {
            return new Group(command.Id, command.Name);
        }
    }
}
