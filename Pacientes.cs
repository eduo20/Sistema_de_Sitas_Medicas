using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Sitas_Medicas
{
    internal class Pacientes
    {
        int dpi;
        string nombre_p;
        int telefono;

        public int Dpi { get => dpi; set => dpi = value; }
        public string Nombre_p { get => nombre_p; set => nombre_p = value; }
        public int Telefono { get => telefono; set => telefono = value; }
    }
}
