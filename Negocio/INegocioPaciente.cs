using Entidades;
using System.Collections.Generic;

namespace Negocio
{
    public interface INegocioPaciente
    {
       void ActualizarPaciente(Paciente paciente);
        void EliminarPaciente(long idPaciente);
        Paciente ObtenerPaciente(long idPaciente);
        List<Paciente> ObtenerPacientes();
        long IngresarPaciente(Paciente paciente);
    }
}