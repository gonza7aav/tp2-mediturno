using MediTurno.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MediTurno.CapaDatos
{
    public class EspecialidadDAL
    {
        public static List<EspecialidadDTO> Buscar()
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<EspecialidadDTO> res = new List<EspecialidadDTO>();
                var query = db.Especialidad
                    .OrderBy(el => el.Descripcion);
                foreach (Especialidad temp in query)
                {
                    res.Add(new EspecialidadDTO(
                        temp.Id,
                        temp.Descripcion));
                }
                return res;
            }
        }

        public static EspecialidadDTO Buscar(int id)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                var query = db.Especialidad
                    .Where(el => el.Id == id)
                    .First();
                return new EspecialidadDTO(
                    query.Id,
                    query.Descripcion);
            }
        }

        public static List<EspecialidadDTO> Buscar(string apenom)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<EspecialidadDTO> res = new List<EspecialidadDTO>();
                var query = db.Especialidad
                    .Where(el => el.Descripcion.Contains(apenom))
                    .OrderBy(el => el.Descripcion);
                foreach (Especialidad temp in query)
                {
                    res.Add(new EspecialidadDTO(
                        temp.Id,
                        temp.Descripcion));
                }
                return res;
            }
        }

        public static bool Guardar(EspecialidadDTO esp)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                Especialidad nuevo = new Especialidad();
                nuevo.Descripcion = esp.Descripcion;
                try
                {
                    db.Especialidad.Add(nuevo);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool Editar(EspecialidadDTO esp)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                Especialidad modificado = db.Especialidad
                    .Where(el => el.Id == esp.Id)
                    .First();
                modificado.Descripcion = esp.Descripcion;
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
