using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Domain.Entities;
using ChamadosSetor8.Domain.Interfaces.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Business.UseCases.Groups.Queries
{
    public class GetByIdGroupQuery: IRequest<ApiResult<Group>>
    {
        public int Id { get; set; }
}
}

