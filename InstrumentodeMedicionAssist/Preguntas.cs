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
    public partial class Preguntas : Form
    {
        public Preguntas()
        {
            InitializeComponent();
        }

        private void btnFinalizarPreguntas_Click(object sender, EventArgs e)
        {
            Resultados form = new Resultados();
            form.Show();
            this.Hide();
        }
    }
}
