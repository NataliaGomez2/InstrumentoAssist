using Entidades;
using Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioPaciente : INegocioPaciente
    {
        IRepositorioPaciente repositorioPaciente;

        public NegocioPaciente (IRepositorioPaciente repositorioPaciente)
        {
            this.repositorioPaciente = repositorioPaciente;
        }

        public void EliminarPaciente(long idPaciente)
        {
            repositorioPaciente.EliminarPaciente(idPaciente);
        }

        public void ActualizarPaciente(Paciente paciente)
        {
            repositorioPaciente.ActualizarPaciente(paciente);
        }

        public Paciente ObtenerPaciente(long idPaciente)
        {
            return repositorioPaciente.ObtenerPaciente(idPaciente);
        }

        public List<Paciente> ObtenerPacientes()
        {
            return repositorioPaciente.ObtenerPacientes();
        }

        public long IngresarPaciente(Paciente paciente)
        {
            return repositorioPaciente.IngresarPaciente(paciente);
        }
    }
}
