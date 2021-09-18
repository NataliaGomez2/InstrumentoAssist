using Entidades;
using System.Collections.Generic;

namespace Repositorio
{
    public interface IRepositorioMaestro
    {
        List<TipoIdentificacion> ObtenerTipoIdentificacion();
        List<EstadoCivil> ObtenerEstadoCivil();
        List<NivelEscolaridad> ObtenerNivelEscolaridad();
    }
}