using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Domain.Entities;
using MediatR;

namespace ChamadosSetor8.Business.UseCases.Departments.Commands
{
    public class AddDepartmentCommand : IRequest<ApiResult<Department>>
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public static implicit operator Department(AddDepartmentCommand command)
        {
            return new Department(command.Name, command.Description);
        }
    }
}
