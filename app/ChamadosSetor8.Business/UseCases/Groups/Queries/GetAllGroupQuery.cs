using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Business.UseCases.Groups.Queries
{
    public class GetAllGroupQuery : IRequest<ApiResult<IEnumerable<Group>>>
    {
    }
}
