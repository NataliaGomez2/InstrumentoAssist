using System;
using System.Windows.Forms;

namespace InstrumentodeMedicionAssist
{
    public partial class FormularioIngreso : Form
    {
        public FormularioIngreso()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (ValidarUsuario())
            {
                Menu form = new Menu();
                form.Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Los datos de autentificación no son válidos.", "Usuario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private bool ValidarUsuario()
        {
            if(txtUsuario.Text!="GomezTaborda" && txtContraseña.Text!="2022")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

       
    }
}
