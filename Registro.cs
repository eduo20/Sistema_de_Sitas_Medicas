using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_de_Sitas_Medicas
{
    internal class Registro
    {
        int id_medic;
        int dpi_paciente;
        DateTime fecha_cita;
        string hora_cita;

        public int Id_medic { get => id_medic; set => id_medic = value; }
        public int Dpi_paciente { get => dpi_paciente; set => dpi_paciente = value; }
        public DateTime Fecha_cita { get => fecha_cita; set => fecha_cita = value; }
        public string Hora_cita { get => hora_cita; set => hora_cita = value; }
    }
}
