using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interfaces;

public interface IUnitOfWork
{
    public ICitaRepository Citas { get; }
    public ICiudadRepository Ciudades { get; }
    public IClienteRepository Clientes { get; }
    public IClienteDireccionRepository ClienteDirecciones { get; }
    public IClienteTelefonoRepository ClienteTelefonos { get; }
    public IDepartamentoRepository Departamentos { get; }
    public IMascotaRepository Mascotas { get; }
    public IPaisRepository Paises { get; }
    public IRazaRepository Razas { get; }
    public IServicioRepository Servicios { get; }
    public IUser Users { get; }
    public IRol Rols { get; }
    public IRefreshToken RefreshTokens { get; }

    Task<int> SaveAsync();
}
