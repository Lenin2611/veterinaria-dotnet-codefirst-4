using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistance.Data;
using Persistence.Data;

namespace Application.Repositories;

public class RolRepository : GenericRepository<Rol>, IRol
{
    private readonly VeterinariaContext _context;

    public RolRepository(VeterinariaContext context) : base(context)
    {
        _context = context;
    }
}
