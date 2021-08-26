using MediTurno.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MediTurno.CapaDatos
{
    public class EmpleadoDAL
    {
        public static List<EmpleadoDTO> Buscar()
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<EmpleadoDTO> res = new List<EmpleadoDTO>();
                var query = db.Empleado
                    .OrderBy(el => el.Persona.Apellidos)
                    .ThenBy(el => el.Persona.Nombres);
                foreach (Empleado temp in query)
                {
                    res.Add(new EmpleadoDTO(
                        temp.Id,
                        new PersonaDTO(
                            temp.Persona.Id,
                            temp.Persona.Dni,
                            temp.Persona.Apellidos,
                            temp.Persona.Nombres,
                            temp.Persona.FechaNacimiento,
                            temp.Persona.Sexo,
                            temp.Persona.CorreoElectronico,
                            temp.Persona.Telefono),
                        temp.Cuil,
                        temp.Usuario,
                        temp.Contraseña,
                        temp.FechaIngreso,
                        new TipoUsuarioDTO(
                            temp.TipoUsuario.Id,
                            temp.TipoUsuario.Descripcion),
                        temp.Activo));
                }
                return res;
            }
        }

        public static EmpleadoDTO Buscar(int id)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                var query = db.Empleado
                    .Where(el => el.Id == id)
                    .First();
                return new EmpleadoDTO(
                    query.Id,
                    new PersonaDTO(
                        query.Persona.Id,
                        query.Persona.Dni,
                        query.Persona.Apellidos,
                        query.Persona.Nombres,
                        query.Persona.FechaNacimiento,
                        query.Persona.Sexo,
                        query.Persona.CorreoElectronico,
                        query.Persona.Telefono),
                    query.Cuil,
                    query.Usuario,
                    query.Contraseña,
                    query.FechaIngreso,
                    new TipoUsuarioDTO(
                        query.TipoUsuario.Id,
                        query.TipoUsuario.Descripcion),
                    query.Activo);
            }
        }

        public static List<EmpleadoDTO> BuscarDni(string dni)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<EmpleadoDTO> res = new List<EmpleadoDTO>();
                var query = db.Empleado
                    .Where(el => el.Persona.Dni.Contains(dni))
                    .OrderBy(el => el.Persona.Apellidos)
                    .ThenBy(el => el.Persona.Nombres);
                foreach (Empleado temp in query)
                {
                    res.Add(new EmpleadoDTO(
                        temp.Id,
                        new PersonaDTO(
                            temp.Persona.Id,
                            temp.Persona.Dni,
                            temp.Persona.Apellidos,
                            temp.Persona.Nombres,
                            temp.Persona.FechaNacimiento,
                            temp.Persona.Sexo,
                            temp.Persona.CorreoElectronico,
                            temp.Persona.Telefono),
                        temp.Cuil,
                        temp.Usuario,
                        temp.Contraseña,
                        temp.FechaIngreso,
                        new TipoUsuarioDTO(
                            temp.TipoUsuario.Id,
                            temp.TipoUsuario.Descripcion),
                        temp.Activo));
                }
                return res;
            }
        }

        public static List<EmpleadoDTO> BuscarApeNom(string apenom)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<EmpleadoDTO> res = new List<EmpleadoDTO>();
                var query = db.Empleado
                    .Where(el => el.Persona.Apellidos.Contains(apenom) || el.Persona.Nombres.Contains(apenom))
                    .OrderBy(el => el.Persona.Apellidos)
                    .ThenBy(el => el.Persona.Nombres);
                foreach (Empleado temp in query)
                {
                    res.Add(new EmpleadoDTO(
                        temp.Id,
                        new PersonaDTO(
                            temp.Persona.Id,
                            temp.Persona.Dni,
                            temp.Persona.Apellidos,
                            temp.Persona.Nombres,
                            temp.Persona.FechaNacimiento,
                            temp.Persona.Sexo,
                            temp.Persona.CorreoElectronico,
                            temp.Persona.Telefono),
                        temp.Cuil,
                        temp.Usuario,
                        temp.Contraseña,
                        temp.FechaIngreso,
                        new TipoUsuarioDTO(
                            temp.TipoUsuario.Id,
                            temp.TipoUsuario.Descripcion),
                        temp.Activo));
                }
                return res;
            }
        }

        public static EmpleadoDTO BuscarUsuario(string usuario)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                var query = db.Empleado
                    .Where(el => el.Usuario == usuario)
                    .FirstOrDefault();
                if (query == null)
                {
                    return null;
                }
                return new EmpleadoDTO(
                    query.Id,
                    new PersonaDTO(
                        query.Persona.Id,
                        query.Persona.Dni,
                        query.Persona.Apellidos,
                        query.Persona.Nombres,
                        query.Persona.FechaNacimiento,
                        query.Persona.Sexo,
                        query.Persona.CorreoElectronico,
                        query.Persona.Telefono),
                    query.Cuil,
                    query.Usuario,
                    query.Contraseña,
                    query.FechaIngreso,
                    new TipoUsuarioDTO(
                        query.TipoUsuario.Id,
                        query.TipoUsuario.Descripcion),
                    query.Activo);
            }
        }

        public static bool Guardar(EmpleadoDTO emp)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                Empleado nuevo = new Empleado();
                nuevo.Cuil = emp.Cuil;
                nuevo.Usuario = emp.Usuario;
                nuevo.Contraseña = emp.Contraseña;
                nuevo.FechaIngreso = emp.FechaIngreso;
                nuevo.TipoUsuarioId = emp.TipoUsuario.Id;
                nuevo.Activo = emp.Activo;
                try
                {
                    if (!PersonaDAL.Guardar(emp.Persona))
                    {
                        return false;
                    }
                    nuevo.PersonaId = PersonaDAL.BuscarDni(emp.Persona.Dni).ElementAt(0).Id;
                    db.Empleado.Add(nuevo);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool Editar(EmpleadoDTO emp)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                Empleado modificado = db.Empleado
                    .Where(el => el.Id == emp.Id)
                    .First();
                modificado.Usuario = emp.Usuario;
                modificado.Contraseña = emp.Contraseña;
                modificado.FechaIngreso = emp.FechaIngreso;
                modificado.TipoUsuarioId = emp.TipoUsuario.Id;
                modificado.Activo = emp.Activo;
                try
                {
                    if (!PersonaDAL.Editar(emp.Persona))
                    {
                        return false;
                    }
                    db.Entry(modificado).State = EntityState.Modified;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
