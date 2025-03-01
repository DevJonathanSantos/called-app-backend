using ChamadosSetor8.Business.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Business.UseCases.Groups.Commands
{
    public class DeleteGroupCommand : IRequest<ApiResult>
    {
        public int Id { get; set; }
    }
}
