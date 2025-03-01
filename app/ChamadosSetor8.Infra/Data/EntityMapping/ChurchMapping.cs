using ChamadosSetor8.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ChamadosSetor8.Infra.Data.EntityConfiguration
{
    public class ChurchMapping : IEntityTypeConfiguration<Church>
    {
        public void Configure(EntityTypeBuilder<Church> builder)
        {

            builder.Property(c => c.Id)
               .ValueGeneratedOnAdd()
               .UseIdentityColumn();


            builder.Property(c => c.CreationDate).IsRequired();

            builder.Property(c => c.Name).IsRequired();

            builder.Property(c => c.Description).IsRequired();

            builder
            .HasMany(u => u.Users)
            .WithMany(c => c.Churchs)
            .UsingEntity(j => j.ToTable("ChurchUser"));
        }
    }
}