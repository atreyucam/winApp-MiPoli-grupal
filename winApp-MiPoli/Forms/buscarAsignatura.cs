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
    public partial class buscarAsignatura : Form
    {
        public List<datosAsignatura> valores = new List<datosAsignatura>();
        public buscarAsignatura(List<winApp_MiPoli.datosAsignatura> valores)
        {
            InitializeComponent();
            this.valores = valores;
            dataGridView1.DataSource = valores;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
