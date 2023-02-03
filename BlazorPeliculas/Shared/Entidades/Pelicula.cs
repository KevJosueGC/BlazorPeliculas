using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorPeliculas.Shared.Entidades
{
    public class Pelicula
    {
        public string Nombre { get; set; } = null!;
        public DateTime FechaLanzamiento { get; set; }
    }
}
