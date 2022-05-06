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
    public partial class mensajeCorrecto : Form
    {
        public mensajeCorrecto()
        {
            InitializeComponent();
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void outputRespuesta_TextChanged(String Text)
        {
            outputRespuesta.Text = Text;
        }
    }
}
