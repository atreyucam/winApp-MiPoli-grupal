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
    public partial class eliminarDocente : Form
    {
        mensajeCorrecto mensajeCorrecto =  new mensajeCorrecto();
        public List<datosAsignatura> valores = new List<datosAsignatura>();
        public eliminarDocente(ref List<winApp_MiPoli.datosAsignatura> valores)
        {
            InitializeComponent();
            this.valores = valores;
            dataGridView1.DataSource = valores;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            string a, b;
            int indice = -1, indice2 = -1;
            a = textBox1.Text;
            b = textBox2.Text;

            indice = valores.FindIndex(x => x.nombreDocente == a);
            indice2 = valores.FindIndex(x => x.apellidoDocente == b);

            if ((indice != -1) && (indice2 != -1))
            {
                mensajeCorrecto.outputRespuesta_TextChanged("Borrado");
                mensajeCorrecto.ShowDialog();
                valores.RemoveAt(indice);
            } else
            {
                MessageBox.Show("El docente ingresado no esta en la nomina");
            }
        }
    }
}
