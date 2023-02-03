using BlazorPeliculas.Shared.Entidades;

namespace BlazorPeliculas.Client.Repositorio
{
    public interface IRepositorio
    {
        List<Pelicula> ObtenerPeliculas();
    }
}
