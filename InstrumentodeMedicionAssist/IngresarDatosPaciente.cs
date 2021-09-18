using Entidades;
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
    public partial class IngresarDatosPaciente : Form
    {
        IRepositorioPaciente repositorioPaciente = new RepositorioPaciente();
        IRepositorioMaestro repositorioMaestro = new RepositorioMaestro();


        public IngresarDatosPaciente()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var paciente = ObtenerPaciente();
            if (paciente != null)
            {

                var negocioPaciente = new NegocioPaciente(repositorioPaciente);
                var idPaciente = negocioPaciente.IngresarPaciente(paciente);

                MessageBox.Show($"Se ingresó el paciente de manera exitosa", "Paciente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hay errores en el formulario que deben corregirse. Por favor verifique", "Paciente",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
    
        }

        private Paciente ObtenerPaciente()
        {
            bool errores = false;
            erpError.SetError(txtNombreCompleto, null);
            erpError.SetError(cmbTipoIdentificacion, null);
            erpError.SetError(txtNumeroID, null);
            erpError.SetError(txtEdad, null);
            erpError.SetError(dtpFechaNacimiento, null);
            erpError.SetError(cmbEstadoCivil, null);
            erpError.SetError(txtDireccionResidencia, null);
            erpError.SetError(txtCiudadResidencia, null);
            erpError.SetError(txtTelefonoContacto, null);
            erpError.SetError(txtOcupacion, null);
            erpError.SetError(cmbTipoIdentificacion, null);
            erpError.SetError(txtEps, null);
            erpError.SetError(txtEmail, null);
            erpError.SetError(txtContactoEmergencia, null);

            if (string.IsNullOrEmpty(txtNombreCompleto.Text))
            {
                erpError.SetError(txtNombreCompleto, "Debe ingresar el nombre completo");
                errores = true;
            }
            if (cmbTipoIdentificacion.SelectedItem==null)
            {
                erpError.SetError(cmbTipoIdentificacion, "Debe seleccionar el tipo de identificación");
                errores = true;
            }
            if (string.IsNullOrEmpty(txtNumeroID.Text))
            {
                erpError.SetError(txtNumeroID, "Debe ingresar el número de identificación");
                errores = true;
            }
            if (string.IsNullOrEmpty(txtEdad.Text))
            {
                erpError.SetError(txtEdad, "Debe ingresar la edad");
                errores = true;
            }
            if (dtpFechaNacimiento.Value > DateTime.Now)
            {
                erpError.SetError(dtpFechaNacimiento, "La fecha de nacimiento no debe ser mayor a la fecha actual");
                errores = true;
            }
            if (cmbEstadoCivil.SelectedItem == null)
            {
                erpError.SetError(cmbEstadoCivil, "Debe seleccionar el estado civil");
                errores = true;
            }
            if (string.IsNullOrEmpty(txtDireccionResidencia.Text))
            {
                erpError.SetError(txtDireccionResidencia, "Debe ingresar la dirección de residencia");
                errores = true;
            }
            if (string.IsNullOrEmpty(txtCiudadResidencia.Text))
            {
                erpError.SetError(txtCiudadResidencia, "Debe ingresar la ciudad de residencia");
                errores = true;
            }
            if (string.IsNullOrEmpty(txtTelefonoContacto.Text))
            {
                erpError.SetError(txtTelefonoContacto, "Debe ingresar el teléfono de contacto");
                errores = true;
            }
            if (string.IsNullOrEmpty(txtOcupacion.Text))
            {
                erpError.SetError(txtOcupacion, "Debe ingresar la ocupación");
                errores = true;
            }
            if (cmbNivelEscolaridad.SelectedItem == null)
            {
                erpError.SetError(cmbNivelEscolaridad, "Debe seleccionar el nivel de escolaridad");
                errores = true;
            }
            if (string.IsNullOrEmpty(txtEps.Text))
            {
                erpError.SetError(txtEps, "Debe ingresar la EPS");
                errores = true;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                erpError.SetError(txtEmail, "Debe ingresar el email");
                errores = true;
            }
            if (string.IsNullOrEmpty(txtContactoEmergencia.Text))
            {
                erpError.SetError(txtContactoEmergencia, "Debe ingresar el contacto en caso de emergencia");
                errores = true;
            }
            if (!rdbFemenino.Checked && !rdbMasculino.Checked)
            {
                erpError.SetError(rdbFemenino, "Debe indicar el género del paciente");
                errores = true;
            }
            if (!rdbSubsidiado.Checked && !rdbContributivo.Checked)
            {
                erpError.SetError(rdbSubsidiado, "Debe indicar el régimen al que pertenece el paciente");
                errores = true;
            }


            if (errores)
            {
                return null;
            }

            var paciente = new Paciente()
            {
                NombreCompleto = txtNombreCompleto.Text,
                TipoIdentificacion = cmbTipoIdentificacion.SelectedItem as TipoIdentificacion,
                NumeroIdentificacion = txtNumeroID.Text,
                Edad = txtEdad.SelectionLength,
                FechaNacimiento = dtpFechaNacimiento.Value,
                EstadoCivil = cmbEstadoCivil.SelectedItem as EstadoCivil,
                DireccionResidenca = txtDireccionResidencia.Text,
                CiudadResidencia = txtCiudadResidencia.Text,
                TelefonoContacto = txtTelefonoContacto.Text,
                Ocupacion = txtOcupacion.Text,
                NivelEscolatidad = cmbNivelEscolaridad.SelectedItem as NivelEscolaridad,
                Eps = txtEps.Text,
                Email = txtEmail.Text,
                ContactoCasoEmergencia = txtContactoEmergencia.Text,
            };
            if (rdbFemenino.Checked)
            {
                paciente.Genero = new Genero()
                {
                    Id = (int)Entidades.Enumerados.Genero.Femenino
                };
            }
            else if (rdbMasculino.Checked)
            {
                paciente.Genero = new Genero()
                {
                    Id = (int)Entidades.Enumerados.Genero.Masculino
                };

            }

            if (rdbSubsidiado.Checked)
            {
                paciente.Regimen = new Regimen()
                {
                    Id = (int)Entidades.Enumerados.Regimen.Subsidiado
                };
            }
            else if (rdbContributivo.Checked)
            {
                paciente.Regimen = new Regimen()
                {
                    Id = (int)Entidades.Enumerados.Regimen.Contributivo
                };

            }

            return paciente;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IngresarDatosPaciente_Load(object sender, EventArgs e)
        {
            NegocioMaestro negocioMaestro = new NegocioMaestro(repositorioMaestro);
            cmbTipoIdentificacion.DataSource = negocioMaestro.ObtenerTipoIdentificacion();
            cmbTipoIdentificacion.DisplayMember = "Nombre";
            cmbTipoIdentificacion.SelectedItem = null;
            NegocioMaestro negocioMaestrouno = new NegocioMaestro(repositorioMaestro);
            cmbEstadoCivil.DataSource = negocioMaestro.ObtenerEstadoCivil();
            cmbEstadoCivil.DisplayMember = "Nombre";
            cmbEstadoCivil.SelectedItem = null;
            NegocioMaestro negocioMaestrodos = new NegocioMaestro(repositorioMaestro);
            cmbNivelEscolaridad.DataSource = negocioMaestro.ObtenerNivelEscolaridad();
            cmbNivelEscolaridad.DisplayMember = "Nombre";
            cmbNivelEscolaridad.SelectedItem = null;
            
        }

       
        private void txtNumeroID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar>57)
            {
                e.Handled = true;
            }
        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }

        }

        private void txtTelefonoContacto_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
        }

        private void txtContactoEmergencia_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar < 48 || e.KeyChar > 57)
            {
                e.Handled = true;
            }
        }

        private void txtNumeroID_Validating(object sender, CancelEventArgs e)
        {
            erpError.SetError(txtNumeroID, null);
            if(txtNumeroID.Text.Length < 4)
            {
                erpError.SetError(txtNumeroID, "El número de identificación no es válido");
            }
        }

        private void dtpFechaNacimiento_Leave(object sender, EventArgs e)
        {
            erpError.SetError(dtpFechaNacimiento, null);
            if (dtpFechaNacimiento.Value > DateTime.Now)
            {
                erpError.SetError(dtpFechaNacimiento, "La fecha de nacimiento no debe ser mayor a la fecha actual");
              
            }
        }

        private void txtEdad_Leave(object sender, EventArgs e)
        {
            erpError.SetError(txtEdad, null);
            if (txtEdad.Text.Length > 3)
            {
                erpError.SetError(txtEdad, "La edad no es válida");

            }

        }

        private void txtTelefonoContacto_Leave(object sender, EventArgs e)
        {
            erpError.SetError(txtTelefonoContacto, null);
            if (txtTelefonoContacto.Text.Length < 7)
            {
                erpError.SetError(txtTelefonoContacto, "El teléfono de contacto no es válido");

            }

        }

        private void txtContactoEmergencia_Leave(object sender, EventArgs e)
        {
            erpError.SetError(txtContactoEmergencia, null);
            if (txtContactoEmergencia.Text.Length < 7)
            {
                erpError.SetError(txtContactoEmergencia, "El contacto de emergencia no es válido");

            }
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            InicioEvaluacion form = new InicioEvaluacion();
            form.Show();
            this.Hide();
        }
    }
    

}
