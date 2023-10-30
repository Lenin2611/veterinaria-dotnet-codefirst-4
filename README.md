# **Veterinaria CodeFirst**

- Creación de Proyecto
  1. [Creación de sln](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#Creacion-de-sln)
  2. [Creación de proyectos de classlib](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#Creacion-de-proyectos-classlib)
  3. [Creación de proyecto de webapi](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#Creacion-de-proyecto-webapi)
  4. [Agregar proyectos al sln](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#Agregar-proyectos-al-sln)
  5. [Agregar referencia entre proyectos](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#Agregar-referencia-entre-proyectos)
- Instalación de paquetes
  1. [Proyecto API](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#Proyecto-API)
  2. [Proyecto Domain](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#Proyecto-Domain)
  3. [Proyecto Persistance](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#Proyecto-Persistance)
- Migración de Proyecto
  1. [Migración](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#Migracion)
  2. [Actualizar base de datos](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#Actualizar-base-de-datos)
- API
  1. Controllers
     - [EntityController.cs](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#EntityController)
     - [BaseController.cs](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#BaseController)
     - [UserController.cs](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#UserController)
  2. Dtos
     - [EntityDto.cs](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#EntityDto)
  3. Extensions
     - [ApplicationServicesExtension.cs](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#ApplicationServicesExtension)
  4. Helper
     - [Authorization.cs](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#Authorization)
     - [JWT.cs](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#JWT)
     - [Pager.cs](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#Pager)
     - [Params.cs](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#Params)
  5. Profiles
     - [MappingProfiles.cs](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#MappingProfiles)
  6. Program
     - [Program.cs](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#Program)
  7. Services
     - [UserService.cs](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#UserService)
     - [IUserService.cs](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#IUserService)
- Application
  1. Repositories
     - [EntityRepository.cs](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#EntityRepository)
     - [GenericRepository.cs](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#GenericRepository)
  2. UnitOfWork
     - [UnitOfWork.cs](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#UnitOfWork)
- Domain
  1. Entities
     - [Entity.cs](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#Entity)
     - [BaseEntity.cs](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#BaseEntity)
  2. Interfaces
     - [IEntity.cs](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#IEntity)
     - [IUser.cs](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#IUser)
     - [IGenericRepository.cs](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#IGenericRepository)
     - [IUnitOfWork.cs](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#IUnitOfWork)
- Persistance
  1. Data
     - Configuration
       - [EntityConfiguration.cs](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#EntityConfiguration)
     - [DbContext.cs](https://file+.vscode-resource.vscode-cdn.net/c%3A/Users/lenin/OneDrive/Documentos/campus/dotnet/veterinaria-fourlayers/README.md#DbContext)

## Creación de proyecto

#### Creacion de sln

```
dotnet new sln
```

#### Creacion de proyectos classlib

```
dotnet new classlib -o Application
dotnet new classlib -o Domain
dotnet new classlib -o Persistance
```

#### Creacion de proyecto webapi

```
dotnet new webapi -o API
```

#### Agregar proyectos al sln

```
dotnet sln add API
dotnet sln add Application
dotnet sln add Domain
dotnet sln add Persistance
```

#### Agregar referencia entre proyectos

```
cd ./API/
dotnet add reference ../Application/
cd ..
cd ./Application/
dotnet add reference ../Domain/
dotnet add reference ../Persistence/
cd ..
cd ./Persistance/
dotnet add reference ../Domain/
```

## Instalacion de paquetes

#### Proyecto API

```
dotnet add package AspNetCoreRateLimit
dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection
dotnet add package Microsoft.AspNetCore.Authentication.JwtBearer
dotnet add package Microsoft.AspNetCore.Mvc.Versioning
dotnet add package Microsoft.AspNetCore.OpenApi
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package System.IdentityModel.Tokens.Jwt
dotnet add package Serilog.AspNetCore
dotnet add package Microsoft.Extensions.DependencyInjection
dotnet add package Microsoft.EntityFrameworkCore
```

#### Proyecto Domain

```
dotnet add package FluentValidation.AspNetCore
dotnet add package itext7.pdfhtml
dotnet add package Microsoft.EntityFrameworkCore
```

#### Proyecto Persistance

```
dotnet add package Microsoft.EntityFrameworkCore
dotnet add package Pomelo.EntityFrameworkCore.MySql
```

## Migración de Proyecto

#### Migracion

```
dotnet ef migrations add InitialCreate --project ./Persistance/ --startup-project ./API/ --output-dir ./Data/Migrations
```

#### Actualizar base de datos

```
dotnet ef database update --project ./Persistance/ --startup-project ./API/     
```

## API

#### Controllers

###### EntityController

```csharp
using API.Dtos;
using AutoMapper;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class CitaController : BaseController
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IMapper _mapper;

    public CitaController(IUnitOfWork unitOfWork, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _mapper = mapper;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<IEnumerable<CitaDto>>> Get()
    {
        var citas = await _unitOfWork.Citas.GetAllAsync();
        return _mapper.Map<List<CitaDto>>(citas);
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<CitaDto>> Get(int id)
    {
        var cita = await _unitOfWork.Citas.GetByIdAsync(id);
        if (cita == null)
        {
            return NotFound();
        }
        return _mapper.Map<CitaDto>(cita);
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public async Task<ActionResult<CitaDto>> Post(CitaDto citaDto)
    {
        var cita = _mapper.Map<Cita>(citaDto);
        if (citaDto.FechaCita == DateOnly.MinValue)
        {
            citaDto.FechaCita = DateOnly.FromDateTime(DateTime.Now);
            cita.FechaCita = DateOnly.FromDateTime(DateTime.Now);
        }
        if (citaDto.HoraCita == TimeOnly.MinValue)
        {
            citaDto.HoraCita = TimeOnly.FromDateTime(DateTime.Now);
            cita.HoraCita = TimeOnly.FromDateTime(DateTime.Now);
        }
        _unitOfWork.Citas.Add(cita);
        await _unitOfWork.SaveAsync();
        if (cita == null)
        {
            return BadRequest();
        }
        citaDto.Id = cita.Id;
        return CreatedAtAction(nameof(Post), new { id = citaDto.Id }, citaDto);
    }

    [HttpPut("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<CitaDto>> Put(int id, [FromBody] CitaDto citaDto)
    {
        if (citaDto.Id == 0)
        {
            citaDto.Id = id;
        }
        if (citaDto.Id != id)
        {
            return NotFound();
        }
        var cita = _mapper.Map<Cita>(citaDto);
        if (citaDto.FechaCita == DateOnly.MinValue)
        {
            citaDto.FechaCita = DateOnly.FromDateTime(DateTime.Now);
            cita.FechaCita = DateOnly.FromDateTime(DateTime.Now);
        }
        if (citaDto.HoraCita == TimeOnly.MinValue)
        {
            citaDto.HoraCita = TimeOnly.FromDateTime(DateTime.Now);
            cita.HoraCita = TimeOnly.FromDateTime(DateTime.Now);
        }
        citaDto.Id = cita.Id;
        _unitOfWork.Citas.Update(cita);
        await _unitOfWork.SaveAsync();
        return citaDto;
    }

    [HttpDelete("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<IActionResult> Delete(int id)
    {
        var cita = await _unitOfWork.Citas.GetByIdAsync(id);
        if (cita == null)
        {
            return NotFound();
        }
        _unitOfWork.Citas.Remove(cita);
        await _unitOfWork.SaveAsync();
        return NoContent();
    }
}
```

###### BaseController

```csharp
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BaseController : ControllerBase
{

}
```

###### UserController

```csharp
using API.Dtos;
using API.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

public class UserController : BaseController
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("register")]
    public async Task<ActionResult> RegisterAsync(RegisterDto model)
    {
        var result = await _userService.RegisterAsync(model);
        return Ok(result);
    }

    [HttpPost("token")]
    public async Task<ActionResult> GetTokenAsync(LoginDto model)
    {
        var result = await _userService.GetTokenAsync(model);
        SetRefreshTokenInCookie(result.RefreshToken);
        return Ok(result);
    }

    [HttpPost("addrol")]
    public async Task<ActionResult> AddRolAsync(AddRolDto model)
    {
        var result = await _userService.AddRolAsync(model);
        return Ok(result);
    }

    [HttpPost("refresh-token")]
    public async Task<ActionResult> RefreshToken()
    {
        var refreshToken = Request.Cookies["refreshToken"];
        var result = await _userService.RefreshTokenAsync(refreshToken);
        if (!string.IsNullOrEmpty(result.RefreshToken))
        {
            SetRefreshTokenInCookie(result.RefreshToken);
        }
        return Ok(result);
    }

    private void SetRefreshTokenInCookie(string refreshToken)
    {
        var cookieOptions = new CookieOptions
        {
            HttpOnly = true,
            Expires = DateTime.UtcNow.AddDays(2),
        };
        Response.Cookies.Append("refreshToken", refreshToken, cookieOptions);
    }
}
```

#### Dtos

###### EntityDto

```csharp
namespace API.Dtos;

public class CitaDto
{
    public int Id { get; set; }
    public DateOnly FechaCita { get; set; }
    public TimeOnly HoraCita { get; set; }
    public int IdClienteFk { get; set; }
    public int IdMascotaFk { get; set; }
    public int IdServicioFk { get; set; }
}
```

#### Extensions

###### ApplicationServicesExtension

```csharp
using AspNetCoreRateLimit;
using Domain.Interfaces;
using Application.UnitOfWork;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using API.Helpers;

namespace API.Extensions;

public static class ApplicationServiceExtensions
{
    public static void ConfigureCors(this IServiceCollection services) => services.AddCors(options =>
    {
        options.AddPolicy("CorsPolicy", builder =>
        {
            builder.AllowAnyOrigin() // WithOrigins("https://domain.com")
            .AllowAnyMethod() // WithMethods("GET", "POST")
            .AllowAnyHeader(); // WithHeaders("accept", "content-type")
        });
    }); // Remember to put 'static' on the class and to add builder.Services.ConfigureCors(); and app.UseCors("CorsPolicy"); to Program.cs

    public static void ConfigureRateLimiting(this IServiceCollection services)
    {
        services.AddMemoryCache();
        services.AddSingleton<IRateLimitConfiguration, RateLimitConfiguration>();
        services.AddInMemoryRateLimiting();
        services.Configure<IpRateLimitOptions>(options =>
        {
            options.EnableEndpointRateLimiting = true;
            options.StackBlockedRequests = false;
            options.HttpStatusCode = 429;
            options.RealIpHeader = "X-Real-IP";
            options.GeneralRules = new List<RateLimitRule>
            {
                new RateLimitRule
                {
                    Endpoint = "*",  // Si quiere usar todos ponga *
                    Period = "10s", // Periodo de tiempo para hacer peticiones
                    Limit = 2         // Numero de peticiones durante el periodo de tiempo
                }
            };
        });
    } // Remember adding builder.Services.ConfigureRateLimiting(); and builder.Services.AddAutoMapper(Assembly.GetEntryAssembly()); and app.UseIpRateLimiting(); to Program.cs

    public static void AddApplicationServices(this IServiceCollection services)
    {
        services.AddScoped<IUnitOfWork, UnitOfWork>();
    } // Remember to add builder.Services.AddApplicationServices(); to Program.cs

    public static void AddJwt(this IServiceCollection services, IConfiguration configuration)
    {
        // Configuration from AppSettings
        services.Configure<JWT>(configuration.GetSection("JWT"));
    
        // Adding Authentication - JWT
        services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(o =>
        {
            o.RequireHttpsMetadata = false;
            o.SaveToken = false;
            o.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ClockSkew = TimeSpan.Zero,
                ValidIssuer = configuration["JWT:Issuer"],
                ValidAudience = configuration["JWT:Audience"],
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JWT:Key"]))
            };
        });
    }
}
```

#### Helpers

###### Authorization

```csharp
namespace API.Helpers
{
    public class Authorization
    {
        public enum Roles
        {
            Administrator,
            Manager,
            Employee,
            Person
        }
        
        public const Roles rol_default = Roles.Person;
    }
}
```

###### 

###### JWT

```csharp
namespace API.Helpers;

public class JWT
{
    public string Key { get; set; }
    public string Issuer { get; set; }
    public string Audience { get; set; }
    public double DurationInMinutes { get; set; }
}
```

###### Pager

```csharp
namespace API.Helpers;

public class Pager<T> where T : class
    {
    public string Search { get; set; }
    public int PageIndex { get; set; }
    public int PageSize { get; set; }
    public int Total { get; set; }
    public List<T> Registers { get; private set; }

    public Pager()
    {
    }

    public Pager(List<T> registers, int total, int pageIndex, int pageSize, string search)
    {
        Registers = registers;
        Total = total;
        PageIndex = pageIndex;
        PageSize = pageSize;
        Search = search;
    }

    public int TotalPages
    {
        get { return (int)Math.Ceiling(Total / (double)PageSize); }
        set { this.TotalPages = value; }
    }

    public bool HasPreviousPage
    {
        get { return (PageIndex > 1); }
        set { this.HasPreviousPage = value; }
    }

    public bool HasNextPage
    {
        get { return (PageIndex < TotalPages); }
        set { this.HasNextPage = value; }
    }
}
```

###### Params

```csharp
namespace API.Helpers;

public class Params
{
    private int _pageSize = 5;
    private const int MaxPageSize = 50;
    private int _pageIndex = 1;
    private string _search;

    public int PageSize
    {
        get => _pageSize;
        set => _pageSize = (value > MaxPageSize) ? MaxPageSize : value;
    }

    public int PageIndex
    {
        get => _pageIndex;
        set => _pageIndex = (value <= 0) ? 1 : value;
    }

    public string Search
    {
        get => _search;
        set => _search = (!String.IsNullOrEmpty(value)) ? value.ToLower() : "";
    }
}
```

#### Profiles

###### MappingProfiles

```csharp
using API.Dtos;
using AutoMapper;
using Domain.Entities;

namespace API.Profiles;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        CreateMap<Cita, CitaDto>().ReverseMap();
        ...
    }
}
```

#### Program

###### Program

```csharp
using System.Reflection;
using API.Extensions;
using AspNetCoreRateLimit;
using Persistance.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<VeterinariaContext>(optionsBuilder =>
{
    string connectionString = builder.Configuration.GetConnectionString("MySqlConex");
    optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});

builder.Services.ConfigureCors();

builder.Services.ConfigureRateLimiting();

builder.Services.AddAutoMapper(Assembly.GetEntryAssembly());

builder.Services.AddApplicationServices();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("CorsPolicy");

app.UseIpRateLimiting();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
```

## Application

#### Repositories

###### EntityRepository

```csharp
using Domain.Entities;
using Domain.Interfaces;
using Persistance.Data;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;

public class CitaRepository : GenericRepository<Cita>, ICitaRepository
{
    private readonly VeterinariaContext _context;

    public CitaRepository(VeterinariaContext context) : base(context)
    {
        _context = context;
    }
    public override async Task<IEnumerable<Cita>> GetAllAsync()
    {
        return await _context.Citas.ToListAsync();
    }
    public override async Task<(int totalRegistros, IEnumerable<Cita> registros)> GetAllAsync( //Sobrecarga de metodos
        int pageIndex,
        int pageSize,
        string search
    )
    {
        var query = _context.Citas as IQueryable<Cita>;
        if (!string.IsNullOrEmpty(search))
        {
            query = query.Where(p => p.FechaCita.ToString().ToLower().Contains(search));
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
```

###### GenericRepository

```csharp
using System.Linq.Expressions;
using Domain.Entities;
using Domain.Interfaces;
using Persistance.Data;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    private readonly VeterinariaContext _context;

    public GenericRepository(VeterinariaContext context)
    {
        _context = context;
    }

    public virtual void Add(T entity)
    {
        _context.Set<T>().Add(entity);
    }

    public virtual void AddRange(IEnumerable<T> entities)
    {
        _context.Set<T>().AddRange(entities);
    }

    public virtual IEnumerable<T> Find(Expression<Func<T, bool>> expression)
    {
        return _context.Set<T>().Where(expression);
    }

    public virtual async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _context.Set<T>().ToListAsync();
        // return (IEnumerable<T>) await _context.Entities.FromSqlRaw("SELECT * FROM entity").ToListAsync();
    }

    public virtual async Task<T> GetByIdAsync(int id)
    {
        return await _context.Set<T>().FindAsync(id);
    }

    public virtual Task<T> GetByIdAsync(string id)
    {
        throw new NotImplementedException();
    }

    public virtual void Remove(T entity)
    {
        _context.Set<T>().Remove(entity);
    }

    public virtual void RemoveRange(IEnumerable<T> entities)
    {
        _context.Set<T>().RemoveRange(entities);
    }

    public virtual void Update(T entity)
    {
        _context.Set<T>().Update(entity);
    }
    public virtual async Task<(int totalRegistros, IEnumerable<T> registros)> GetAllAsync(
        int pageIndex,
        int pageSize,
        string _search
    )
    {
        var totalRegistros = await _context.Set<T>().CountAsync();
        var registros = await _context
            .Set<T>()
            .Skip((pageIndex - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();
        return (totalRegistros, registros);
    }
}
```

#### UnitOfWork

###### UnitOfWork

```csharp
using Domain.Interfaces;
using Persistance.Data;
using Application.Repositories;

namespace Application.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly VeterinariaContext _context;
    private ICitaRepository _Citas;
    ...

    public UnitOfWork(VeterinariaContext context)
    {
        _context = context;
    }

    public ICitaRepository Citas
    {
        get
        {
            if (_Citas == null)
            {
                _Citas = new CitaRepository(_context);
            }
            return _Citas;
        }
    }
    ...

    public Task<int> SaveAsync()
    {
        return _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
```

## Domain

#### Entities

###### Entity

```csharp
namespace Domain.Entities;

public class Cita : BaseEntity
{
    public DateOnly FechaCita { get; set; }
    public TimeOnly HoraCita { get; set; }
    public int IdClienteFk { get; set; }
    public Cliente Clientes { get; set; }
    public int IdMascotaFk { get; set; }
    public Mascota Mascotas { get; set; }
    public int IdServicioFk { get; set; }
    public Servicio Servicios { get; set; }
}
```

###### BaseEntity

```csharp
namespace Core.Entities;

public class BaseEntity
{
    public int/string Id { get; set; }
}
```

#### 

#### Interface

###### IEntity

```csharp
using Domain.Entities;

namespace Domain.Interfaces;

public interface IMovimientoInventarioRepository : IGenericRepositoryVC<MovimientoInventario>
{

}
```

###### IUser

```csharp
using Domain.Entities;

namespace Domain.Interfaces;

public interface IUserRepository : IGenericRepository<User>
{
    Task<User> GetByUsernameAsync(string username);
    Task<User> GetByRefreshTokenAsync(string refreshToken);
}
```

###### IGenericRepository

```csharp
using System.Linq.Expressions;
using Domain.Entities;

namespace Domain.Interfaces;

public interface IGenericRepository<T> where T : BaseEntity
{
    Task<T> GetByIdAsync(int Id);
    Task<IEnumerable<T>> GetAllAsync();
    IEnumerable<T> Find(Expression<Func<T, bool>> expression);
    Task<(int totalRegistros, IEnumerable<T> registros)> GetAllAsync(int pageIndex, int pageSize, string search);
    void Add(T entity);
    void AddRange(IEnumerable<T> entities);
    void Remove(T entity);
    void RemoveRange(IEnumerable<T> entities);
    void Update(T entity);
}
```

###### IUnitOfWork

```csharp
namespace Domain.Interfaces;

public interface IUnitOfWork
{
    public IMovimientoInventario MovimientoInventarios { get; }
    ...

    Task<int> SaveAsync();
}
```

###### 

## Infrastructure

#### Data

##### Configuration

###### EntityConfiguration

```csharp
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistance.Data.Configuration;

public class CitaConfiguration : IEntityTypeConfiguration<Cita>
{
    public void Configure(EntityTypeBuilder<Cita> builder)
    {
        //Here you can configure the properties using the object 'Builder'.
        builder.ToTable("cita");

        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id);

        builder.Property(c => c.FechaCita).HasColumnType("date");

        builder.Property(c => c.HoraCita).HasColumnType("time");

        builder.Property(x => x.IdClienteFk).HasColumnType("int");
        builder.HasOne(c => c.Clientes).WithMany(c => c.Citas).HasForeignKey(c => c.IdClienteFk);

        builder.Property(x => x.IdMascotaFk).HasColumnType("int");
        builder.HasOne(c => c.Mascotas).WithMany(c => c.Citas).HasForeignKey(c => c.IdMascotaFk);

        builder.Property(x => x.IdServicioFk).HasColumnType("int");
        builder.HasOne(c => c.Servicios).WithMany(c => c.Citas).HasForeignKey(c => c.IdServicioFk);
    }
}
```

###### DbContext

```csharp
using System.Reflection;
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
    ...

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
```