using ChamadosSetor8.Business.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Business.UseCases.Departments.Commands
{
    public class DeleteDepartmentCommand : IRequest<ApiResult>
    {
        public int Id { get; set; }
    }
}
