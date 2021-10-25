using Entidades;
using Negocio;
using Repositorio;
using System;
using System.Windows.Forms;

namespace InstrumentodeMedicionAssist
{
    public partial class FormularioConsultaPacientes : Form
    {
        private IRepositorioPaciente repositorioPaciente = new RepositorioPacienteEF();
        public FormularioConsultaPacientes()
        {
            InitializeComponent();
        }

        private void FormularioConsultaPacientes_Load(object sender, EventArgs e)
        {
            var negocioPaciente = new NegocioPaciente(repositorioPaciente);
            var pacientes = negocioPaciente.ObtenerPacientes();

            dgvPacientes.DataSource = pacientes;
        }

        private void btnVerPaciente_Click(object sender, EventArgs e)
        {
            if (dgvPacientes.SelectedRows.Count > 0)
            {
                FormularioConsultaPaciente formulario = new FormularioConsultaPaciente();
                formulario.IdPaciente = ((Paciente)(dgvPacientes.SelectedRows[0].DataBoundItem)).IdPaciente;
                formulario.Show();
            }
            else 
            {
                MessageBox.Show("Debe seleccionar un paciente", this.Text,
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
