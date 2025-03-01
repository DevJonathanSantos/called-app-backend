using ChamadosSetor8.Business.Common;
using ChamadosSetor8.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Business.UseCases.Users.GetAll;

public class GetAllResponse
{
    public int Id { get;  set; }
    public string Name { get;  set; }
    public string Email { get;  set; }
    public DateTime CreationDate { get;  set; }
    public DateTime UpdateDate { get;  set; }
    public int DepartmentId{ get;  set; }
    public string DepartmentName{ get;  set; }
    public string ProfileName { get;  set; }
    public int ProfileId { get; set; }
}
