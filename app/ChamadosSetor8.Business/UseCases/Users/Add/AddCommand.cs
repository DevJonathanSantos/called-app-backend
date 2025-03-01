using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Domain.Entities;
using MediatR;

namespace ChamadosSetor8.Business.UseCases.Users.Add;

public class AddCommand : IRequest<ApiResult<User>>
{
    public string Name { get; set; } = string.Empty;
    public string EmailAddress { get; set; } = string.Empty;
    public int ProfileId { get; set; }
    public int DepartmentId { get; set; }
    public IEnumerable<int> ChurchIds { get; set; }

    public static implicit operator User(AddCommand command) =>
        new(name: command.Name, emailAddress: command.EmailAddress,
            profileId: command.ProfileId, departmentId: command.DepartmentId);
}
