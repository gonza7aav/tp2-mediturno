using MediTurno.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MediTurno.CapaDatos
{
    public class PersonaDAL
    {
        public static PersonaDTO Buscar(int id)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                var query = db.Persona
                    .Where(el => el.Id == id)
                    .First();
                return new PersonaDTO(
                    query.Id,
                    query.Dni,
                    query.Apellidos,
                    query.Nombres,
                    query.FechaNacimiento,
                    query.Sexo,
                    query.CorreoElectronico,
                    query.Telefono);
            }
        }

        public static List<PersonaDTO> BuscarDni(string dni)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<PersonaDTO> res = new List<PersonaDTO>();
                var query = db.Persona
                    .Where(el => el.Dni.Contains(dni))
                    .OrderBy(el => el.Apellidos)
                    .ThenBy(el => el.Nombres);
                foreach (Persona temp in query)
                {
                    res.Add(new PersonaDTO(
                        temp.Id,
                        temp.Dni,
                        temp.Apellidos,
                        temp.Nombres,
                        temp.FechaNacimiento,
                        temp.Sexo,
                        temp.CorreoElectronico,
                        temp.Telefono));
                }
                return res;
            }
        }

        public static bool Guardar(PersonaDTO per)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                Persona nuevo = new Persona();
                nuevo.Dni = per.Dni;
                nuevo.Apellidos = per.Apellidos;
                nuevo.Nombres = per.Nombres;
                nuevo.FechaNacimiento = per.FechaNacimiento;
                nuevo.Sexo = per.Sexo;
                nuevo.CorreoElectronico = per.CorreoElectronico;
                nuevo.Telefono = per.Telefono;
                try
                {
                    db.Persona.Add(nuevo);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool Editar(PersonaDTO per)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                Persona modificado = db.Persona
                    .Where(el => el.Id == per.Id)
                    .First();
                modificado.Dni = per.Dni;
                modificado.Apellidos = per.Apellidos;
                modificado.Nombres = per.Nombres;
                modificado.FechaNacimiento = per.FechaNacimiento;
                modificado.Sexo = per.Sexo;
                modificado.CorreoElectronico = per.CorreoElectronico;
                modificado.Telefono = per.Telefono;
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
