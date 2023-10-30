using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Data.Configuration;

public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
{
    public void Configure(EntityTypeBuilder<Departamento> builder)
    {
        //Here you can configure the properties using the object 'Builder'.
        builder.ToTable("departamento");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id);

        builder.Property(x => x.NombreDepartamento).IsRequired().HasMaxLength(50);

        builder.Property(x => x.IdPaisFk).HasColumnType("int");
        builder.HasOne(x => x.Paises).WithMany(x => x.Departamentos).HasForeignKey(x => x.IdPaisFk);
    }
}