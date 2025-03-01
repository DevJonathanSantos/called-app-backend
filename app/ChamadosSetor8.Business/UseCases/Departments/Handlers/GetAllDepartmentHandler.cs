using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Business.UseCases.Departments.Queries;
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
    public class GetAllDepartmentHandler : IRequestHandler<GetAllDepartmentQuery, ApiResult<IEnumerable<Department>>>
    {
        private readonly IDepartmentRepository _departmentRepository;
        public GetAllDepartmentHandler(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public async Task<ApiResult<IEnumerable<Department>>> Handle(GetAllDepartmentQuery request, CancellationToken cancellationToken)
        {
            var apiResult = new ApiResult<IEnumerable<Department>>();

            return apiResult.SetData(await _departmentRepository.GetAllAsync());
        }
    }
}