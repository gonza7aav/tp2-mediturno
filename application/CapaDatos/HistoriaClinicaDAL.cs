using MediTurno.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MediTurno.CapaDatos
{
    public class HistoriaClinicaDAL
    {
        public static HistoriaClinicaDTO Buscar(int id)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                var query = db.HistoriaClinica
                    .Where(el => el.Id == id)
                    .First();
                return new HistoriaClinicaDTO(
                    query.Id,
                    new TurnoDTO(
                        query.Turno.Id,
                        new MedicoDTO(
                            query.Turno.Medico.Id,
                            new EmpleadoDTO(
                                query.Turno.Medico.Empleado.Id,
                                new PersonaDTO(
                                    query.Turno.Medico.Empleado.Persona.Id,
                                    query.Turno.Medico.Empleado.Persona.Dni,
                                    query.Turno.Medico.Empleado.Persona.Apellidos,
                                    query.Turno.Medico.Empleado.Persona.Nombres,
                                    query.Turno.Medico.Empleado.Persona.FechaNacimiento,
                                    query.Turno.Medico.Empleado.Persona.Sexo,
                                    query.Turno.Medico.Empleado.Persona.CorreoElectronico,
                                    query.Turno.Medico.Empleado.Persona.Telefono),
                                query.Turno.Medico.Empleado.Cuil,
                                query.Turno.Medico.Empleado.Usuario,
                                query.Turno.Medico.Empleado.Contraseña,
                                query.Turno.Medico.Empleado.FechaIngreso,
                                new TipoUsuarioDTO(
                                    query.Turno.Medico.Empleado.TipoUsuario.Id,
                                    query.Turno.Medico.Empleado.TipoUsuario.Descripcion),
                                query.Turno.Medico.Empleado.Activo),
                            query.Turno.Medico.Matricula,
                            new EspecialidadDTO(
                                query.Turno.Medico.Especialidad.Id,
                                query.Turno.Medico.Especialidad.Descripcion)),
                        new PacienteDTO(
                            query.Turno.Paciente.Id,
                            new PersonaDTO(
                                query.Turno.Paciente.Persona.Id,
                                query.Turno.Paciente.Persona.Dni,
                                query.Turno.Paciente.Persona.Apellidos,
                                query.Turno.Paciente.Persona.Nombres,
                                query.Turno.Paciente.Persona.FechaNacimiento,
                                query.Turno.Paciente.Persona.Sexo,
                                query.Turno.Paciente.Persona.CorreoElectronico,
                                query.Turno.Paciente.Persona.Telefono)),
                        query.Turno.FechaHora,
                        new CoberturaDTO(
                            query.Turno.Cobertura.Id,
                            new ObraSocialDTO(
                                query.Turno.Cobertura.ObraSocial.Id,
                                query.Turno.Cobertura.ObraSocial.Nombre,
                                query.Turno.Cobertura.ObraSocial.Estado),
                            query.Turno.Cobertura.Descripcion,
                            query.Turno.Cobertura.Estado),
                        new TurnoEstadoDTO(
                            query.Turno.TurnoEstado.Id,
                            query.Turno.TurnoEstado.Descripcion)),
                    query.Descripcion,
                    query.Archivo);
            }
        }

        public static HistoriaClinicaDTO Buscar(TurnoDTO tur)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                var query = db.HistoriaClinica
                    .Where(el => el.TurnoId == tur.Id)
                    .First();
                if (query == null)
                {
                    return null;
                }
                return new HistoriaClinicaDTO(
                    query.Id,
                    new TurnoDTO(
                        query.Turno.Id,
                        new MedicoDTO(
                            query.Turno.Medico.Id,
                            new EmpleadoDTO(
                                query.Turno.Medico.Empleado.Id,
                                new PersonaDTO(
                                    query.Turno.Medico.Empleado.Persona.Id,
                                    query.Turno.Medico.Empleado.Persona.Dni,
                                    query.Turno.Medico.Empleado.Persona.Apellidos,
                                    query.Turno.Medico.Empleado.Persona.Nombres,
                                    query.Turno.Medico.Empleado.Persona.FechaNacimiento,
                                    query.Turno.Medico.Empleado.Persona.Sexo,
                                    query.Turno.Medico.Empleado.Persona.CorreoElectronico,
                                    query.Turno.Medico.Empleado.Persona.Telefono),
                                query.Turno.Medico.Empleado.Cuil,
                                query.Turno.Medico.Empleado.Usuario,
                                query.Turno.Medico.Empleado.Contraseña,
                                query.Turno.Medico.Empleado.FechaIngreso,
                                new TipoUsuarioDTO(
                                    query.Turno.Medico.Empleado.TipoUsuario.Id,
                                    query.Turno.Medico.Empleado.TipoUsuario.Descripcion),
                                query.Turno.Medico.Empleado.Activo),
                            query.Turno.Medico.Matricula,
                            new EspecialidadDTO(
                                query.Turno.Medico.Especialidad.Id,
                                query.Turno.Medico.Especialidad.Descripcion)),
                        new PacienteDTO(
                            query.Turno.Paciente.Id,
                            new PersonaDTO(
                                query.Turno.Paciente.Persona.Id,
                                query.Turno.Paciente.Persona.Dni,
                                query.Turno.Paciente.Persona.Apellidos,
                                query.Turno.Paciente.Persona.Nombres,
                                query.Turno.Paciente.Persona.FechaNacimiento,
                                query.Turno.Paciente.Persona.Sexo,
                                query.Turno.Paciente.Persona.CorreoElectronico,
                                query.Turno.Paciente.Persona.Telefono)),
                        query.Turno.FechaHora,
                        new CoberturaDTO(
                            query.Turno.Cobertura.Id,
                            new ObraSocialDTO(
                                query.Turno.Cobertura.ObraSocial.Id,
                                query.Turno.Cobertura.ObraSocial.Nombre,
                                query.Turno.Cobertura.ObraSocial.Estado),
                            query.Turno.Cobertura.Descripcion,
                            query.Turno.Cobertura.Estado),
                        new TurnoEstadoDTO(
                            query.Turno.TurnoEstado.Id,
                            query.Turno.TurnoEstado.Descripcion)),
                    query.Descripcion,
                    query.Archivo);
            }
        }

        public static List<HistoriaClinicaDTO> Buscar(PacienteDTO pac)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<HistoriaClinicaDTO> res = new List<HistoriaClinicaDTO>();
                var query = db.HistoriaClinica
                    .Where(el => el.Turno.PacienteId == pac.Id)
                    .OrderBy(el => el.Turno.FechaHora);
                foreach (HistoriaClinica temp in query)
                {
                    res.Add(new HistoriaClinicaDTO(
                        temp.Id,
                        new TurnoDTO(
                            temp.Turno.Id,
                            new MedicoDTO(
                                temp.Turno.Medico.Id,
                                new EmpleadoDTO(
                                    temp.Turno.Medico.Empleado.Id,
                                    new PersonaDTO(
                                        temp.Turno.Medico.Empleado.Persona.Id,
                                        temp.Turno.Medico.Empleado.Persona.Dni,
                                        temp.Turno.Medico.Empleado.Persona.Apellidos,
                                        temp.Turno.Medico.Empleado.Persona.Nombres,
                                        temp.Turno.Medico.Empleado.Persona.FechaNacimiento,
                                        temp.Turno.Medico.Empleado.Persona.Sexo,
                                        temp.Turno.Medico.Empleado.Persona.CorreoElectronico,
                                        temp.Turno.Medico.Empleado.Persona.Telefono),
                                    temp.Turno.Medico.Empleado.Cuil,
                                    temp.Turno.Medico.Empleado.Usuario,
                                    temp.Turno.Medico.Empleado.Contraseña,
                                    temp.Turno.Medico.Empleado.FechaIngreso,
                                    new TipoUsuarioDTO(
                                        temp.Turno.Medico.Empleado.TipoUsuario.Id,
                                        temp.Turno.Medico.Empleado.TipoUsuario.Descripcion),
                                    temp.Turno.Medico.Empleado.Activo),
                                temp.Turno.Medico.Matricula,
                                new EspecialidadDTO(
                                    temp.Turno.Medico.Especialidad.Id,
                                    temp.Turno.Medico.Especialidad.Descripcion)),
                            new PacienteDTO(
                                temp.Turno.Paciente.Id,
                                new PersonaDTO(
                                    temp.Turno.Paciente.Persona.Id,
                                    temp.Turno.Paciente.Persona.Dni,
                                    temp.Turno.Paciente.Persona.Apellidos,
                                    temp.Turno.Paciente.Persona.Nombres,
                                    temp.Turno.Paciente.Persona.FechaNacimiento,
                                    temp.Turno.Paciente.Persona.Sexo,
                                    temp.Turno.Paciente.Persona.CorreoElectronico,
                                    temp.Turno.Paciente.Persona.Telefono)),
                            temp.Turno.FechaHora,
                            new CoberturaDTO(
                                temp.Turno.Cobertura.Id,
                                new ObraSocialDTO(
                                    temp.Turno.Cobertura.ObraSocial.Id,
                                    temp.Turno.Cobertura.ObraSocial.Nombre,
                                    temp.Turno.Cobertura.ObraSocial.Estado),
                                temp.Turno.Cobertura.Descripcion,
                                temp.Turno.Cobertura.Estado),
                            new TurnoEstadoDTO(
                                temp.Turno.TurnoEstado.Id,
                                temp.Turno.TurnoEstado.Descripcion)),
                        temp.Descripcion,
                        temp.Archivo));
                }
                return res;
            }
        }

        public static List<HistoriaClinicaDTO> Buscar(EmpleadoDTO emp, PacienteDTO pac)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<HistoriaClinicaDTO> res = new List<HistoriaClinicaDTO>();
                var query = db.HistoriaClinica
                    .Where(el => el.Turno.PacienteId == pac.Id && el.Turno.Medico.EmpleadoId == emp.Id)
                    .OrderBy(el => el.Turno.FechaHora);
                foreach (HistoriaClinica temp in query)
                {
                    res.Add(new HistoriaClinicaDTO(
                        temp.Id,
                        new TurnoDTO(
                            temp.Turno.Id,
                            new MedicoDTO(
                                temp.Turno.Medico.Id,
                                new EmpleadoDTO(
                                    temp.Turno.Medico.Empleado.Id,
                                    new PersonaDTO(
                                        temp.Turno.Medico.Empleado.Persona.Id,
                                        temp.Turno.Medico.Empleado.Persona.Dni,
                                        temp.Turno.Medico.Empleado.Persona.Apellidos,
                                        temp.Turno.Medico.Empleado.Persona.Nombres,
                                        temp.Turno.Medico.Empleado.Persona.FechaNacimiento,
                                        temp.Turno.Medico.Empleado.Persona.Sexo,
                                        temp.Turno.Medico.Empleado.Persona.CorreoElectronico,
                                        temp.Turno.Medico.Empleado.Persona.Telefono),
                                    temp.Turno.Medico.Empleado.Cuil,
                                    temp.Turno.Medico.Empleado.Usuario,
                                    temp.Turno.Medico.Empleado.Contraseña,
                                    temp.Turno.Medico.Empleado.FechaIngreso,
                                    new TipoUsuarioDTO(
                                        temp.Turno.Medico.Empleado.TipoUsuario.Id,
                                        temp.Turno.Medico.Empleado.TipoUsuario.Descripcion),
                                    temp.Turno.Medico.Empleado.Activo),
                                temp.Turno.Medico.Matricula,
                                new EspecialidadDTO(
                                    temp.Turno.Medico.Especialidad.Id,
                                    temp.Turno.Medico.Especialidad.Descripcion)),
                            new PacienteDTO(
                                temp.Turno.Paciente.Id,
                                new PersonaDTO(
                                    temp.Turno.Paciente.Persona.Id,
                                    temp.Turno.Paciente.Persona.Dni,
                                    temp.Turno.Paciente.Persona.Apellidos,
                                    temp.Turno.Paciente.Persona.Nombres,
                                    temp.Turno.Paciente.Persona.FechaNacimiento,
                                    temp.Turno.Paciente.Persona.Sexo,
                                    temp.Turno.Paciente.Persona.CorreoElectronico,
                                    temp.Turno.Paciente.Persona.Telefono)),
                            temp.Turno.FechaHora,
                            new CoberturaDTO(
                                temp.Turno.Cobertura.Id,
                                new ObraSocialDTO(
                                    temp.Turno.Cobertura.ObraSocial.Id,
                                    temp.Turno.Cobertura.ObraSocial.Nombre,
                                    temp.Turno.Cobertura.ObraSocial.Estado),
                                temp.Turno.Cobertura.Descripcion,
                                temp.Turno.Cobertura.Estado),
                            new TurnoEstadoDTO(
                                temp.Turno.TurnoEstado.Id,
                                temp.Turno.TurnoEstado.Descripcion)),
                        temp.Descripcion,
                        temp.Archivo));
                }
                return res;
            }
        }

        public static bool Guardar(HistoriaClinicaDTO hc)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                HistoriaClinica nuevo = new HistoriaClinica();
                nuevo.TurnoId = hc.Turno.Id;
                nuevo.Descripcion = hc.Descripcion;
                nuevo.Archivo = hc.Archivo;
                try
                {
                    db.HistoriaClinica.Add(nuevo);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool Editar(HistoriaClinicaDTO hc)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                HistoriaClinica modificado = db.HistoriaClinica
                    .Where(el => el.Id == hc.Id)
                    .First();
                modificado.Descripcion = hc.Descripcion;
                modificado.Archivo = hc.Archivo;
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
