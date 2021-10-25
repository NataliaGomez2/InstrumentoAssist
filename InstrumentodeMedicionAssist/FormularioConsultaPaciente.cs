using Negocio;
using Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstrumentodeMedicionAssist
{
    public partial class FormularioConsultaPaciente : Form
    {
       private IRepositorioPaciente repositorioPaciente = new RepositorioPacienteEF();
        public long IdPaciente { get; set; }
        public FormularioConsultaPaciente()
        {
            InitializeComponent();
        }

       

        private void FormularioConsultaPaciente_Load(object sender, EventArgs e)
        {
            var negocioPaciente = new NegocioPaciente(repositorioPaciente);
            var paciente = negocioPaciente.ObtenerPaciente(this.IdPaciente);

            txtNombreCompleto.Text = paciente.NombreCompleto;
            txtNumeroID.Text = paciente.NumeroIdentificacion;
            txtGenero.Text = paciente.Genero.Nombre;
            txtEdad.Text = paciente.Edad;
            txtFechaNacimiento.Text = paciente.FechaNacimiento.ToString("d");
            txtDireccionResidencia.Text = paciente.DireccionResidencia;
            txtCiudadResidencia.Text = paciente.CiudadResidencia;
            txtTelefonoContacto.Text = paciente.TelefonoContacto;
            txtOcupacion.Text = paciente.Ocupacion;
            txtEps.Text = paciente.Eps;
            txtRegimen.Text = paciente.Regimen.Nombre;
            txtEmail.Text = paciente.Email;
            txtContactoEmergencia.Text = paciente.ContactoCasoEmergencia;








        }
    }
}
