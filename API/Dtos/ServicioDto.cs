using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Dtos;

public class ServicioDto
{
    public int Id { get; set; }
    public string NombreServicio { get; set; }
    public double PrecioServicio { get; set; }
}
