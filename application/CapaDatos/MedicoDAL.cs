using MediTurno.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MediTurno.CapaDatos
{
    public class MedicoDAL
    {
        public static List<MedicoDTO> Buscar()
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<MedicoDTO> res = new List<MedicoDTO>();
                var query = db.Medico
                    .OrderBy(el => el.Empleado.Persona.Apellidos)
                    .ThenBy(el => el.Empleado.Persona.Nombres);
                foreach (Medico temp in query)
                {
                    res.Add(new MedicoDTO(
                        temp.Id,
                        new EmpleadoDTO(
                            temp.Empleado.Id,
                            new PersonaDTO(
                                temp.Empleado.Persona.Id,
                                temp.Empleado.Persona.Dni,
                                temp.Empleado.Persona.Apellidos,
                                temp.Empleado.Persona.Nombres,
                                temp.Empleado.Persona.FechaNacimiento,
                                temp.Empleado.Persona.Sexo,
                                temp.Empleado.Persona.CorreoElectronico,
                                temp.Empleado.Persona.Telefono),
                            temp.Empleado.Cuil,
                            temp.Empleado.Usuario,
                            temp.Empleado.Contraseña,
                            temp.Empleado.FechaIngreso,
                            new TipoUsuarioDTO(
                                temp.Empleado.TipoUsuario.Id,
                                temp.Empleado.TipoUsuario.Descripcion),
                            temp.Empleado.Activo),
                        temp.Matricula,
                        new EspecialidadDTO(
                            temp.Especialidad.Id,
                            temp.Especialidad.Descripcion)));
                }
                return res;
            }
        }

        public static MedicoDTO Buscar(int id)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<MedicoDTO> res = new List<MedicoDTO>();
                var query = db.Medico
                    .Where(el => el.Id == id)
                    .First();
                return new MedicoDTO(
                    query.Id,
                    new EmpleadoDTO(
                        query.Empleado.Id,
                        new PersonaDTO(
                            query.Empleado.Persona.Id,
                            query.Empleado.Persona.Dni,
                            query.Empleado.Persona.Apellidos,
                            query.Empleado.Persona.Nombres,
                            query.Empleado.Persona.FechaNacimiento,
                            query.Empleado.Persona.Sexo,
                            query.Empleado.Persona.CorreoElectronico,
                            query.Empleado.Persona.Telefono),
                        query.Empleado.Cuil,
                        query.Empleado.Usuario,
                        query.Empleado.Contraseña,
                        query.Empleado.FechaIngreso,
                        new TipoUsuarioDTO(
                            query.Empleado.TipoUsuario.Id,
                            query.Empleado.TipoUsuario.Descripcion),
                        query.Empleado.Activo),
                    query.Matricula,
                    new EspecialidadDTO(
                        query.Especialidad.Id,
                        query.Especialidad.Descripcion));
            }
        }

        public static List<MedicoDTO> BuscarDni(string dni)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<MedicoDTO> res = new List<MedicoDTO>();
                var query = db.Medico
                    .Where(el => el.Empleado.Persona.Dni.Contains(dni))
                    .OrderBy(el => el.Empleado.Persona.Apellidos)
                    .ThenBy(el => el.Empleado.Persona.Nombres);
                foreach (Medico temp in query)
                {
                    res.Add(new MedicoDTO(
                        temp.Id,
                        new EmpleadoDTO(
                            temp.Empleado.Id,
                            new PersonaDTO(
                                temp.Empleado.Persona.Id,
                                temp.Empleado.Persona.Dni,
                                temp.Empleado.Persona.Apellidos,
                                temp.Empleado.Persona.Nombres,
                                temp.Empleado.Persona.FechaNacimiento,
                                temp.Empleado.Persona.Sexo,
                                temp.Empleado.Persona.CorreoElectronico,
                                temp.Empleado.Persona.Telefono),
                            temp.Empleado.Cuil,
                            temp.Empleado.Usuario,
                            temp.Empleado.Contraseña,
                            temp.Empleado.FechaIngreso,
                            new TipoUsuarioDTO(
                                temp.Empleado.TipoUsuario.Id,
                                temp.Empleado.TipoUsuario.Descripcion),
                            temp.Empleado.Activo),
                        temp.Matricula,
                        new EspecialidadDTO(
                            temp.Especialidad.Id,
                            temp.Especialidad.Descripcion)));
                }
                return res;
            }
        }

        public static List<MedicoDTO> BuscarApeNom(string apenom)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<MedicoDTO> res = new List<MedicoDTO>();
                var query = db.Medico
                    .Where(el => el.Empleado.Persona.Apellidos.Contains(apenom) || el.Empleado.Persona.Nombres.Contains(apenom))
                    .OrderBy(el => el.Empleado.Persona.Apellidos)
                    .ThenBy(el => el.Empleado.Persona.Nombres);
                foreach (Medico temp in query)
                {
                    res.Add(new MedicoDTO(
                        temp.Id,
                        new EmpleadoDTO(
                            temp.Empleado.Id,
                            new PersonaDTO(
                                temp.Empleado.Persona.Id,
                                temp.Empleado.Persona.Dni,
                                temp.Empleado.Persona.Apellidos,
                                temp.Empleado.Persona.Nombres,
                                temp.Empleado.Persona.FechaNacimiento,
                                temp.Empleado.Persona.Sexo,
                                temp.Empleado.Persona.CorreoElectronico,
                                temp.Empleado.Persona.Telefono),
                            temp.Empleado.Cuil,
                            temp.Empleado.Usuario,
                            temp.Empleado.Contraseña,
                            temp.Empleado.FechaIngreso,
                            new TipoUsuarioDTO(
                                temp.Empleado.TipoUsuario.Id,
                                temp.Empleado.TipoUsuario.Descripcion),
                            temp.Empleado.Activo),
                        temp.Matricula,
                        new EspecialidadDTO(
                            temp.Especialidad.Id,
                            temp.Especialidad.Descripcion)));
                }
                return res;
            }
        }

        public static bool Guardar(MedicoDTO med)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                Medico nuevo = new Medico();
                nuevo.Matricula = med.Matricula;
                nuevo.EspecialidadId = med.Especialidad.Id;
                try
                {
                    if (!EmpleadoDAL.Guardar(med.Empleado))
                    {
                        return false;
                    }
                    nuevo.EmpleadoId = EmpleadoDAL.BuscarDni(med.Empleado.Persona.Dni).ElementAt(0).Id;
                    db.Medico.Add(nuevo);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool Editar(MedicoDTO med)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                Medico modificado = db.Medico
                    .Where(el => el.Id == med.Id)
                    .First();
                modificado.Matricula = med.Matricula;
                modificado.EspecialidadId = med.Especialidad.Id;
                try
                {
                    if (!EmpleadoDAL.Editar(med.Empleado))
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
