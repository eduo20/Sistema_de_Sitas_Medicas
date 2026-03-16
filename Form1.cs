using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sistema_de_Sitas_Medicas
{
    public partial class Form1 : Form
    {
        List<Medicos> medicos2 = new List<Medicos>();
        List<Pacientes> pacientes2 = new List<Pacientes>();
        List<Registro> registro2 = new List<Registro>();
        List<horas> horas2 = new List<horas>();
        List<Reporte> reporte2 = new List<Reporte>();
        public Form1()
        {
            InitializeComponent();
        }

        private void LeerHorarios()
        {
            string fileName = @"C:\Users\eduar\Desktop\UMES 2025\3 semestre ing\Progra III\Examen 1\Horas.txt";
            if (File.Exists(fileName))
            {
                FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);
                while (reader.Peek() > -1)
                {
                    horas horitas = new horas();
                    horitas.Hora = reader.ReadLine().Trim();
                    horas2.Add(horitas);
                }
                reader.Close();
            }
        }

        private void LeerPacientes()
        {
            string fileName = @"C:\Users\eduar\Desktop\UMES 2025\3 semestre ing\Progra III\Examen 1\Pacientes.txt";
            if (File.Exists(fileName))
            {
                FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);
                while (reader.Peek() > -1)
                {
                    Pacientes pacientes = new Pacientes();
                    pacientes.Dpi = int.Parse(reader.ReadLine());
                    pacientes.Nombre_p = reader.ReadLine();
                    pacientes.Telefono = int.Parse(reader.ReadLine());
                    pacientes2.Add(pacientes);
                }
                reader.Close();
            }
        }

        private void LeerMedicos()
        {
            string fileName = @"C:\Users\eduar\Desktop\UMES 2025\3 semestre ing\Progra III\Examen 1\Medicos.txt";
            if (File.Exists(fileName))
            {
                FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);
                while (reader.Peek() > -1)
                {
                    Medicos medicos = new Medicos();
                    medicos.Id = int.Parse(reader.ReadLine());
                    medicos.Nomnbre_completo = reader.ReadLine();
                    medicos.Especialidad = reader.ReadLine();
                    medicos2.Add(medicos);
                }
                reader.Close();
            }
        }

        private void LeerCitas()
        {
            string fileName = @"C:\Users\eduar\Desktop\UMES 2025\3 semestre ing\Progra III\Examen 1\Registro.txt";
            if (File.Exists(fileName))
            {
                FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader reader = new StreamReader(stream);
                while (reader.Peek() > -1)
                {
                    Registro registro = new Registro();
                    registro.Id_medic = int.Parse(reader.ReadLine());
                    registro.Dpi_paciente = int.Parse(reader.ReadLine());
                    registro.Fecha_cita = DateTime.Parse(reader.ReadLine());
                    registro.Hora_cita = reader.ReadLine();
                    registro2.Add(registro);
                }
                reader.Close();
            }
        }

        private void GuardarCitas()
        {
            string fileName = @"C:\Users\eduar\Desktop\UMES 2025\3 semestre ing\Progra III\Examen 1\Registro.txt";
            FileStream stream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            foreach (Registro registro in registro2)
            {
                writer.WriteLine(registro.Id_medic);
                writer.WriteLine(registro.Dpi_paciente);
                writer.WriteLine(registro.Fecha_cita);
                writer.WriteLine(registro.Hora_cita);
            }
            writer.Close();
        }

        private void buttonCita_Click(object sender, EventArgs e)
        {
            Medicos medicoSeleccionado = null;
            foreach (Medicos m in medicos2)
            {
                if (m.Nomnbre_completo == comboBoxDoctor.Text)
                {
                    medicoSeleccionado = m;
                    break;
                }
            }

            Pacientes pacienteSeleccionado = null;
            foreach (Pacientes p in pacientes2)
            {
                if (p.Nombre_p == comboBoxPaciente.Text)
                {
                    pacienteSeleccionado = p;
                    break;
                }
            }

            horas Horasseleccionadas = null;
            foreach (horas h in horas2)
            {
                if (h.Hora == comboBoxHora.Text)
                {
                    Horasseleccionadas = h;
                    break;
                }
            }

            Registro nuevaCita = new Registro();
            nuevaCita.Id_medic = medicoSeleccionado.Id;
            nuevaCita.Dpi_paciente = pacienteSeleccionado.Dpi;
            nuevaCita.Fecha_cita = dateTimePickerFecha.Value;
            nuevaCita.Hora_cita = comboBoxHora.Text;

            registro2.Add(nuevaCita);
            GuardarCitas();

            MessageBox.Show("Cita guardada correctamente.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LeerMedicos();
            LeerPacientes();
            LeerHorarios();
            LeerCitas();

            foreach (Medicos m in medicos2)
                comboBoxDoctor.Items.Add(m.Nomnbre_completo);

            foreach (Pacientes p in pacientes2)
                comboBoxPaciente.Items.Add(p.Nombre_p);

            foreach (horas h in horas2)
                comboBoxHora.Items.Add(h.Hora);
        }

        private void buttonReporte_Click(object sender, EventArgs e)
        {
            reporte2.Clear();

            foreach (Registro r in registro2)
            {
                string nombreDoctor = "";

                foreach (Medicos m in medicos2)
                {
                    if (m.Id == r.Id_medic)
                    {
                        nombreDoctor = m.Nomnbre_completo;

                        break;
                    }
                }

                string nombrePaciente = "";
                foreach (Pacientes p in pacientes2)
                {
                    if (p.Dpi == r.Dpi_paciente)
                    {
                        nombrePaciente = p.Nombre_p;
                        break;
                    }
                }

                Reporte reporte = new Reporte();
                reporte.Nombredoc = nombreDoctor;

                reporte.Nombrepa = nombrePaciente;

                reporte2.Add(reporte);
            }

            MostrarReporte();


        }


        private void MostrarReporte()
        {

            dataGridViewCitas.DataSource = null;
            dataGridViewCitas.DataSource = reporte2;
            dataGridViewCitas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void buttonOrdenar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < reporte2.Count - 1; i++)
            {
                for (int j = 0; j < reporte2.Count - 1 - i; j++)
                {
                    if (string.Compare(reporte2[j].Nombredoc, reporte2[j + 1].Nombredoc) > 0)
                    {
                        Reporte temp = reporte2[j];
                        reporte2[j] = reporte2[j + 1];
                        reporte2[j + 1] = temp;
                    }
                }
            }

            MostrarReporte();
        }
    }
}