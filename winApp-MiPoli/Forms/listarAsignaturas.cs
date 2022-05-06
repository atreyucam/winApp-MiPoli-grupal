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
    public partial class listarAsignaturas : Form
    {

        public listarAsignaturas(DataGridView dataGridView)
        {
            InitializeComponent();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                dataGridViewListAsignatura.Rows.Add();
                dataGridViewListAsignatura.Rows[row.Index].Cells["CodigoAsignatura"].Value = row.Cells[0].Value;
                dataGridViewListAsignatura.Rows[row.Index].Cells["NombreAsignatura"].Value = row.Cells[1].Value;
                dataGridViewListAsignatura.Rows[row.Index].Cells["Carrera"].Value = row.Cells[2].Value;
                dataGridViewListAsignatura.Rows[row.Index].Cells["Facultad"].Value = row.Cells[3].Value;
                dataGridViewListAsignatura.Rows[row.Index].Cells["Nivel"].Value = row.Cells[4].Value;
                dataGridViewListAsignatura.Rows[row.Index].Cells["NumEstudiantes"].Value = row.Cells[5].Value;
                dataGridViewListAsignatura.Rows[row.Index].Cells["codDocente"].Value = row.Cells[6].Value;
                dataGridViewListAsignatura.Rows[row.Index].Cells["nombreDocente"].Value = row.Cells[7].Value;
                dataGridViewListAsignatura.Rows[row.Index].Cells["apellidoDocente"].Value = row.Cells[8].Value;
            }
        }

        private void buttonCerrarList_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
