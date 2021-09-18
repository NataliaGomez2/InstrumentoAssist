using System;

namespace InstrumentodeMedicionAssist
{
    internal class ObtenerPaciente
    {
        public ObtenerPaciente()
        {
        }

        public string NombreCompleto { get; set; }
        public bool TipoIdentificacion { get; set; }
        public int NumeroIdentificacion { get; set; }
        public bool Genero { get; set; }
        public int Edad { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public bool EstadoCivil { get; set; }
        public string DireccionResidenca { get; set; }
        public string CiudadResidencia { get; set; }
        public int TelefonoContacto { get; set; }
        public string Ocupacion { get; set; }
        public bool NivelEscolatidad { get; set; }
        public string Eps { get; set; }
        public bool Regimen { get; set; }
        public string Email { get; set; }
        public int ContactoCasoEmergencia { get; set; }
    }
}