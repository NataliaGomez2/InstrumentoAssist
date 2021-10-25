using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Repositorio
{
    public class RepositorioPacienteJSON : IRepositorioPaciente
    {
        public static List<Paciente> pacientes = new List<Paciente>();
        public RepositorioPacienteJSON()
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
            var json = File.ReadAllText("pacientes.json");
            pacientes = JsonConvert.DeserializeObject<List<Paciente>>(json);
            return pacientes.FirstOrDefault(p => p.IdPaciente == idPaciente);
        }

        public List<Paciente> ObtenerPacientes()
        {
            var json = File.ReadAllText("pacientes.json");
            pacientes = JsonConvert.DeserializeObject<List<Paciente>>(json);
            return pacientes;
        }

        public long IngresarPaciente(Paciente paciente)
        {
            paciente.IdPaciente = new Random().Next();
            
            string json = JsonConvert.SerializeObject(pacientes);
            pacientes.Add(paciente);
            File.WriteAllText("pacientes.json", json);

            return paciente.IdPaciente;

        }
    }
}
