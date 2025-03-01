using ChamadosSetor8.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;
using System.Reflection.Metadata;


namespace ChamadosSetor8.Infra.Data.EntityMapping
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(g => g.Id);

            builder.Property(c => c.CreationDate).IsRequired();

            builder.Property(g => g.Name).IsRequired();
            builder.Property(c => c.EmailAddress).IsRequired();

            builder.HasOne(p => p.Profile) 
            .WithMany()                
            .HasForeignKey(p => p.ProfileId);

            builder.HasOne(d => d.Department)
            .WithMany()
            .HasForeignKey(d => d.DepartmentId)
            .IsRequired();

            builder
            .HasMany(u => u.Churchs)
            .WithMany(c => c.Users)
            .UsingEntity(j => j.ToTable("ChurchUser")); 
        }
    }
}