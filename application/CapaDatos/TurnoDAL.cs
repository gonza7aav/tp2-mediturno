using MediTurno.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MediTurno.CapaDatos
{
    public class TurnoDAL
    {
        public static List<TurnoDTO> Buscar()
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<TurnoDTO> res = new List<TurnoDTO>();
                var query = db.Turno
                    .OrderBy(el => el.FechaHora);
                foreach (Turno temp in query)
                {
                    res.Add(new TurnoDTO(
                        temp.Id,
                        new MedicoDTO(
                            temp.Medico.Id,
                            new EmpleadoDTO(
                                temp.Medico.Empleado.Id,
                                new PersonaDTO(
                                    temp.Medico.Empleado.Persona.Id,
                                    temp.Medico.Empleado.Persona.Dni,
                                    temp.Medico.Empleado.Persona.Apellidos,
                                    temp.Medico.Empleado.Persona.Nombres,
                                    temp.Medico.Empleado.Persona.FechaNacimiento,
                                    temp.Medico.Empleado.Persona.Sexo,
                                    temp.Medico.Empleado.Persona.CorreoElectronico,
                                    temp.Medico.Empleado.Persona.Telefono),
                                temp.Medico.Empleado.Cuil,
                                temp.Medico.Empleado.Usuario,
                                temp.Medico.Empleado.Contraseña,
                                temp.Medico.Empleado.FechaIngreso,
                                new TipoUsuarioDTO(
                                    temp.Medico.Empleado.TipoUsuario.Id,
                                    temp.Medico.Empleado.TipoUsuario.Descripcion),
                                temp.Medico.Empleado.Activo),
                            temp.Medico.Matricula,
                            new EspecialidadDTO(
                                temp.Medico.Especialidad.Id,
                                temp.Medico.Especialidad.Descripcion)),
                        new PacienteDTO(
                            temp.Paciente.Id,
                            new PersonaDTO(
                                temp.Paciente.Persona.Id,
                                temp.Paciente.Persona.Dni,
                                temp.Paciente.Persona.Apellidos,
                                temp.Paciente.Persona.Nombres,
                                temp.Paciente.Persona.FechaNacimiento,
                                temp.Paciente.Persona.Sexo,
                                temp.Paciente.Persona.CorreoElectronico,
                                temp.Paciente.Persona.Telefono)),
                        temp.FechaHora,
                        new CoberturaDTO(
                            temp.Cobertura.Id,
                            new ObraSocialDTO(
                                temp.Cobertura.ObraSocial.Id,
                                temp.Cobertura.ObraSocial.Nombre,
                                temp.Cobertura.ObraSocial.Estado),
                            temp.Cobertura.Descripcion,
                            temp.Cobertura.Estado),
                        new TurnoEstadoDTO(
                            temp.TurnoEstado.Id,
                            temp.TurnoEstado.Descripcion)));
                }
                return res;
            }
        }

        public static TurnoDTO Buscar(int id)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<TurnoDTO> res = new List<TurnoDTO>();
                var query = db.Turno
                    .Where(el => el.Id == id)
                    .First();
                return new TurnoDTO(
                    query.Id,
                    new MedicoDTO(
                        query.Medico.Id,
                        new EmpleadoDTO(
                            query.Medico.Empleado.Id,
                            new PersonaDTO(
                                query.Medico.Empleado.Persona.Id,
                                query.Medico.Empleado.Persona.Dni,
                                query.Medico.Empleado.Persona.Apellidos,
                                query.Medico.Empleado.Persona.Nombres,
                                query.Medico.Empleado.Persona.FechaNacimiento,
                                query.Medico.Empleado.Persona.Sexo,
                                query.Medico.Empleado.Persona.CorreoElectronico,
                                query.Medico.Empleado.Persona.Telefono),
                            query.Medico.Empleado.Cuil,
                            query.Medico.Empleado.Usuario,
                            query.Medico.Empleado.Contraseña,
                            query.Medico.Empleado.FechaIngreso,
                            new TipoUsuarioDTO(
                                query.Medico.Empleado.TipoUsuario.Id,
                                query.Medico.Empleado.TipoUsuario.Descripcion),
                            query.Medico.Empleado.Activo),
                        query.Medico.Matricula,
                        new EspecialidadDTO(
                            query.Medico.Especialidad.Id,
                            query.Medico.Especialidad.Descripcion)),
                    new PacienteDTO(
                        query.Paciente.Id,
                        new PersonaDTO(
                            query.Paciente.Persona.Id,
                            query.Paciente.Persona.Dni,
                            query.Paciente.Persona.Apellidos,
                            query.Paciente.Persona.Nombres,
                            query.Paciente.Persona.FechaNacimiento,
                            query.Paciente.Persona.Sexo,
                            query.Paciente.Persona.CorreoElectronico,
                            query.Paciente.Persona.Telefono)),
                    query.FechaHora,
                    new CoberturaDTO(
                        query.Cobertura.Id,
                        new ObraSocialDTO(
                            query.Cobertura.ObraSocial.Id,
                            query.Cobertura.ObraSocial.Nombre,
                            query.Cobertura.ObraSocial.Estado),
                        query.Cobertura.Descripcion,
                        query.Cobertura.Estado),
                    new TurnoEstadoDTO(
                        query.TurnoEstado.Id,
                        query.TurnoEstado.Descripcion));
            }
        }

        public static List<TurnoDTO> Buscar(DateTime desde, DateTime hasta)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<TurnoDTO> res = new List<TurnoDTO>();
                var query = db.Turno
                    .Where(el => DateTime.Compare(el.FechaHora, desde) >= 0 &&
                        DateTime.Compare(el.FechaHora, hasta) <= 0)
                    .OrderBy(el => el.FechaHora);
                foreach (Turno temp in query)
                {
                    res.Add(new TurnoDTO(
                        temp.Id,
                        new MedicoDTO(
                            temp.Medico.Id,
                            new EmpleadoDTO(
                                temp.Medico.Empleado.Id,
                                new PersonaDTO(
                                    temp.Medico.Empleado.Persona.Id,
                                    temp.Medico.Empleado.Persona.Dni,
                                    temp.Medico.Empleado.Persona.Apellidos,
                                    temp.Medico.Empleado.Persona.Nombres,
                                    temp.Medico.Empleado.Persona.FechaNacimiento,
                                    temp.Medico.Empleado.Persona.Sexo,
                                    temp.Medico.Empleado.Persona.CorreoElectronico,
                                    temp.Medico.Empleado.Persona.Telefono),
                                temp.Medico.Empleado.Cuil,
                                temp.Medico.Empleado.Usuario,
                                temp.Medico.Empleado.Contraseña,
                                temp.Medico.Empleado.FechaIngreso,
                                new TipoUsuarioDTO(
                                    temp.Medico.Empleado.TipoUsuario.Id,
                                    temp.Medico.Empleado.TipoUsuario.Descripcion),
                                temp.Medico.Empleado.Activo),
                            temp.Medico.Matricula,
                            new EspecialidadDTO(
                                temp.Medico.Especialidad.Id,
                                temp.Medico.Especialidad.Descripcion)),
                        new PacienteDTO(
                            temp.Paciente.Id,
                            new PersonaDTO(
                                temp.Paciente.Persona.Id,
                                temp.Paciente.Persona.Dni,
                                temp.Paciente.Persona.Apellidos,
                                temp.Paciente.Persona.Nombres,
                                temp.Paciente.Persona.FechaNacimiento,
                                temp.Paciente.Persona.Sexo,
                                temp.Paciente.Persona.CorreoElectronico,
                                temp.Paciente.Persona.Telefono)),
                        temp.FechaHora,
                        new CoberturaDTO(
                            temp.Cobertura.Id,
                            new ObraSocialDTO(
                                temp.Cobertura.ObraSocial.Id,
                                temp.Cobertura.ObraSocial.Nombre,
                                temp.Cobertura.ObraSocial.Estado),
                            temp.Cobertura.Descripcion,
                            temp.Cobertura.Estado),
                        new TurnoEstadoDTO(
                            temp.TurnoEstado.Id,
                            temp.TurnoEstado.Descripcion)));
                }
                return res;
            }
        }

        public static List<TurnoDTO> Buscar(EmpleadoDTO med)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<TurnoDTO> res = new List<TurnoDTO>();
                var query = db.Turno
                    .Where(el => el.Medico.EmpleadoId == med.Id)
                    .OrderBy(el => el.FechaHora);
                foreach (Turno temp in query)
                {
                    res.Add(new TurnoDTO(
                        temp.Id,
                        new MedicoDTO(
                            temp.Medico.Id,
                            new EmpleadoDTO(
                                temp.Medico.Empleado.Id,
                                new PersonaDTO(
                                    temp.Medico.Empleado.Persona.Id,
                                    temp.Medico.Empleado.Persona.Dni,
                                    temp.Medico.Empleado.Persona.Apellidos,
                                    temp.Medico.Empleado.Persona.Nombres,
                                    temp.Medico.Empleado.Persona.FechaNacimiento,
                                    temp.Medico.Empleado.Persona.Sexo,
                                    temp.Medico.Empleado.Persona.CorreoElectronico,
                                    temp.Medico.Empleado.Persona.Telefono),
                                temp.Medico.Empleado.Cuil,
                                temp.Medico.Empleado.Usuario,
                                temp.Medico.Empleado.Contraseña,
                                temp.Medico.Empleado.FechaIngreso,
                                new TipoUsuarioDTO(
                                    temp.Medico.Empleado.TipoUsuario.Id,
                                    temp.Medico.Empleado.TipoUsuario.Descripcion),
                                temp.Medico.Empleado.Activo),
                            temp.Medico.Matricula,
                            new EspecialidadDTO(
                                temp.Medico.Especialidad.Id,
                                temp.Medico.Especialidad.Descripcion)),
                        new PacienteDTO(
                            temp.Paciente.Id,
                            new PersonaDTO(
                                temp.Paciente.Persona.Id,
                                temp.Paciente.Persona.Dni,
                                temp.Paciente.Persona.Apellidos,
                                temp.Paciente.Persona.Nombres,
                                temp.Paciente.Persona.FechaNacimiento,
                                temp.Paciente.Persona.Sexo,
                                temp.Paciente.Persona.CorreoElectronico,
                                temp.Paciente.Persona.Telefono)),
                        temp.FechaHora,
                        new CoberturaDTO(
                            temp.Cobertura.Id,
                            new ObraSocialDTO(
                                temp.Cobertura.ObraSocial.Id,
                                temp.Cobertura.ObraSocial.Nombre,
                                temp.Cobertura.ObraSocial.Estado),
                            temp.Cobertura.Descripcion,
                            temp.Cobertura.Estado),
                        new TurnoEstadoDTO(
                            temp.TurnoEstado.Id,
                            temp.TurnoEstado.Descripcion)));
                }
                return res;
            }
        }

        public static List<TurnoDTO> Buscar(EmpleadoDTO med, DateTime desde, DateTime hasta)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<TurnoDTO> res = new List<TurnoDTO>();
                var query = db.Turno
                    .Where(el => el.Medico.EmpleadoId == med.Id &&
                        DateTime.Compare(el.FechaHora, desde) >= 0 &&
                        DateTime.Compare(el.FechaHora, hasta) <= 0)
                    .OrderBy(el => el.FechaHora);
                foreach (Turno temp in query)
                {
                    res.Add(new TurnoDTO(
                        temp.Id,
                        new MedicoDTO(
                            temp.Medico.Id,
                            new EmpleadoDTO(
                                temp.Medico.Empleado.Id,
                                new PersonaDTO(
                                    temp.Medico.Empleado.Persona.Id,
                                    temp.Medico.Empleado.Persona.Dni,
                                    temp.Medico.Empleado.Persona.Apellidos,
                                    temp.Medico.Empleado.Persona.Nombres,
                                    temp.Medico.Empleado.Persona.FechaNacimiento,
                                    temp.Medico.Empleado.Persona.Sexo,
                                    temp.Medico.Empleado.Persona.CorreoElectronico,
                                    temp.Medico.Empleado.Persona.Telefono),
                                temp.Medico.Empleado.Cuil,
                                temp.Medico.Empleado.Usuario,
                                temp.Medico.Empleado.Contraseña,
                                temp.Medico.Empleado.FechaIngreso,
                                new TipoUsuarioDTO(
                                    temp.Medico.Empleado.TipoUsuario.Id,
                                    temp.Medico.Empleado.TipoUsuario.Descripcion),
                                temp.Medico.Empleado.Activo),
                            temp.Medico.Matricula,
                            new EspecialidadDTO(
                                temp.Medico.Especialidad.Id,
                                temp.Medico.Especialidad.Descripcion)),
                        new PacienteDTO(
                            temp.Paciente.Id,
                            new PersonaDTO(
                                temp.Paciente.Persona.Id,
                                temp.Paciente.Persona.Dni,
                                temp.Paciente.Persona.Apellidos,
                                temp.Paciente.Persona.Nombres,
                                temp.Paciente.Persona.FechaNacimiento,
                                temp.Paciente.Persona.Sexo,
                                temp.Paciente.Persona.CorreoElectronico,
                                temp.Paciente.Persona.Telefono)),
                        temp.FechaHora,
                        new CoberturaDTO(
                            temp.Cobertura.Id,
                            new ObraSocialDTO(
                                temp.Cobertura.ObraSocial.Id,
                                temp.Cobertura.ObraSocial.Nombre,
                                temp.Cobertura.ObraSocial.Estado),
                            temp.Cobertura.Descripcion,
                            temp.Cobertura.Estado),
                        new TurnoEstadoDTO(
                            temp.TurnoEstado.Id,
                            temp.TurnoEstado.Descripcion)));
                }
                return res;
            }
        }

        public static List<TurnoDTO> Buscar(MedicoDTO med, DateTime dia)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<TurnoDTO> res = new List<TurnoDTO>();
                var query = db.Turno
                    .Where(el => el.MedicoId == med.Id &&
                        el.FechaHora.Year == dia.Year &&
                        el.FechaHora.Month == dia.Month &&
                        el.FechaHora.Day == dia.Day)
                    .OrderBy(el => el.FechaHora);
                foreach (Turno temp in query)
                {
                    res.Add(new TurnoDTO(
                        temp.Id,
                        new MedicoDTO(
                            temp.Medico.Id,
                            new EmpleadoDTO(
                                temp.Medico.Empleado.Id,
                                new PersonaDTO(
                                    temp.Medico.Empleado.Persona.Id,
                                    temp.Medico.Empleado.Persona.Dni,
                                    temp.Medico.Empleado.Persona.Apellidos,
                                    temp.Medico.Empleado.Persona.Nombres,
                                    temp.Medico.Empleado.Persona.FechaNacimiento,
                                    temp.Medico.Empleado.Persona.Sexo,
                                    temp.Medico.Empleado.Persona.CorreoElectronico,
                                    temp.Medico.Empleado.Persona.Telefono),
                                temp.Medico.Empleado.Cuil,
                                temp.Medico.Empleado.Usuario,
                                temp.Medico.Empleado.Contraseña,
                                temp.Medico.Empleado.FechaIngreso,
                                new TipoUsuarioDTO(
                                    temp.Medico.Empleado.TipoUsuario.Id,
                                    temp.Medico.Empleado.TipoUsuario.Descripcion),
                                temp.Medico.Empleado.Activo),
                            temp.Medico.Matricula,
                            new EspecialidadDTO(
                                temp.Medico.Especialidad.Id,
                                temp.Medico.Especialidad.Descripcion)),
                        new PacienteDTO(
                            temp.Paciente.Id,
                            new PersonaDTO(
                                temp.Paciente.Persona.Id,
                                temp.Paciente.Persona.Dni,
                                temp.Paciente.Persona.Apellidos,
                                temp.Paciente.Persona.Nombres,
                                temp.Paciente.Persona.FechaNacimiento,
                                temp.Paciente.Persona.Sexo,
                                temp.Paciente.Persona.CorreoElectronico,
                                temp.Paciente.Persona.Telefono)),
                        temp.FechaHora,
                        new CoberturaDTO(
                            temp.Cobertura.Id,
                            new ObraSocialDTO(
                                temp.Cobertura.ObraSocial.Id,
                                temp.Cobertura.ObraSocial.Nombre,
                                temp.Cobertura.ObraSocial.Estado),
                            temp.Cobertura.Descripcion,
                            temp.Cobertura.Estado),
                        new TurnoEstadoDTO(
                            temp.TurnoEstado.Id,
                            temp.TurnoEstado.Descripcion)));
                }
                return res;
            }
        }

        public static List<TurnoDTO> BuscarApeNom(string apenom)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<TurnoDTO> res = new List<TurnoDTO>();
                var query = db.Turno
                    .Where(el => el.Medico.Empleado.Persona.Apellidos.Contains(apenom) ||
                        el.Medico.Empleado.Persona.Nombres.Contains(apenom) ||
                        el.Paciente.Persona.Apellidos.Contains(apenom) ||
                        el.Paciente.Persona.Nombres.Contains(apenom))
                    .OrderBy(el => el.FechaHora);
                foreach (Turno temp in query)
                {
                    res.Add(new TurnoDTO(
                        temp.Id,
                        new MedicoDTO(
                            temp.Medico.Id,
                            new EmpleadoDTO(
                                temp.Medico.Empleado.Id,
                                new PersonaDTO(
                                    temp.Medico.Empleado.Persona.Id,
                                    temp.Medico.Empleado.Persona.Dni,
                                    temp.Medico.Empleado.Persona.Apellidos,
                                    temp.Medico.Empleado.Persona.Nombres,
                                    temp.Medico.Empleado.Persona.FechaNacimiento,
                                    temp.Medico.Empleado.Persona.Sexo,
                                    temp.Medico.Empleado.Persona.CorreoElectronico,
                                    temp.Medico.Empleado.Persona.Telefono),
                                temp.Medico.Empleado.Cuil,
                                temp.Medico.Empleado.Usuario,
                                temp.Medico.Empleado.Contraseña,
                                temp.Medico.Empleado.FechaIngreso,
                                new TipoUsuarioDTO(
                                    temp.Medico.Empleado.TipoUsuario.Id,
                                    temp.Medico.Empleado.TipoUsuario.Descripcion),
                                temp.Medico.Empleado.Activo),
                            temp.Medico.Matricula,
                            new EspecialidadDTO(
                                temp.Medico.Especialidad.Id,
                                temp.Medico.Especialidad.Descripcion)),
                        new PacienteDTO(
                            temp.Paciente.Id,
                            new PersonaDTO(
                                temp.Paciente.Persona.Id,
                                temp.Paciente.Persona.Dni,
                                temp.Paciente.Persona.Apellidos,
                                temp.Paciente.Persona.Nombres,
                                temp.Paciente.Persona.FechaNacimiento,
                                temp.Paciente.Persona.Sexo,
                                temp.Paciente.Persona.CorreoElectronico,
                                temp.Paciente.Persona.Telefono)),
                        temp.FechaHora,
                        new CoberturaDTO(
                            temp.Cobertura.Id,
                            new ObraSocialDTO(
                                temp.Cobertura.ObraSocial.Id,
                                temp.Cobertura.ObraSocial.Nombre,
                                temp.Cobertura.ObraSocial.Estado),
                            temp.Cobertura.Descripcion,
                            temp.Cobertura.Estado),
                        new TurnoEstadoDTO(
                            temp.TurnoEstado.Id,
                            temp.TurnoEstado.Descripcion)));
                }
                return res;
            }
        }

        public static List<TurnoDTO> BuscarApeNom(string apenom, DateTime desde, DateTime hasta)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<TurnoDTO> res = new List<TurnoDTO>();
                var query = db.Turno
                    .Where(el => (el.Medico.Empleado.Persona.Apellidos.Contains(apenom) ||
                        el.Medico.Empleado.Persona.Nombres.Contains(apenom) ||
                        el.Paciente.Persona.Apellidos.Contains(apenom) ||
                        el.Paciente.Persona.Nombres.Contains(apenom)) &&
                        DateTime.Compare(el.FechaHora, desde) >= 0 &&
                        DateTime.Compare(el.FechaHora, hasta) <= 0)
                    .OrderBy(el => el.FechaHora);
                foreach (Turno temp in query)
                {
                    res.Add(new TurnoDTO(
                        temp.Id,
                        new MedicoDTO(
                            temp.Medico.Id,
                            new EmpleadoDTO(
                                temp.Medico.Empleado.Id,
                                new PersonaDTO(
                                    temp.Medico.Empleado.Persona.Id,
                                    temp.Medico.Empleado.Persona.Dni,
                                    temp.Medico.Empleado.Persona.Apellidos,
                                    temp.Medico.Empleado.Persona.Nombres,
                                    temp.Medico.Empleado.Persona.FechaNacimiento,
                                    temp.Medico.Empleado.Persona.Sexo,
                                    temp.Medico.Empleado.Persona.CorreoElectronico,
                                    temp.Medico.Empleado.Persona.Telefono),
                                temp.Medico.Empleado.Cuil,
                                temp.Medico.Empleado.Usuario,
                                temp.Medico.Empleado.Contraseña,
                                temp.Medico.Empleado.FechaIngreso,
                                new TipoUsuarioDTO(
                                    temp.Medico.Empleado.TipoUsuario.Id,
                                    temp.Medico.Empleado.TipoUsuario.Descripcion),
                                temp.Medico.Empleado.Activo),
                            temp.Medico.Matricula,
                            new EspecialidadDTO(
                                temp.Medico.Especialidad.Id,
                                temp.Medico.Especialidad.Descripcion)),
                        new PacienteDTO(
                            temp.Paciente.Id,
                            new PersonaDTO(
                                temp.Paciente.Persona.Id,
                                temp.Paciente.Persona.Dni,
                                temp.Paciente.Persona.Apellidos,
                                temp.Paciente.Persona.Nombres,
                                temp.Paciente.Persona.FechaNacimiento,
                                temp.Paciente.Persona.Sexo,
                                temp.Paciente.Persona.CorreoElectronico,
                                temp.Paciente.Persona.Telefono)),
                        temp.FechaHora,
                        new CoberturaDTO(
                            temp.Cobertura.Id,
                            new ObraSocialDTO(
                                temp.Cobertura.ObraSocial.Id,
                                temp.Cobertura.ObraSocial.Nombre,
                                temp.Cobertura.ObraSocial.Estado),
                            temp.Cobertura.Descripcion,
                            temp.Cobertura.Estado),
                        new TurnoEstadoDTO(
                            temp.TurnoEstado.Id,
                            temp.TurnoEstado.Descripcion)));
                }
                return res;
            }
        }

        public static List<TurnoDTO> BuscarApeNom(EmpleadoDTO med, string apenom)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<TurnoDTO> res = new List<TurnoDTO>();
                var query = db.Turno
                    .Where(el => el.Medico.EmpleadoId == med.Id &&
                        (el.Paciente.Persona.Apellidos.Contains(apenom) ||
                        el.Paciente.Persona.Nombres.Contains(apenom)))
                    .OrderBy(el => el.FechaHora);
                foreach (Turno temp in query)
                {
                    res.Add(new TurnoDTO(
                        temp.Id,
                        new MedicoDTO(
                            temp.Medico.Id,
                            new EmpleadoDTO(
                                temp.Medico.Empleado.Id,
                                new PersonaDTO(
                                    temp.Medico.Empleado.Persona.Id,
                                    temp.Medico.Empleado.Persona.Dni,
                                    temp.Medico.Empleado.Persona.Apellidos,
                                    temp.Medico.Empleado.Persona.Nombres,
                                    temp.Medico.Empleado.Persona.FechaNacimiento,
                                    temp.Medico.Empleado.Persona.Sexo,
                                    temp.Medico.Empleado.Persona.CorreoElectronico,
                                    temp.Medico.Empleado.Persona.Telefono),
                                temp.Medico.Empleado.Cuil,
                                temp.Medico.Empleado.Usuario,
                                temp.Medico.Empleado.Contraseña,
                                temp.Medico.Empleado.FechaIngreso,
                                new TipoUsuarioDTO(
                                    temp.Medico.Empleado.TipoUsuario.Id,
                                    temp.Medico.Empleado.TipoUsuario.Descripcion),
                                temp.Medico.Empleado.Activo),
                            temp.Medico.Matricula,
                            new EspecialidadDTO(
                                temp.Medico.Especialidad.Id,
                                temp.Medico.Especialidad.Descripcion)),
                        new PacienteDTO(
                            temp.Paciente.Id,
                            new PersonaDTO(
                                temp.Paciente.Persona.Id,
                                temp.Paciente.Persona.Dni,
                                temp.Paciente.Persona.Apellidos,
                                temp.Paciente.Persona.Nombres,
                                temp.Paciente.Persona.FechaNacimiento,
                                temp.Paciente.Persona.Sexo,
                                temp.Paciente.Persona.CorreoElectronico,
                                temp.Paciente.Persona.Telefono)),
                        temp.FechaHora,
                        new CoberturaDTO(
                            temp.Cobertura.Id,
                            new ObraSocialDTO(
                                temp.Cobertura.ObraSocial.Id,
                                temp.Cobertura.ObraSocial.Nombre,
                                temp.Cobertura.ObraSocial.Estado),
                            temp.Cobertura.Descripcion,
                            temp.Cobertura.Estado),
                        new TurnoEstadoDTO(
                            temp.TurnoEstado.Id,
                            temp.TurnoEstado.Descripcion)));
                }
                return res;
            }
        }

        public static List<TurnoDTO> BuscarApeNom(EmpleadoDTO med, string apenom, DateTime desde, DateTime hasta)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<TurnoDTO> res = new List<TurnoDTO>();
                var query = db.Turno
                    .Where(el => (el.Medico.EmpleadoId == med.Id &&
                        (el.Paciente.Persona.Apellidos.Contains(apenom) ||
                        el.Paciente.Persona.Nombres.Contains(apenom))) &&
                        DateTime.Compare(el.FechaHora, desde) >= 0 &&
                        DateTime.Compare(el.FechaHora, hasta) <= 0)
                    .OrderBy(el => el.FechaHora);
                foreach (Turno temp in query)
                {
                    res.Add(new TurnoDTO(
                        temp.Id,
                        new MedicoDTO(
                            temp.Medico.Id,
                            new EmpleadoDTO(
                                temp.Medico.Empleado.Id,
                                new PersonaDTO(
                                    temp.Medico.Empleado.Persona.Id,
                                    temp.Medico.Empleado.Persona.Dni,
                                    temp.Medico.Empleado.Persona.Apellidos,
                                    temp.Medico.Empleado.Persona.Nombres,
                                    temp.Medico.Empleado.Persona.FechaNacimiento,
                                    temp.Medico.Empleado.Persona.Sexo,
                                    temp.Medico.Empleado.Persona.CorreoElectronico,
                                    temp.Medico.Empleado.Persona.Telefono),
                                temp.Medico.Empleado.Cuil,
                                temp.Medico.Empleado.Usuario,
                                temp.Medico.Empleado.Contraseña,
                                temp.Medico.Empleado.FechaIngreso,
                                new TipoUsuarioDTO(
                                    temp.Medico.Empleado.TipoUsuario.Id,
                                    temp.Medico.Empleado.TipoUsuario.Descripcion),
                                temp.Medico.Empleado.Activo),
                            temp.Medico.Matricula,
                            new EspecialidadDTO(
                                temp.Medico.Especialidad.Id,
                                temp.Medico.Especialidad.Descripcion)),
                        new PacienteDTO(
                            temp.Paciente.Id,
                            new PersonaDTO(
                                temp.Paciente.Persona.Id,
                                temp.Paciente.Persona.Dni,
                                temp.Paciente.Persona.Apellidos,
                                temp.Paciente.Persona.Nombres,
                                temp.Paciente.Persona.FechaNacimiento,
                                temp.Paciente.Persona.Sexo,
                                temp.Paciente.Persona.CorreoElectronico,
                                temp.Paciente.Persona.Telefono)),
                        temp.FechaHora,
                        new CoberturaDTO(
                            temp.Cobertura.Id,
                            new ObraSocialDTO(
                                temp.Cobertura.ObraSocial.Id,
                                temp.Cobertura.ObraSocial.Nombre,
                                temp.Cobertura.ObraSocial.Estado),
                            temp.Cobertura.Descripcion,
                            temp.Cobertura.Estado),
                        new TurnoEstadoDTO(
                            temp.TurnoEstado.Id,
                            temp.TurnoEstado.Descripcion)));
                }
                return res;
            }
        }

        public static List<TurnoDTO> BuscarDni(string dni)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<TurnoDTO> res = new List<TurnoDTO>();
                var query = db.Turno
                    .Where(el => el.Medico.Empleado.Persona.Dni.Contains(dni) ||
                        el.Paciente.Persona.Dni.Contains(dni))
                    .OrderBy(el => el.FechaHora);
                foreach (Turno temp in query)
                {
                    res.Add(new TurnoDTO(
                        temp.Id,
                        new MedicoDTO(
                            temp.Medico.Id,
                            new EmpleadoDTO(
                                temp.Medico.Empleado.Id,
                                new PersonaDTO(
                                    temp.Medico.Empleado.Persona.Id,
                                    temp.Medico.Empleado.Persona.Dni,
                                    temp.Medico.Empleado.Persona.Apellidos,
                                    temp.Medico.Empleado.Persona.Nombres,
                                    temp.Medico.Empleado.Persona.FechaNacimiento,
                                    temp.Medico.Empleado.Persona.Sexo,
                                    temp.Medico.Empleado.Persona.CorreoElectronico,
                                    temp.Medico.Empleado.Persona.Telefono),
                                temp.Medico.Empleado.Cuil,
                                temp.Medico.Empleado.Usuario,
                                temp.Medico.Empleado.Contraseña,
                                temp.Medico.Empleado.FechaIngreso,
                                new TipoUsuarioDTO(
                                    temp.Medico.Empleado.TipoUsuario.Id,
                                    temp.Medico.Empleado.TipoUsuario.Descripcion),
                                temp.Medico.Empleado.Activo),
                            temp.Medico.Matricula,
                            new EspecialidadDTO(
                                temp.Medico.Especialidad.Id,
                                temp.Medico.Especialidad.Descripcion)),
                        new PacienteDTO(
                            temp.Paciente.Id,
                            new PersonaDTO(
                                temp.Paciente.Persona.Id,
                                temp.Paciente.Persona.Dni,
                                temp.Paciente.Persona.Apellidos,
                                temp.Paciente.Persona.Nombres,
                                temp.Paciente.Persona.FechaNacimiento,
                                temp.Paciente.Persona.Sexo,
                                temp.Paciente.Persona.CorreoElectronico,
                                temp.Paciente.Persona.Telefono)),
                        temp.FechaHora,
                        new CoberturaDTO(
                            temp.Cobertura.Id,
                            new ObraSocialDTO(
                                temp.Cobertura.ObraSocial.Id,
                                temp.Cobertura.ObraSocial.Nombre,
                                temp.Cobertura.ObraSocial.Estado),
                            temp.Cobertura.Descripcion,
                            temp.Cobertura.Estado),
                        new TurnoEstadoDTO(
                            temp.TurnoEstado.Id,
                            temp.TurnoEstado.Descripcion)));
                }
                return res;
            }
        }

        public static List<TurnoDTO> BuscarDni(string dni, DateTime desde, DateTime hasta)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<TurnoDTO> res = new List<TurnoDTO>();
                var query = db.Turno
                    .Where(el => (el.Medico.Empleado.Persona.Dni.Contains(dni) ||
                        el.Paciente.Persona.Dni.Contains(dni)) &&
                        DateTime.Compare(el.FechaHora, desde) >= 0 &&
                        DateTime.Compare(el.FechaHora, hasta) <= 0)
                    .OrderBy(el => el.FechaHora);
                foreach (Turno temp in query)
                {
                    res.Add(new TurnoDTO(
                        temp.Id,
                        new MedicoDTO(
                            temp.Medico.Id,
                            new EmpleadoDTO(
                                temp.Medico.Empleado.Id,
                                new PersonaDTO(
                                    temp.Medico.Empleado.Persona.Id,
                                    temp.Medico.Empleado.Persona.Dni,
                                    temp.Medico.Empleado.Persona.Apellidos,
                                    temp.Medico.Empleado.Persona.Nombres,
                                    temp.Medico.Empleado.Persona.FechaNacimiento,
                                    temp.Medico.Empleado.Persona.Sexo,
                                    temp.Medico.Empleado.Persona.CorreoElectronico,
                                    temp.Medico.Empleado.Persona.Telefono),
                                temp.Medico.Empleado.Cuil,
                                temp.Medico.Empleado.Usuario,
                                temp.Medico.Empleado.Contraseña,
                                temp.Medico.Empleado.FechaIngreso,
                                new TipoUsuarioDTO(
                                    temp.Medico.Empleado.TipoUsuario.Id,
                                    temp.Medico.Empleado.TipoUsuario.Descripcion),
                                temp.Medico.Empleado.Activo),
                            temp.Medico.Matricula,
                            new EspecialidadDTO(
                                temp.Medico.Especialidad.Id,
                                temp.Medico.Especialidad.Descripcion)),
                        new PacienteDTO(
                            temp.Paciente.Id,
                            new PersonaDTO(
                                temp.Paciente.Persona.Id,
                                temp.Paciente.Persona.Dni,
                                temp.Paciente.Persona.Apellidos,
                                temp.Paciente.Persona.Nombres,
                                temp.Paciente.Persona.FechaNacimiento,
                                temp.Paciente.Persona.Sexo,
                                temp.Paciente.Persona.CorreoElectronico,
                                temp.Paciente.Persona.Telefono)),
                        temp.FechaHora,
                        new CoberturaDTO(
                            temp.Cobertura.Id,
                            new ObraSocialDTO(
                                temp.Cobertura.ObraSocial.Id,
                                temp.Cobertura.ObraSocial.Nombre,
                                temp.Cobertura.ObraSocial.Estado),
                            temp.Cobertura.Descripcion,
                            temp.Cobertura.Estado),
                        new TurnoEstadoDTO(
                            temp.TurnoEstado.Id,
                            temp.TurnoEstado.Descripcion)));
                }
                return res;
            }
        }

        public static List<TurnoDTO> BuscarDni(EmpleadoDTO med, string dni)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<TurnoDTO> res = new List<TurnoDTO>();
                var query = db.Turno
                    .Where(el => el.Medico.EmpleadoId == med.Id &&
                        el.Paciente.Persona.Dni.Contains(dni))
                    .OrderBy(el => el.FechaHora);
                foreach (Turno temp in query)
                {
                    res.Add(new TurnoDTO(
                        temp.Id,
                        new MedicoDTO(
                            temp.Medico.Id,
                            new EmpleadoDTO(
                                temp.Medico.Empleado.Id,
                                new PersonaDTO(
                                    temp.Medico.Empleado.Persona.Id,
                                    temp.Medico.Empleado.Persona.Dni,
                                    temp.Medico.Empleado.Persona.Apellidos,
                                    temp.Medico.Empleado.Persona.Nombres,
                                    temp.Medico.Empleado.Persona.FechaNacimiento,
                                    temp.Medico.Empleado.Persona.Sexo,
                                    temp.Medico.Empleado.Persona.CorreoElectronico,
                                    temp.Medico.Empleado.Persona.Telefono),
                                temp.Medico.Empleado.Cuil,
                                temp.Medico.Empleado.Usuario,
                                temp.Medico.Empleado.Contraseña,
                                temp.Medico.Empleado.FechaIngreso,
                                new TipoUsuarioDTO(
                                    temp.Medico.Empleado.TipoUsuario.Id,
                                    temp.Medico.Empleado.TipoUsuario.Descripcion),
                                temp.Medico.Empleado.Activo),
                            temp.Medico.Matricula,
                            new EspecialidadDTO(
                                temp.Medico.Especialidad.Id,
                                temp.Medico.Especialidad.Descripcion)),
                        new PacienteDTO(
                            temp.Paciente.Id,
                            new PersonaDTO(
                                temp.Paciente.Persona.Id,
                                temp.Paciente.Persona.Dni,
                                temp.Paciente.Persona.Apellidos,
                                temp.Paciente.Persona.Nombres,
                                temp.Paciente.Persona.FechaNacimiento,
                                temp.Paciente.Persona.Sexo,
                                temp.Paciente.Persona.CorreoElectronico,
                                temp.Paciente.Persona.Telefono)),
                        temp.FechaHora,
                        new CoberturaDTO(
                            temp.Cobertura.Id,
                            new ObraSocialDTO(
                                temp.Cobertura.ObraSocial.Id,
                                temp.Cobertura.ObraSocial.Nombre,
                                temp.Cobertura.ObraSocial.Estado),
                            temp.Cobertura.Descripcion,
                            temp.Cobertura.Estado),
                        new TurnoEstadoDTO(
                            temp.TurnoEstado.Id,
                            temp.TurnoEstado.Descripcion)));
                }
                return res;
            }
        }

        public static List<TurnoDTO> BuscarDni(EmpleadoDTO med, string dni, DateTime desde, DateTime hasta)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<TurnoDTO> res = new List<TurnoDTO>();
                var query = db.Turno
                    .Where(el => (el.Medico.EmpleadoId == med.Id &&
                        el.Paciente.Persona.Dni.Contains(dni)) &&
                        DateTime.Compare(el.FechaHora, desde) >= 0 &&
                        DateTime.Compare(el.FechaHora, hasta) <= 0)
                    .OrderBy(el => el.FechaHora);
                foreach (Turno temp in query)
                {
                    res.Add(new TurnoDTO(
                        temp.Id,
                        new MedicoDTO(
                            temp.Medico.Id,
                            new EmpleadoDTO(
                                temp.Medico.Empleado.Id,
                                new PersonaDTO(
                                    temp.Medico.Empleado.Persona.Id,
                                    temp.Medico.Empleado.Persona.Dni,
                                    temp.Medico.Empleado.Persona.Apellidos,
                                    temp.Medico.Empleado.Persona.Nombres,
                                    temp.Medico.Empleado.Persona.FechaNacimiento,
                                    temp.Medico.Empleado.Persona.Sexo,
                                    temp.Medico.Empleado.Persona.CorreoElectronico,
                                    temp.Medico.Empleado.Persona.Telefono),
                                temp.Medico.Empleado.Cuil,
                                temp.Medico.Empleado.Usuario,
                                temp.Medico.Empleado.Contraseña,
                                temp.Medico.Empleado.FechaIngreso,
                                new TipoUsuarioDTO(
                                    temp.Medico.Empleado.TipoUsuario.Id,
                                    temp.Medico.Empleado.TipoUsuario.Descripcion),
                                temp.Medico.Empleado.Activo),
                            temp.Medico.Matricula,
                            new EspecialidadDTO(
                                temp.Medico.Especialidad.Id,
                                temp.Medico.Especialidad.Descripcion)),
                        new PacienteDTO(
                            temp.Paciente.Id,
                            new PersonaDTO(
                                temp.Paciente.Persona.Id,
                                temp.Paciente.Persona.Dni,
                                temp.Paciente.Persona.Apellidos,
                                temp.Paciente.Persona.Nombres,
                                temp.Paciente.Persona.FechaNacimiento,
                                temp.Paciente.Persona.Sexo,
                                temp.Paciente.Persona.CorreoElectronico,
                                temp.Paciente.Persona.Telefono)),
                        temp.FechaHora,
                        new CoberturaDTO(
                            temp.Cobertura.Id,
                            new ObraSocialDTO(
                                temp.Cobertura.ObraSocial.Id,
                                temp.Cobertura.ObraSocial.Nombre,
                                temp.Cobertura.ObraSocial.Estado),
                            temp.Cobertura.Descripcion,
                            temp.Cobertura.Estado),
                        new TurnoEstadoDTO(
                            temp.TurnoEstado.Id,
                            temp.TurnoEstado.Descripcion)));
                }
                return res;
            }
        }

        public static bool Guardar(TurnoDTO turno)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                Turno nuevo = new Turno();
                nuevo.MedicoId = turno.Medico.Id;
                nuevo.PacienteId = turno.Paciente.Id;
                nuevo.FechaHora = turno.FechaHora;
                nuevo.CoberturaId = turno.Cobertura.Id;
                nuevo.EstadoId = turno.Estado.Id;
                try
                {
                    db.Turno.Add(nuevo);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool Editar(TurnoDTO turno)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                Turno modificado = db.Turno
                    .Where(el => el.Id == turno.Id)
                    .First();
                modificado.MedicoId = turno.Medico.Id;
                modificado.PacienteId = turno.Paciente.Id;
                modificado.FechaHora = turno.FechaHora;
                modificado.CoberturaId = turno.Cobertura.Id;
                modificado.EstadoId = turno.Estado.Id;
                try
                {
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
