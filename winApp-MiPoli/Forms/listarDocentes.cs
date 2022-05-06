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
    public partial class listarDocentes : Form
    {
        public listarDocentes(DataGridView dataGridView)
        {
            InitializeComponent();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                dataGridViewDocente.Rows.Add();
                dataGridViewDocente.Rows[row.Index].Cells["CodigoDocente"].Value = row.Cells[6].Value;
                dataGridViewDocente.Rows[row.Index].Cells["Nombre"].Value = row.Cells[7].Value;
                dataGridViewDocente.Rows[row.Index].Cells["Apellido"].Value = row.Cells[8].Value;
                dataGridViewDocente.Rows[row.Index].Cells["CarreraDocente"].Value = row.Cells[2].Value;
                dataGridViewDocente.Rows[row.Index].Cells["AsignaturaDocente"].Value = row.Cells[1].Value;
            }
        }
        private void buttonCerrarList_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
