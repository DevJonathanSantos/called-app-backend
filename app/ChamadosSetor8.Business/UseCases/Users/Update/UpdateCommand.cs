using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Business.UseCases.Users.Update;

public class UpdateCommand : IRequest<ApiResult<User>>
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string EmailAddress { get; set; } = string.Empty;
    public int ProfileId { get; set; }
    public int DepartmentId { get; set; }
    public IEnumerable<int> ChurchIds { get; set; }

    public static implicit operator User(UpdateCommand command) =>
        new(id: command.Id, name: command.Name, emailAddress: command.EmailAddress,
            profileId: command.ProfileId, departmentId: command.DepartmentId);
}
