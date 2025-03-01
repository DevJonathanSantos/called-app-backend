using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Domain.Entities;

public class Profile : Entity
{
    public Profile() : base() { }
    public string Name { get; private set; }
    public string Description { get; private set; }

    public Profile(string name, string description)
    {
        Name = name;
        Description = description;
    }
}


