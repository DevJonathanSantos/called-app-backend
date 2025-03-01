using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Domain.Entities;
using MediatR;

namespace ChamadosSetor8.Business.UseCases.Users.GetAll;

public class GetAllQuery : IRequest<ApiResult<IEnumerable<GetAllResponse>>>
{
}
