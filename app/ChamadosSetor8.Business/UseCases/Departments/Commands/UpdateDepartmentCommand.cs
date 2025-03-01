using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Business.UseCases.Churchs.Add;
using ChamadosSetor8.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Business.UseCases.Departments.Commands
{
    public class UpdateDepartmentCommand : IRequest<ApiResult<Department>>
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;


        public static implicit operator Department(UpdateDepartmentCommand command)
        {
            return new Department(command.Id, command.Name, command.Description);
        }
    }
}
