using Entidades;
using System;
using System.Collections.Generic;

namespace Repositorio
{
    public class RepositorioPaciente : IRepositorioPaciente
    {
       
        public RepositorioPaciente()
        {
          
        }

        public void EliminarPaciente(long idPaciente)
        {
            
        }

        public void ActualizarPaciente(Paciente paciente)
        {
           
        }

        public Paciente ObtenerPaciente(long idPaciente)
        {
            return null;
        }

        public List<Paciente> ObtenerPacientes()
        {
            return new List<Paciente>();
        }

        public long IngresarPaciente(Paciente paciente)
        {
             return new Random().Next();
            
        }
    }
}
