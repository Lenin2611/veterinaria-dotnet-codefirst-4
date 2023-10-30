using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Persistance.Data;
using Persistence.Data;

namespace Application.Repositories;

public class RefreshTokenRepository : GenericRepository<RefreshToken>, IRefreshToken
{
    private readonly VeterinariaContext _context;

    public RefreshTokenRepository(VeterinariaContext context) : base(context)
    {
        _context = context;
    }
}
