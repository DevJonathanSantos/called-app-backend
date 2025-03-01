using ChamadosSetor8.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Domain.Entities;

public class Entity : IEntity
{
    public int Id { get; private set; }

    public Entity()
    {
    }

}
