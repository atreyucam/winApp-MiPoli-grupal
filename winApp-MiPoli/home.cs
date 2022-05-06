using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;

namespace winApp_MiPoli
{
    public partial class home : Form
    {
        public List<datosAsignatura> valores = new List<datosAsignatura>();

        bool siderBarExpand;
        public home()
        {
            InitializeComponent();
            menuExt.Visible = false;
            if (panelHome.Controls.Count > 0)
            {
                panelHome.Controls.RemoveAt(0);
            }
            Form ventana;
            ventana = new menuHome();
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            panelHome.Controls.Add(ventana);
            panelHome.Tag = ventana;
            ventana.Show();
        }
        public void reinicio()
        {
            if (panelHome.Controls.Count > 0)
            {
                panelHome.Controls.RemoveAt(0);
            }
            Form ventana;
            ventana = new menuHome();
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            panelHome.Controls.Add(ventana);
            panelHome.Tag = ventana;
            ventana.Show();
        }
        //Animacion del siderBar - panel izquierdo
        private void siderBarTimer_Tick(object sender, EventArgs e)
        {
            if (siderBarExpand)
            {
                siderBarContainer.Width -= 10;
                if (siderBarContainer.Width == siderBarContainer.MinimumSize.Width)
                {
                    siderBarExpand = false;
                    siderBarTimer.Stop();
                    menuExt.Visible = true;
                }
            }
            else
            {
                siderBarContainer.Width += 10;
                menuExt.Visible = false;
                if (siderBarContainer.Width == siderBarContainer.MaximumSize.Width)
                {
                    siderBarExpand = true;
                    siderBarTimer.Stop();
                }
            }
        }
        private void Menubutton_Click(object sender, EventArgs e)
        {
            siderBarTimer.Start();
        }

        private void menuExt_Click(object sender, EventArgs e)
        {
            siderBarTimer.Start();
        }
        //----------------------------------------------------------------------------
        private void homeButton_Click(object sender, EventArgs e)
        {
            if (panelHome.Controls.Count > 0)
            {
                panelHome.Controls.RemoveAt(0);
            }
            Form ventana;
            ventana = new menuHome();
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            panelHome.Controls.Add(ventana);
            panelHome.Tag = ventana;
            ventana.Show();
            Reset();
        }
        private void Reset()
        {
            labelTitle.Text = "Página de inicio";
        }
        //----------------------------------------------------------------------------
        //Forms
        private void buttonIngresoDatos_Click(object sender, EventArgs e)
        {
            if (panelHome.Controls.Count > 0)
            {
                panelHome.Controls.RemoveAt(0);
            }
            Form ventana;
            ventana = new Asignaturas(ref valores);
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            panelHome.Controls.Add(ventana);
            panelHome.Tag = ventana;
            labelTitle.Text = ventana.Text;
            ventana.Show();
        }

        private void buttonBusqueda_Click(object sender, EventArgs e)
        {
            if (panelHome.Controls.Count > 0)
            {
                panelHome.Controls.RemoveAt(0);
            }
            Form ventana;
            ventana = new buscarAsignatura(valores);
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            panelHome.Controls.Add(ventana);
            panelHome.Tag = ventana;
            labelTitle.Text = ventana.Text;
            ventana.Show();
        }
        private void buttonEditarDatos_Click(object sender, EventArgs e)
        {

        }

        private void buttonEliminarDatos_Click(object sender, EventArgs e)
        {
            if (panelHome.Controls.Count > 0)
            {
                panelHome.Controls.RemoveAt(0);
            }
            Form ventana;
            ventana = new eliminarDocente(ref valores);
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            panelHome.Controls.Add(ventana);
            panelHome.Tag = ventana;
            labelTitle.Text = ventana.Text;
            ventana.Show();
        }
        private void buttonListarDatos_Click(object sender, EventArgs e)
        {
            if (panelHome.Controls.Count > 0)
            {
                panelHome.Controls.RemoveAt(0);
            }
            Form ventana;
            ventana = new listarDatos(valores);
            ventana.TopLevel = false;
            ventana.Dock = DockStyle.Fill;
            panelHome.Controls.Add(ventana);
            panelHome.Tag = ventana;
            labelTitle.Text = ventana.Text;
            ventana.Show();
        }

        private void salirMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void abrirAyudaYSoporteMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://muddy-triangle-e3b.notion.site/Documentaci-n-proyecto-0cea452161f049f38fa829bff4c2b1cd");
        }

        private void panelHome_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
