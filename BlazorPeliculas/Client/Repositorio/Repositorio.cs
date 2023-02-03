using BlazorPeliculas.Shared.Entidades;

namespace BlazorPeliculas.Client.Repositorio
{
    public class Repositorio : IRepositorio
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>()
            {
                new Pelicula{ Nombre="Los caballeros del zodiaco", FechaLanzamiento=new DateTime(2023,02,01) },
                new Pelicula { Nombre = "Los caballeros del zodiaco", FechaLanzamiento = new DateTime(2023, 02, 01) },
                new Pelicula { Nombre = "Los caballeros del zodiaco", FechaLanzamiento = new DateTime(2023, 02, 01) }
            };
        }
    }
}
