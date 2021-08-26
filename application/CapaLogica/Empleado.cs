using MediTurno.CapaDatos;
using MediTurno.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MediTurno.CapaLogica
{
    public class Empleado
    {
        public static EmpleadoDTO BuscarDni(string dni)
        {
            return EmpleadoDAL.BuscarDni(dni).ElementAt(0);
        }

        public static EmpleadoDTO Ingresar(string usuario, string contraseña)
        {
            EmpleadoDTO buscado = EmpleadoDAL.BuscarUsuario(usuario);
            // fix cifrar
            return (buscado != null && buscado.Activo && buscado.Contraseña.Equals(contraseña)) ? buscado : null;
        }

        public static void CargarDataGrid(DataGridView grd)
        {
            grd.Rows.Clear();
            List<EmpleadoDTO> empleados = new List<EmpleadoDTO>();
            empleados = EmpleadoDAL.Buscar();
            foreach (EmpleadoDTO emp in empleados)
            {
                grd.Rows.Add(
                    (emp.TipoUsuario.Id == 0) ? null : MediTurno.Properties.Resources.feather_edit,
                    emp.Id,
                    emp.Persona.Id,
                    emp.Persona.Apellidos,
                    emp.Persona.Nombres,
                    emp.Persona.Dni,
                    emp.Cuil,
                    CalcularAños(emp.Persona.FechaNacimiento),
                    CalcularAños(emp.FechaIngreso),
                    emp.TipoUsuario.Descripcion,
                    emp.Usuario,
                    emp.Persona.CorreoElectronico,
                    emp.Persona.Telefono,
                    (emp.Persona.Sexo == "M") ? "Masculino" : "Femenino",
                    emp.Activo);
            }
        }

        public static void CargarDataGrid(DataGridView grd, int dni)
        {
            grd.Rows.Clear();
            List<EmpleadoDTO> empleados = new List<EmpleadoDTO>();
            empleados = EmpleadoDAL.BuscarDni(dni.ToString());
            foreach (EmpleadoDTO emp in empleados)
            {
                grd.Rows.Add(
                    (emp.TipoUsuario.Id == 0) ? null : MediTurno.Properties.Resources.feather_edit,
                    emp.Id,
                    emp.Persona.Id,
                    emp.Persona.Apellidos,
                    emp.Persona.Nombres,
                    emp.Persona.Dni,
                    emp.Cuil,
                    CalcularAños(emp.Persona.FechaNacimiento),
                    CalcularAños(emp.FechaIngreso),
                    emp.TipoUsuario.Descripcion,
                    emp.Usuario,
                    emp.Persona.CorreoElectronico,
                    emp.Persona.Telefono,
                    (emp.Persona.Sexo == "M") ? "Masculino" : "Femenino",
                    emp.Activo);
            }
        }

        public static void CargarDataGrid(DataGridView grd, string apenom)
        {
            grd.Rows.Clear();
            List<EmpleadoDTO> empleados = new List<EmpleadoDTO>();
            empleados = EmpleadoDAL.BuscarApeNom(apenom);
            foreach (EmpleadoDTO emp in empleados)
            {
                grd.Rows.Add(
                    (emp.TipoUsuario.Id == 0) ? null : MediTurno.Properties.Resources.feather_edit,
                    emp.Id,
                    emp.Persona.Id,
                    emp.Persona.Apellidos,
                    emp.Persona.Nombres,
                    emp.Persona.Dni,
                    emp.Cuil,
                    CalcularAños(emp.Persona.FechaNacimiento),
                    CalcularAños(emp.FechaIngreso),
                    emp.TipoUsuario.Descripcion,
                    emp.Usuario,
                    emp.Persona.CorreoElectronico,
                    emp.Persona.Telefono,
                    (emp.Persona.Sexo == "M") ? "Masculino" : "Femenino",
                    emp.Activo);
            }
        }

        public static void Guardar(string dni, string ape, string nom, DateTime fn, string sexo,
            string correo, string tel, string cuil, string usuario, string contra, DateTime fi,
            int tipo, bool activo)
        {
            PersonaDTO per = new PersonaDTO(dni, ape, nom, fn, sexo, correo, tel);
            EmpleadoDTO emp = new EmpleadoDTO(per, cuil, usuario, contra, fi, TipoUsuarioDAL.Buscar(tipo), activo);
            if (EmpleadoDAL.Guardar(emp))
            {
                MessageBox.Show(
                    "El Empleado fue guardado correctamente.",
                    "Exito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Se produjo un error al guardar el Empleado.",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public static void Editar(int id, string dni, string ape, string nom, DateTime fn,
            string sexo, string correo, string tel, string cuil, string usuario, string contra,
            DateTime fi, int tipo, bool activo)
        {
            PersonaDTO per = PersonaDAL.BuscarDni(dni).ElementAt(0);
            per.Apellidos = ape;
            per.Nombres = nom;
            per.Sexo = sexo;
            per.CorreoElectronico = correo;
            per.Telefono = tel;
            EmpleadoDTO modificado = new EmpleadoDTO(id, per, cuil, usuario, contra, fi, TipoUsuarioDAL.Buscar(tipo), activo);
            if (EmpleadoDAL.Editar(modificado))
            {
                MessageBox.Show(
                    "El Empleado fue modificado correctamente.",
                    "Exito",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    "Se produjo un error al modificar el Empleado.",
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
