using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistance.Data;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;

public class ClienteDireccionRepository : GenericRepository<ClienteDireccion>, IClienteDireccionRepository
{
    private readonly VeterinariaContext _context;

    public ClienteDireccionRepository(VeterinariaContext context) : base(context)
    {
        _context = context;
    }

    public override async Task<IEnumerable<ClienteDireccion>> GetAllAsync()
    {
        return await _context.ClienteDirecciones.ToListAsync();
    }

    public override async Task<(int totalRegistros, IEnumerable<ClienteDireccion> registros)> GetAllAsync( //Sobrecarga de metodos
        int pageIndex,
        int pageSize,
        string search
    )
    {
        var query = _context.ClienteDirecciones as IQueryable<ClienteDireccion>;
        if (!string.IsNullOrEmpty(search))
        {
            query = query.Where(p => p.CodigoPostal.ToLower().Contains(search));
        }
        query = query.OrderBy(p => p.Id);
        var totalRegistros = await query.CountAsync();
        var registros = await query
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
        return (totalRegistros, registros);
    }
}
