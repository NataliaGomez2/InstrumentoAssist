using Entidades;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;
using System.Linq;

namespace Repositorio
{
    public class RepositorioPacienteADO : IRepositorioPaciente
    {
        public static List<Paciente> pacientes = new List<Paciente>();
        public RepositorioPacienteADO()
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
            var pacientes = new List<Entidades.Paciente>();
            var CadenaConexion = ConfigurationManager.ConnectionStrings["InstrumentoMedicionAssist"].ConnectionString;
            using (var conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "ObtenerPacientes";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Connection = conexion;

                var reader = comando.ExecuteReader();
                while (reader.Read())
                {


                };
            }
           return pacientes;
        }

        public long IngresarPaciente(Paciente paciente)
        {
            var CadenaConexion = ConfigurationManager.ConnectionStrings["InstrumentoMedicionAssist"].ConnectionString;
            var id = 0;
            using (var conexion = new SqlConnection(CadenaConexion))
            {
                conexion.Open();
                SqlCommand comando = new SqlCommand();
                comando.CommandText = "IngresarPaciente";
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Connection = conexion;


                comando.Parameters.Add("@IdPaciente", System.Data.SqlDbType.TinyInt).Value = paciente.IdPaciente;
                comando.Parameters.Add("@NombreCompleto", System.Data.SqlDbType.VarChar,50).Value = paciente.NombreCompleto;
                comando.Parameters.Add("@TipoIdentificacion", System.Data.SqlDbType.TinyInt).Value = paciente.TipoIdentificacion.Id;
                comando.Parameters.Add("@NumeroIdentificacion", System.Data.SqlDbType.VarChar, 50).Value = paciente.NumeroIdentificacion;
                comando.Parameters.Add("@FechaNacimiento", System.Data.SqlDbType.DateTime2).Value = paciente.FechaNacimiento;
                comando.Parameters.Add("@Edad", System.Data.SqlDbType.VarChar, 50).Value = paciente.Edad;
                comando.Parameters.Add("@EstadoCivil", System.Data.SqlDbType.TinyInt).Value = paciente.EstadoCivil.Id;
                comando.Parameters.Add("@DireccionResidencia", System.Data.SqlDbType.VarChar, 50).Value = paciente.DireccionResidencia;
                comando.Parameters.Add("@CiudadResidencia", System.Data.SqlDbType.VarChar, 50).Value = paciente.CiudadResidencia;
                comando.Parameters.Add("@TelefonoContacto", System.Data.SqlDbType.VarChar, 50).Value = paciente.TelefonoContacto;
                comando.Parameters.Add("@Ocupacion", System.Data.SqlDbType.VarChar, 50).Value = paciente.Ocupacion;
                comando.Parameters.Add("@NivelEscolaridad", System.Data.SqlDbType.TinyInt).Value = paciente.NivelEscolaridad.Id;
                comando.Parameters.Add("@Eps", System.Data.SqlDbType.VarChar, 50).Value = paciente.Eps;
                comando.Parameters.Add("@ContactoCasoEmergencia", System.Data.SqlDbType.VarChar, 50).Value = paciente.ContactoCasoEmergencia;
                comando.Parameters.Add("@Genero", System.Data.SqlDbType.TinyInt).Value = paciente.Genero.Id;
                comando.Parameters.Add("@Regimen", System.Data.SqlDbType.TinyInt).Value = paciente.Regimen.Id;
      
                id = comando.ExecuteNonQuery();

            }
            return id;


        }
    }
}
