using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChamadosSetor8.Domain.Entities;

namespace ChamadosSetor8.Infra.Data.EntityMapping
{
    public  class ProfileMapping : IEntityTypeConfiguration<Profile>
    {
        public void Configure(EntityTypeBuilder<Profile> builder)
        {
            builder.HasKey(g => g.Id);

            builder.Property(g => g.Name).IsRequired();

            builder.Property(c => c.Description).IsRequired();
        }
    }
}