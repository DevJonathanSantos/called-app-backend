using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Business.UseCases.Groups.Commands
{
    public class AddGroupCommand : IRequest<ApiResult<Group>>
    {
        public string Name { get;  set; }

        public static implicit operator Group(AddGroupCommand command)
        {
            return new Group(command.Name);
        }
    }
}
