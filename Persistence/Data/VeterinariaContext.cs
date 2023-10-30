using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistance.Data;

public class VeterinariaContext : DbContext
{
    public VeterinariaContext(DbContextOptions options) : base(options)
    {
    }
    // DbSets
    public DbSet<Cita> Citas { get; set; }
    public DbSet<Ciudad> Ciudades { get; set; }
    public DbSet<Cliente> Clientes { get; set; }
    public DbSet<ClienteDireccion> ClienteDirecciones { get; set; }
    public DbSet<ClienteTelefono> ClienteTelefonos { get; set; }
    public DbSet<Departamento> Departamentos { get; set; }
    public DbSet<Mascota> Mascotas { get; set; }
    public DbSet<Pais> Paises { get; set; }
    public DbSet<Raza> Razas { get; set; }
    public DbSet<Servicio> Servicios { get; set; }
    public DbSet<Rol> Roles { get; set; }
    public DbSet<User> Users { get; set; }
    public DbSet<UserRol> UserRoles { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
