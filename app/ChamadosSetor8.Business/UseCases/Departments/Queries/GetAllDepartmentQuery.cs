using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Business.UseCases.Departments.Queries
{
    public class GetAllDepartmentQuery : IRequest<ApiResult<IEnumerable<Domain.Entities.Department>>>
    {
    }
}
