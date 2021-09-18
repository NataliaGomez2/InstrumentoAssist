using System;
using System.Collections.Generic;

namespace Repositorios
{
    public class Repositoriopregunta : IRepositoriosPregunta
    {
        public static List<TipoRespuesta> ObtenerTipoRespuesta()

        {
            List<TipoRespuesta> tipoRespuesta = new List<TipoRespuesta>();
            tipoRespuesta.Add(new TipoRespuesta() { Id = 1, Nombre = "Productos derivados del Tabaco", Puntos = 0; 3}); 
        
 }


}
}
