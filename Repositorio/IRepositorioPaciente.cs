using Entidades;
using System.Collections.Generic;

namespace Repositorio
{
    public interface IRepositorioPaciente
    {
        void ActualizarPaciente(Paciente paciente);
        void EliminarPaciente(long idPaciente);
        Paciente ObtenerPaciente(long idPaciente);
        List<Paciente> ObtenerPacientes();
        long IngresarPaciente(Paciente paciente);
    }
}