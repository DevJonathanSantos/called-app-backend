using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Business.UseCases.Departments.Commands;
using ChamadosSetor8.Business.UseCases.Groups.Commands;
using ChamadosSetor8.Domain.Entities;
using ChamadosSetor8.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Business.UseCases.Departments.Handlers
{
    public class UpdateDepartmentHandler : IRequestHandler<UpdateDepartmentCommand, ApiResult<Department>>
    {
        private readonly IDepartmentRepository _departmentRepository;

        public UpdateDepartmentHandler(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public async Task<ApiResult<Department>> Handle(UpdateDepartmentCommand command, CancellationToken cancellationToken)
        {
            var apiResult = new ApiResult<Department>();

            await _departmentRepository.UpdateAsync(command);

            return apiResult;

        }
    }
}
