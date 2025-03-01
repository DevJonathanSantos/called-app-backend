using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Domain.Entities;

public class Group : Entity
{
   
    public string Name { get; private set; } = string.Empty;
    public DateTime CreationDate { get; private set; }

    public Group (string name)
    {
        Name = name;
        CreationDate = DateTime.Now;
    }

    public Group(int id, string name): base() 
    {
        Name = name;
    }
}


