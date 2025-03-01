using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Business.UseCases.Departments.Commands;
using ChamadosSetor8.Domain.Entities;
using ChamadosSetor8.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChamadosSetor8.Business.UseCases.Departments.Handlers
{
    public class DeleteDepartmentHandler : IRequestHandler<DeleteDepartmentCommand, ApiResult>
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DeleteDepartmentHandler(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public async Task<ApiResult> Handle(DeleteDepartmentCommand command, CancellationToken cancellationToken)
        {
            await _departmentRepository.DeleteAsync(command.Id);

            return new ApiResult<Department>();
        }
    }
}
