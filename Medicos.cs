using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Sitas_Medicas
{
    internal class Medicos
    {
        int id;
        string nomnbre_completo;
        string especialidad;

        public int Id { get => id; set => id = value; }
        public string Nomnbre_completo { get => nomnbre_completo; set => nomnbre_completo = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
    }
}
