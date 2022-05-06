using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winApp_MiPoli
{
    public partial class mensajeError : Form
    {
        public mensajeError()
        {
            InitializeComponent();
        }

        public void outputRespuesta_TextChanged(String Text)
        {
            outputRespuesta.Text = Text;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
