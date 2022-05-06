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
    public partial class listarDatos : Form
    {
        public List<datosAsignatura> valores = new List<datosAsignatura>();
        public listarDatos(List<winApp_MiPoli.datosAsignatura> valores)
        {
            InitializeComponent();
            this.valores = valores;
            dt1.DataSource = valores;
            dt1.Visible = false;

        }
        private void buttonListCarreras_Click(object sender, EventArgs e)
        {
            if (contentMain.Controls.Count > 0)
            {
                contentMain.Controls.RemoveAt(0);
            }
            Form ventana;
            ventana = new listarCarreras(dt1);
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            contentMain.Controls.Add(ventana);
            contentMain.Tag = ventana;
            //labelTitle.Text = ventana.Text;
            ventana.Show();
        }
        private void buttonListAsignaturas_Click(object sender, EventArgs e)
        {
            if (contentMain.Controls.Count > 0)
            {
                contentMain.Controls.RemoveAt(0);
            }
            Form ventana;
            ventana = new listarAsignaturas(dt1);
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            contentMain.Controls.Add(ventana);
            contentMain.Tag = ventana;
            //labelTitle.Text = ventana.Text;
            ventana.Show();
        }
        private void buttonListDocentes_Click(object sender, EventArgs e)
        {
            if (contentMain.Controls.Count > 0)
            {
                contentMain.Controls.RemoveAt(0);
            }
            Form ventana;
            ventana = new listarDocentes(dt1);
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            contentMain.Controls.Add(ventana);
            contentMain.Tag = ventana;
            //labelTitle.Text = ventana.Text;
            ventana.Show();
        }
        private void buttonListAsigEliminadas_Click(object sender, EventArgs e)
        {
            if (contentMain.Controls.Count > 0)
            {
                contentMain.Controls.RemoveAt(0);
            }
            Form ventana;
            ventana = new listarAsignaturasEliminadas();
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            contentMain.Controls.Add(ventana);
            contentMain.Tag = ventana;
            //labelTitle.Text = ventana.Text;
            ventana.Show();
        }
        private void buttonListDocEliminados_Click(object sender, EventArgs e)
        {
            if (contentMain.Controls.Count > 0)
            {
                contentMain.Controls.RemoveAt(0);
            }
            Form ventana;
            ventana = new listarDocentesEliminados();
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            contentMain.Controls.Add(ventana);
            contentMain.Tag = ventana;
            //labelTitle.Text = ventana.Text;
            ventana.Show();
        }
        private void buttonCerrarList_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void contentMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
