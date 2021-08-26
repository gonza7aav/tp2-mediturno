using MediTurno.CapaDatos;
using MediTurno.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MediTurno.CapaLogica
{
    public class Paciente
    {
        public static PacienteDTO Buscar(int id)
        {
            return PacienteDAL.Buscar(id);
        }

        public static void CargarDataGridBusqueda(DataGridView grd, int dni)
        {
            grd.Rows.Clear();
            List<PacienteDTO> pacientes = new List<PacienteDTO>();
            pacientes = PacienteDAL.BuscarDni(dni.ToString());
            foreach (PacienteDTO pac in pacientes)
            {
                grd.Rows.Add(
                    pac.Id,
                    pac.Persona.Dni,
                    pac.Persona.Apellidos,
                    pac.Persona.Nombres);
            }
        }

        public static void CargarDataGridBusqueda(DataGridView grd, string apenom)
        {
            grd.Rows.Clear();
            List<PacienteDTO> pacientes = new List<PacienteDTO>();
            pacientes = PacienteDAL.BuscarApeNom(apenom);
            foreach (PacienteDTO pac in pacientes)
            {
                grd.Rows.Add(
                    pac.Id,
                    pac.Persona.Dni,
                    pac.Persona.Apellidos,
                    pac.Persona.Nombres);
            }
        }

        public static void CargarDataGrid(DataGridView grd, EmpleadoDTO emp)
        {
            grd.Rows.Clear();
            List<PacienteDTO> pacientes = new List<PacienteDTO>();
            if (emp.TipoUsuario.Descripcion == "Medico")
            {
                pacientes = PacienteDAL.Buscar(emp);
            }
            else
            {
                pacientes = PacienteDAL.Buscar();
            }

            foreach (PacienteDTO paciente in pacientes)
            {
                grd.Rows.Add(
                    null,
                    null,
                    paciente.Id,
                    paciente.Persona.Apellidos,
                    paciente.Persona.Nombres,
                    paciente.Persona.Dni,
                    CalcularAños(paciente.Persona.FechaNacimiento),
                    paciente.Persona.CorreoElectronico,
                    paciente.Persona.Telefono,
                    (paciente.Persona.Sexo == "M") ? "Masculino" : "Femenino");
            }
        }

        public static void CargarDataGrid(DataGridView grd, EmpleadoDTO emp, string apenom)
        {
            grd.Rows.Clear();
            List<PacienteDTO> pacientes = new List<PacienteDTO>();
            if (emp.TipoUsuario.Descripcion == "Medico")
            {
                pacientes = PacienteDAL.BuscarApeNom(emp, apenom);
            }
            else
            {
                pacientes = PacienteDAL.BuscarApeNom(apenom);
            }

            foreach (PacienteDTO paciente in pacientes)
            {
                grd.Rows.Add(
                    null,
                    null,
                    paciente.Id,
                    paciente.Persona.Apellidos,
                    paciente.Persona.Nombres,
                    paciente.Persona.Dni,
                    CalcularAños(paciente.Persona.FechaNacimiento),
                    paciente.Persona.CorreoElectronico,
                    paciente.Persona.Telefono,
                    (paciente.Persona.Sexo == "M") ? "Masculino" : "Femenino");
            }
        }

        public static void CargarDataGrid(DataGridView grd, EmpleadoDTO emp, int dni)
        {
            grd.Rows.Clear();
            List<PacienteDTO> pacientes = new List<PacienteDTO>();
            if (emp.TipoUsuario.Descripcion == "Medico")
            {
                pacientes = PacienteDAL.BuscarDni(emp, dni.ToString());
            }
            else
            {
                pacientes = PacienteDAL.BuscarDni(dni.ToString());
            }

            foreach (PacienteDTO paciente in pacientes)
            {
                grd.Rows.Add(
                    null,
                    null,
                    paciente.Id,
                    paciente.Persona.Apellidos,
                    paciente.Persona.Nombres,
                    paciente.Persona.Dni,
                    CalcularAños(paciente.Persona.FechaNacimiento),
                    paciente.Persona.CorreoElectronico,
                    paciente.Persona.Telefono,
                    (paciente.Persona.Sexo == "M") ? "Masculino" : "Femenino");
            }
        }

        public static void Guardar(string dni, string ape, string nom, DateTime fn,
            string sexo, string correo, string tel)
        {
            PacienteDTO nuevo = new PacienteDTO(new PersonaDTO(dni, ape, nom, fn, sexo, correo, tel));
            if (PacienteDAL.Guardar(nuevo))
            {
                MessageBox.Show(
                    "El Paciente fue guardado correctamente.",
                    "Exito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Se produjo un error al guardar el Paciente.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void Editar(int id, string dni, string ape, string nom,
            DateTime fn, string sexo, string correo, string tel)
        {
            PacienteDTO pac = PacienteDAL.BuscarDni(dni).ElementAt(0);
            pac.Persona.Apellidos = ape;
            pac.Persona.Nombres = nom;
            pac.Persona.Sexo = sexo;
            pac.Persona.CorreoElectronico = correo;
            pac.Persona.Telefono = tel;
            if (PacienteDAL.Editar(pac))
            {
                MessageBox.Show(
                    "El Paciente fue guardado correctamente.",
                    "Exito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Se produjo un error al guardar el Paciente.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private static int CalcularAños(DateTime fecha)
        {
            int aux = DateTime.Now.Year - fecha.Year;
            if (DateTime.Now.Month < fecha.Month || (DateTime.Now.Month == fecha.Month && DateTime.Now.Day < fecha.Day))
            {
                aux -= 1;
            }
            return aux;
        }
    }
}
