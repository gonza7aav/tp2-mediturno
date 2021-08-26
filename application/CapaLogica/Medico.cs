using MediTurno.CapaDatos;
using MediTurno.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MediTurno.CapaLogica
{
    public class Medico
    {
        public static MedicoDTO Buscar(int id)
        {
            return MedicoDAL.Buscar(id);
        }

        public static MedicoDTO BuscarDni(string dni)
        {
            return MedicoDAL.BuscarDni(dni).ElementAt(0);
        }

        public static void CargarDataGridBusqueda(DataGridView grd, int dni)
        {
            grd.Rows.Clear();
            List<MedicoDTO> medicos = new List<MedicoDTO>();
            medicos = MedicoDAL.BuscarDni(dni.ToString());
            foreach (MedicoDTO med in medicos)
            {
                if (med.Empleado.Activo)
                {
                    grd.Rows.Add(
                        med.Id,
                        med.Empleado.Persona.Dni,
                        med.Empleado.Persona.Apellidos,
                        med.Empleado.Persona.Nombres,
                        med.Especialidad.Descripcion,
                        med.Matricula);
                }
            }
        }

        public static void CargarDataGridBusqueda(DataGridView grd, string apenom)
        {
            grd.Rows.Clear();
            List<MedicoDTO> medicos = new List<MedicoDTO>();
            medicos = MedicoDAL.BuscarApeNom(apenom);
            foreach (MedicoDTO med in medicos)
            {
                if (med.Empleado.Activo)
                {
                    grd.Rows.Add(
                        med.Id,
                        med.Empleado.Persona.Dni,
                        med.Empleado.Persona.Apellidos,
                        med.Empleado.Persona.Nombres,
                        med.Especialidad.Descripcion,
                        med.Matricula);
                }
            }
        }

        public static void CargarDataGrid(DataGridView grd)
        {
            grd.Rows.Clear();
            List<MedicoDTO> medicos = new List<MedicoDTO>();
            medicos = MedicoDAL.Buscar();
            foreach (MedicoDTO med in medicos)
            {
                grd.Rows.Add(
                    null,
                    med.Id,
                    med.Empleado.Id,
                    med.Empleado.Persona.Id,
                    med.Empleado.Persona.Apellidos,
                    med.Empleado.Persona.Nombres,
                    med.Empleado.Persona.Dni,
                    med.Empleado.Cuil,
                    med.Matricula,
                    med.Especialidad.Descripcion,
                    CalcularAños(med.Empleado.Persona.FechaNacimiento),
                    med.Empleado.Persona.CorreoElectronico,
                    med.Empleado.Persona.Telefono,
                    (med.Empleado.Persona.Sexo == "M") ? "Masculino" : "Femenino",
                    med.Empleado.Activo);
            }
        }

        public static void CargarDataGrid(DataGridView grd, int dni)
        {
            grd.Rows.Clear();
            List<MedicoDTO> medicos = new List<MedicoDTO>();
            medicos = MedicoDAL.BuscarDni(dni.ToString());
            foreach (MedicoDTO med in medicos)
            {
                grd.Rows.Add(
                    null,
                    med.Id,
                    med.Empleado.Id,
                    med.Empleado.Persona.Id,
                    med.Empleado.Persona.Apellidos,
                    med.Empleado.Persona.Nombres,
                    med.Empleado.Persona.Dni,
                    med.Empleado.Cuil,
                    med.Matricula,
                    med.Especialidad.Descripcion,
                    CalcularAños(med.Empleado.Persona.FechaNacimiento),
                    med.Empleado.Persona.CorreoElectronico,
                    med.Empleado.Persona.Telefono,
                    (med.Empleado.Persona.Sexo == "M") ? "Masculino" : "Femenino",
                    med.Empleado.Activo);
            }
        }

        public static void CargarDataGrid(DataGridView grd, string apenom)
        {
            grd.Rows.Clear();
            List<MedicoDTO> medicos = new List<MedicoDTO>();
            medicos = MedicoDAL.BuscarApeNom(apenom);
            foreach (MedicoDTO med in medicos)
            {
                grd.Rows.Add(
                    null,
                    med.Id,
                    med.Empleado.Id,
                    med.Empleado.Persona.Id,
                    med.Empleado.Persona.Apellidos,
                    med.Empleado.Persona.Nombres,
                    med.Empleado.Persona.Dni,
                    med.Empleado.Cuil,
                    med.Matricula,
                    med.Especialidad.Descripcion,
                    CalcularAños(med.Empleado.Persona.FechaNacimiento),
                    med.Empleado.Persona.CorreoElectronico,
                    med.Empleado.Persona.Telefono,
                    (med.Empleado.Persona.Sexo == "M") ? "Masculino" : "Femenino",
                    med.Empleado.Activo);
            }
        }

        public static void Guardar(string dni, string ape, string nom, DateTime fn, string sexo,
            string correo, string tel, string cuil, string usuario, string contra, DateTime fi,
            bool activo, string matricula, int especialidad)
        {
            PersonaDTO per = new PersonaDTO(dni, ape, nom, fn, sexo, correo, tel);
            EmpleadoDTO emp = new EmpleadoDTO(per, cuil, usuario, contra, fi, TipoUsuarioDAL.Buscar(3), activo);
            MedicoDTO med = new MedicoDTO(emp, matricula, EspecialidadDAL.Buscar(especialidad));
            if (MedicoDAL.Guardar(med))
            {
                MessageBox.Show(
                    "El Medico fue guardado correctamente.",
                    "Exito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Se produjo un error al guardar el Medico.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void Editar(int id, string dni, string ape, string nom, DateTime fn, string sexo,
            string correo, string tel, string cuil, string usuario, string contra, DateTime fi,
            bool activo, string matricula, int especialidad)
        {
            MedicoDTO med = MedicoDAL.BuscarDni(dni).ElementAt(0);
            med.Empleado.Persona.Apellidos = ape;
            med.Empleado.Persona.Nombres = nom;
            med.Empleado.Persona.Sexo = sexo;
            med.Empleado.Persona.CorreoElectronico = correo;
            med.Empleado.Persona.Telefono = tel;
            med.Empleado.Usuario = usuario;
            med.Empleado.Contraseña = contra;
            med.Empleado.FechaIngreso = fi;
            med.Empleado.Activo = activo;
            med.Matricula = matricula;
            med.Especialidad = EspecialidadDAL.Buscar(especialidad);
            if (MedicoDAL.Editar(med))
            {
                MessageBox.Show(
                    "El Medico fue modificado correctamente.",
                    "Exito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Se produjo un error al modificar el Medico.",
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
