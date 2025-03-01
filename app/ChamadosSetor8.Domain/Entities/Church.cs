using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Domain.Entities;

public class Church : Entity
{
    public Church() : base() { }
    public string Name { get; private set; } = string.Empty;
    public string Description { get; private set; } = string.Empty;
    public DateTime CreationDate { get; private set; }
    public int GroupId { get; private set; }
    public Group Group { get; private set; }

    public IEnumerable<User> Users { get; private set; }

    public Church(string name, string description, int groupId)
    {
        Name = name;
        Description = description;
        GroupId = groupId;
        CreationDate = DateTime.Now;
    }

    public Church(int id, string name, string description, int groupId): base()
    {
        Name = name;
        Description = description;
        GroupId = groupId;
    }
}


