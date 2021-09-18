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
    public partial class InicioEvaluacion : Form
    {
        public InicioEvaluacion()
        {
            InitializeComponent();
        }
        
        

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            Preguntas form = new Preguntas();
            form.Show();
            this.Hide();
        }
    }
}
