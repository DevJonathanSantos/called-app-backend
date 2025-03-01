using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Domain.Entities;

public class UserChurch : Entity
{
    public int UserId { get; private set; }
    public int ChurchId { get; private set; }
    public User User { get; private set; }
    public Church Church { get; private set; }
}


