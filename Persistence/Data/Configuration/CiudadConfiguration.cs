using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Data.Configuration;

public class CiudadConfiguration : IEntityTypeConfiguration<Ciudad>
{
    public void Configure(EntityTypeBuilder<Ciudad> builder)
    {
        //Here you can configure the properties using the object 'Builder'.
        builder.ToTable("ciudad");

        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id);

        builder.Property(c => c.NombreCiudad).IsRequired().HasMaxLength(50);

        builder.Property(x => x.IdDepartamentoFk).HasColumnType("int");
        builder.HasOne(c => c.Departamentos).WithMany(c => c.Ciudades).HasForeignKey(c => c.IdDepartamentoFk);
    }
}