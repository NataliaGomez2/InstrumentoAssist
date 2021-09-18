using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    public class RepositorioMaestro : IRepositorioMaestro
    {
        
        
        
        public List<EstadoCivil> ObtenerEstadoCivil()
        {
            List<EstadoCivil> tiposEstadoCivil = new List<EstadoCivil>();
            tiposEstadoCivil.Add(new EstadoCivil() { Id = 1, Nombre = "Soltero(a)" });
            tiposEstadoCivil.Add(new EstadoCivil() { Id = 2, Nombre = "Casado(a)" });
            tiposEstadoCivil.Add(new EstadoCivil() { Id = 3, Nombre = "Divorciado(a)" });
            tiposEstadoCivil.Add(new EstadoCivil() { Id = 4, Nombre = "Viudo(a)" });
            tiposEstadoCivil.Add(new EstadoCivil() { Id = 5, Nombre = "Unión libre" });
            return tiposEstadoCivil;
        }

        public List<NivelEscolaridad> ObtenerNivelEscolaridad()
        {
            List<NivelEscolaridad> tiposNivelEscolaridad = new List<NivelEscolaridad>();
            tiposNivelEscolaridad.Add(new NivelEscolaridad() { Id = 1, Nombre = "Educación Inicial" });
            tiposNivelEscolaridad.Add(new NivelEscolaridad() { Id = 2, Nombre = "Educación Primaria" });
            tiposNivelEscolaridad.Add(new NivelEscolaridad() { Id = 3, Nombre = "Educación Secundaria" });
            tiposNivelEscolaridad.Add(new NivelEscolaridad() { Id = 4, Nombre = "Educación Superior" });
            return tiposNivelEscolaridad;
        }

        public List<TipoIdentificacion> ObtenerTipoIdentificacion()
        {
            List<TipoIdentificacion> tiposIdentificacion = new List<TipoIdentificacion>();
            tiposIdentificacion.Add(new TipoIdentificacion() { Id = 1, Nombre = "Registro Civil(RC)" });
            tiposIdentificacion.Add(new TipoIdentificacion() { Id = 2, Nombre = "Tarjeta de Identidada(TI)" });
            tiposIdentificacion.Add(new TipoIdentificacion() { Id = 3, Nombre = "Cédula de Ciudadanía(CC)" });
            tiposIdentificacion.Add(new TipoIdentificacion() { Id = 4, Nombre = "Cédula de Extranjería(CE)" });
            tiposIdentificacion.Add(new TipoIdentificacion() { Id = 5, Nombre = "Tarjeta Pasaporte(TP)" });
            return tiposIdentificacion;
        }
    } }
