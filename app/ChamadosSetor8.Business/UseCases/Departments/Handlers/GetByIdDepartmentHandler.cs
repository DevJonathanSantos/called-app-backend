using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Business.UseCases.Departments.Queries;
using ChamadosSetor8.Business.UseCases.Groups.Queries;
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
    public class GetByIdDepartmentHandler : IRequestHandler<GetByIdDepartmentQuery, ApiResult<Domain.Entities.Department>>
    {
        private readonly IDepartmentRepository _departmentRepository;
        public GetByIdDepartmentHandler(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        public async Task<ApiResult<Domain.Entities.Department>> Handle(GetByIdDepartmentQuery request, CancellationToken cancellationToken)
        {
            var apiResul = new ApiResult<Domain.Entities.Department>();

            return apiResul.SetData(await _departmentRepository.GetByIdAsync(request.Id));
        }
    }
}