using MediTurno.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MediTurno.CapaDatos
{
    public class PacienteDAL
    {
        public static List<PacienteDTO> Buscar()
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<PacienteDTO> res = new List<PacienteDTO>();
                var query = db.Paciente
                    .OrderBy(el => el.Persona.Apellidos)
                    .ThenBy(el => el.Persona.Nombres);
                foreach (Paciente temp in query)
                {
                    res.Add(new PacienteDTO(
                        temp.Id,
                        new PersonaDTO(
                            temp.Persona.Id,
                            temp.Persona.Dni,
                            temp.Persona.Apellidos,
                            temp.Persona.Nombres,
                            temp.Persona.FechaNacimiento,
                            temp.Persona.Sexo,
                            temp.Persona.CorreoElectronico,
                            temp.Persona.Telefono)));
                }
                return res;
            }
        }

        public static PacienteDTO Buscar(int id)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<PacienteDTO> res = new List<PacienteDTO>();
                var query = db.Paciente
                    .Where(el => el.Id == id)
                    .First();
                return new PacienteDTO(
                    query.Id,
                    new PersonaDTO(
                        query.Persona.Id,
                        query.Persona.Dni,
                        query.Persona.Apellidos,
                        query.Persona.Nombres,
                        query.Persona.FechaNacimiento,
                        query.Persona.Sexo,
                        query.Persona.CorreoElectronico,
                        query.Persona.Telefono));
            }
        }

        public static List<PacienteDTO> Buscar(EmpleadoDTO med)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<PacienteDTO> res = new List<PacienteDTO>();
                // Busco los pacientes de ese medico
                var subquery = db.Turno
                    .Where(el => el.Medico.EmpleadoId == med.Id)
                    .Select(el => el.PacienteId)
                    .ToList();
                var query = db.Paciente
                    .Where(el => subquery.Contains(el.Id))
                    .OrderBy(el => el.Persona.Apellidos)
                    .ThenBy(el => el.Persona.Nombres);
                foreach (Paciente temp in query)
                {
                    res.Add(new PacienteDTO(
                        temp.Id,
                        new PersonaDTO(
                            temp.Persona.Id,
                            temp.Persona.Dni,
                            temp.Persona.Apellidos,
                            temp.Persona.Nombres,
                            temp.Persona.FechaNacimiento,
                            temp.Persona.Sexo,
                            temp.Persona.CorreoElectronico,
                            temp.Persona.Telefono)));
                }
                return res;
            }
        }

        public static List<PacienteDTO> BuscarDni(string dni)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<PacienteDTO> res = new List<PacienteDTO>();
                var query = db.Paciente
                    .Where(el => el.Persona.Dni.Contains(dni))
                    .OrderBy(el => el.Persona.Apellidos)
                    .ThenBy(el => el.Persona.Nombres);
                foreach (Paciente temp in query)
                {
                    res.Add(new PacienteDTO(
                        temp.Id,
                        new PersonaDTO(
                            temp.Persona.Id,
                            temp.Persona.Dni,
                            temp.Persona.Apellidos,
                            temp.Persona.Nombres,
                            temp.Persona.FechaNacimiento,
                            temp.Persona.Sexo,
                            temp.Persona.CorreoElectronico,
                            temp.Persona.Telefono)));
                }
                return res;
            }
        }

        public static List<PacienteDTO> BuscarDni(EmpleadoDTO med, string dni)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<PacienteDTO> res = new List<PacienteDTO>();
                // Busco los pacientes de ese medico
                var subquery = db.Turno
                    .Where(el => el.Medico.EmpleadoId == med.Id)
                    .Select(el => el.PacienteId)
                    .ToList();
                var query = db.Paciente
                    .Where(el => subquery.Contains(el.Id) &&
                        el.Persona.Dni.Contains(dni))
                    .OrderBy(el => el.Persona.Apellidos)
                    .ThenBy(el => el.Persona.Nombres);
                foreach (Paciente temp in query)
                {
                    res.Add(new PacienteDTO(
                        temp.Id,
                        new PersonaDTO(
                            temp.Persona.Id,
                            temp.Persona.Dni,
                            temp.Persona.Apellidos,
                            temp.Persona.Nombres,
                            temp.Persona.FechaNacimiento,
                            temp.Persona.Sexo,
                            temp.Persona.CorreoElectronico,
                            temp.Persona.Telefono)));
                }
                return res;
            }
        }

        public static List<PacienteDTO> BuscarApeNom(string apenom)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<PacienteDTO> res = new List<PacienteDTO>();
                var query = db.Paciente
                    .Where(el => el.Persona.Apellidos.Contains(apenom) ||
                        el.Persona.Nombres.Contains(apenom))
                    .OrderBy(el => el.Persona.Apellidos)
                    .ThenBy(el => el.Persona.Nombres);
                foreach (Paciente temp in query)
                {
                    res.Add(new PacienteDTO(
                        temp.Id,
                        new PersonaDTO(
                            temp.Persona.Id,
                            temp.Persona.Dni,
                            temp.Persona.Apellidos,
                            temp.Persona.Nombres,
                            temp.Persona.FechaNacimiento,
                            temp.Persona.Sexo,
                            temp.Persona.CorreoElectronico,
                            temp.Persona.Telefono)));
                }
                return res;
            }
        }

        public static List<PacienteDTO> BuscarApeNom(EmpleadoDTO med, string apenom)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<PacienteDTO> res = new List<PacienteDTO>();
                // Busco los pacientes de ese medico
                var subquery = db.Turno
                    .Where(el => el.Medico.EmpleadoId == med.Id)
                    .Select(el => el.PacienteId)
                    .ToList();
                var query = db.Paciente
                    .Where(el => subquery.Contains(el.Id) &&
                        (el.Persona.Apellidos.Contains(apenom) ||
                        el.Persona.Nombres.Contains(apenom)))
                    .OrderBy(el => el.Persona.Apellidos)
                    .ThenBy(el => el.Persona.Nombres);
                foreach (Paciente temp in query)
                {
                    res.Add(new PacienteDTO(
                        temp.Id,
                        new PersonaDTO(
                            temp.Persona.Id,
                            temp.Persona.Dni,
                            temp.Persona.Apellidos,
                            temp.Persona.Nombres,
                            temp.Persona.FechaNacimiento,
                            temp.Persona.Sexo,
                            temp.Persona.CorreoElectronico,
                            temp.Persona.Telefono)));
                }
                return res;
            }
        }

        public static bool Guardar(PacienteDTO pac)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                Paciente nuevo = new Paciente();
                try
                {
                    if (!PersonaDAL.Guardar(pac.Persona))
                    {
                        return false;
                    }
                    nuevo.PersonaId = PersonaDAL.BuscarDni(pac.Persona.Dni).ElementAt(0).Id;
                    db.Paciente.Add(nuevo);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool Editar(PacienteDTO pac)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                Paciente modificado = db.Paciente
                    .Where(el => el.Id == pac.Id)
                    .First();
                try
                {
                    if (!PersonaDAL.Editar(pac.Persona))
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
