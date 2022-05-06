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
    public partial class Asignaturas : Form
    {
        mensajeCorrecto objMensajeCorrecto = new mensajeCorrecto();
        mensajeError objMensajeError = new mensajeError();
        public List<datosAsignatura> valores = new List<datosAsignatura>();

        public Asignaturas(ref List<winApp_MiPoli.datosAsignatura> valores)
        {
            InitializeComponent();
            this.valores = valores;
            dtgvAsignatura.DataSource = valores;
        }
        private void enter_keyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
        }
        private void nivelesDisponibles(object sender, EventArgs e)
        {
            comboBoxNiveles.Items.Add("1");
            comboBoxNiveles.Items.Add("2");
            comboBoxNiveles.Items.Add("3");
            comboBoxNiveles.Items.Add("4");
            comboBoxNiveles.Items.Add("5");
            comboBoxNiveles.Items.Add("6");
            comboBoxNiveles.Items.Add("7");
            comboBoxNiveles.Items.Add("8");
            comboBoxNiveles.Items.Add("9");
            comboBoxNiveles.Items.Add("10");
        }
        void limpiarFormulario()
        {
            textCodigo.Text = "";
            textCarrera.Text = "";
            textNombre.Text = "";
            textFacultad.Text = "";
            comboBoxNiveles.Text = "";
            textNumEstudiantes.Text = "";
            textCodigoDocente.Text = "";
            textNombreDocente.Text = "";
            textApellidoDocente.Text = "";
        }
        private void buttonGuardarAsignatura_Click(object sender, EventArgs e)
        {
            datosAsignatura newAsignatura = new datosAsignatura()
            {
                CodigoAsignatura = textCodigo.Text,
                nombreAsignatura = textNombre.Text,
                carrera = textCarrera.Text,
                facultad = textFacultad.Text,
                nivel = comboBoxNiveles.Text,
                numEstudiantes = textNumEstudiantes.Text,
                CodigoDocente = textCodigoDocente.Text,
                nombreDocente = textNombreDocente.Text,
                apellidoDocente = textApellidoDocente.Text
            };
            if (agregarAsignatura(newAsignatura))
            {
                objMensajeCorrecto.outputRespuesta_TextChanged("Asisgnatura registrada");
                objMensajeCorrecto.ShowDialog();
            }
            limpiarFormulario();
        }
        public bool agregarAsignatura(datosAsignatura datoAsignatura)
        {
            bool existe = valores.Any(x => x.CodigoAsignatura.Equals(datoAsignatura.CodigoAsignatura));
            
            if (!existe)
            {
                valores.Add(datoAsignatura);
                dtgvAsignatura.DataSource = null;
                dtgvAsignatura.DataSource = valores;
                return true;
            }
            else
            {
                objMensajeError.outputRespuesta_TextChanged("Codigo ya registrado");
                objMensajeError.ShowDialog();
                return false;
            }
        }
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelFormularioAsignatura_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
