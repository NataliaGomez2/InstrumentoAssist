using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
	public class Pacientes
	{
		[Key]
		public long IdPaciente { get; set; }
		public string NombreCompleto { get; set; }
		public short TipoIdentificacion { get; set; }
		public string NumeroIdentificacion { get; set; }
		public DateTime FechaNacimiento { get; set; }
		public short Edad { get; set; }
		public short EstadoCivil { get; set; }
		public short DireccionResidencia { get; set; }
		public short CiudadResidencia { get; set; }
		public short TelefonoContacto { get; set; }
		public short Ocupacion { get; set; }
		public short NivelEscolaridad { get; set; }
		public string Eps { get; set; }
		public short ContactoCasoEmergencia { get; set; }
		public short Genero { get; set; }
		public short Regimen { get; set; }
		public string Codigo { get; set; }
		public virtual TipoIdentificacion IdTipoIdentificacion { get; set; }
		public virtual EstadoCivil IdEstadoCivil { get; set; }
		public virtual NivelEscolaridad IdNivelEscolaridad { get; set; }
		public virtual Genero IdGenero { get; set; }
		public virtual Regimen IdRegimen { get; set; }


	}
}
