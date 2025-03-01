using ChamadosSetor8.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Infra.Data.EntityMapping
{
    public class DepartamentMapping : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasKey(g => g.Id);

            builder.Property(g => g.Name).IsRequired();

            builder.Property(c => c.Description).IsRequired();

        }
    }
}