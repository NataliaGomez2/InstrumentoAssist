using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente
    { 
        public long IdPaciente { get; set; }
        public string NombreCompleto { get; set; }
        public TipoIdentificacion TipoIdentificacion { get; set; }
        
        public string NumeroIdentificacion { get; set; }
        
        private DateTime fechaNacimiento;
        public DateTime FechaNacimiento
        {
            get
            {
                return fechaNacimiento;
            }
            set
            {
                if (value > DateTime.Now)
                    fechaNacimiento = DateTime.Now;
                else
                    fechaNacimiento = value;
            }
        }
        public string Edad { get; set; }
        public EstadoCivil EstadoCivil { get; set; }
        public string DireccionResidencia { get; set; }
        public string CiudadResidencia { get; set; }
        public string TelefonoContacto { get; set; }
        public string Ocupacion { get; set; }
        public NivelEscolaridad NivelEscolaridad { get; set; }
        public string Eps { get; set; }
        public string Email { get; set; }
        public string ContactoCasoEmergencia { get; set; }
        public Genero Genero { get; set; }
        public Regimen Regimen { get; set; }
    }
}
