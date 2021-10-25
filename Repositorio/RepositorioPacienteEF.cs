using Modelos;
using System.Collections.Generic;
using System.Linq;

namespace Repositorio
{
    public class RepositorioPacienteEF : IRepositorioPaciente
    {
        private InstrumentoMedicionAssistContexto contexto;

        public RepositorioPacienteEF()
        {
            contexto = new InstrumentoMedicionAssistContexto();
        }

        public void EliminarPaciente(long idPaciente)
        {
            var paciente = contexto.Pacientes.FirstOrDefault(p => p.IdPaciente == idPaciente);
            contexto.Pacientes.Remove(paciente);
            contexto.SaveChanges();
        }

        public void ActualizarPaciente(Entidades.Paciente paciente)
        {
            var pacienteActual = contexto.Pacientes.FirstOrDefault(p => p.IdPaciente == paciente.IdPaciente);

            pacienteActual.NombreCompleto = paciente.NombreCompleto;
            pacienteActual.TipoIdentificacion = paciente.TipoIdentificacion.Id;
            pacienteActual.NumeroIdentificacion = paciente.NumeroIdentificacion;
            pacienteActual.FechaNacimiento = paciente.FechaNacimiento;
            pacienteActual.Eps = paciente.Eps;
            pacienteActual.Codigo = paciente.NumeroIdentificacion;
          

            contexto.SaveChanges();
        }

        public Entidades.Paciente ObtenerPaciente(long idPaciente)
        {
            var paciente = contexto.Pacientes.FirstOrDefault(p => p.IdPaciente == idPaciente);
            return new Entidades.Paciente()
            {
                NumeroIdentificacion = paciente.NumeroIdentificacion,
                NombreCompleto = paciente.NombreCompleto,
                FechaNacimiento = paciente.FechaNacimiento,
                Eps = paciente.Eps,

            };

        }

        public List<Entidades.Paciente> ObtenerPacientes()
        {
            return contexto.Pacientes.Select(paciente => new Entidades.Paciente()
            {
                NumeroIdentificacion = paciente.NumeroIdentificacion,
                NombreCompleto = paciente.NombreCompleto,
                FechaNacimiento = paciente.FechaNacimiento,
                Eps = paciente.Eps,
                


            }).ToList();
        }

        public long IngresarPaciente(Entidades.Paciente paciente)
        {
            var nuevoPaciente = new Modelos.Pacientes()
            {
                NombreCompleto = paciente.NombreCompleto,
                TipoIdentificacion = paciente.TipoIdentificacion.Id,
                NumeroIdentificacion = paciente.NumeroIdentificacion,
                FechaNacimiento = paciente.FechaNacimiento,
                Eps = paciente.Eps,
                Codigo =paciente.NumeroIdentificacion,
                
            };
            contexto.Pacientes.Add(nuevoPaciente);
            contexto.SaveChanges();

            return nuevoPaciente.IdPaciente;
        }

        

        
         
    }
}
