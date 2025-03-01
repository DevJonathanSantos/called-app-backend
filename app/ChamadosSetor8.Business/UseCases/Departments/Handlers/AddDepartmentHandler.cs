using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Business.UseCases.Departments.Commands;
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
    public class AddDepartmentHandler : IRequestHandler<AddDepartmentCommand, ApiResult<Department>>
    {
        private readonly IDepartmentRepository _departmentRepository;

        public AddDepartmentHandler(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public async Task<ApiResult<Department>> Handle(AddDepartmentCommand command, CancellationToken cancellationToken)
        {
            var apiResult = new ApiResult<Department>();

            apiResult.SetData(await _departmentRepository.AddAsync(command));

            await _departmentRepository.SaveAsync();

            return apiResult;

        }
    }
}
