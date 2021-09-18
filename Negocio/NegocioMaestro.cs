using Entidades;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioMaestro : INegocioMaestro
    {
        IRepositorioMaestro repositorioMaestro; 
        public NegocioMaestro(IRepositorioMaestro repositorioMaestro)
        {
            this.repositorioMaestro = repositorioMaestro;
        }
       public List<TipoIdentificacion> ObtenerTipoIdentificacion()
       {
            return repositorioMaestro.ObtenerTipoIdentificacion();
       }
        public List<EstadoCivil> ObtenerEstadoCivil()

        {
            return repositorioMaestro.ObtenerEstadoCivil();
        }
        public List<NivelEscolaridad> ObtenerNivelEscolaridad()

        {
            return repositorioMaestro.ObtenerNivelEscolaridad();
        }
    }
}
