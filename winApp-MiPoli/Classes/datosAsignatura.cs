using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winApp_MiPoli
{
    public class datosAsignatura
    {
        public datosAsignatura()
        {

        }
        public String CodigoAsignatura { get; set; }
        public String nombreAsignatura { get; set; }
        public String carrera { get; set; }
        public String facultad { get; set; }
        public String nivel { get; set; }
        public String numEstudiantes { get; set; }
        public String CodigoDocente { get; set; }
        public String nombreDocente { get; set; }
        public String apellidoDocente { get; set; }
    }
}
