using MediTurno.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MediTurno.CapaDatos
{
    public class ObraSocialDAL
    {
        public static List<ObraSocialDTO> Buscar()
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<ObraSocialDTO> res = new List<ObraSocialDTO>();
                var query = db.ObraSocial
                    .OrderBy(el => el.Nombre);
                foreach (ObraSocial temp in query)
                {
                    res.Add(new ObraSocialDTO(
                        temp.Id,
                        temp.Nombre,
                        temp.Estado));
                }
                return res;
            }
        }

        public static ObraSocialDTO Buscar(int id)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                var query = db.ObraSocial
                    .Where(el => el.Id == id)
                    .First();
                return new ObraSocialDTO(
                    query.Id,
                    query.Nombre,
                    query.Estado);
            }
        }

        public static List<ObraSocialDTO> Buscar(string apenom)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<ObraSocialDTO> res = new List<ObraSocialDTO>();
                var query = db.ObraSocial
                    .Where(el => el.Nombre.Contains(apenom))
                    .OrderBy(el => el.Nombre);
                foreach (ObraSocial temp in query)
                {
                    res.Add(new ObraSocialDTO(
                        temp.Id,
                        temp.Nombre,
                        temp.Estado));
                }
                return res;
            }
        }

        public static bool Guardar(ObraSocialDTO os)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                ObraSocial nuevo = new ObraSocial();
                nuevo.Nombre = os.Nombre;
                nuevo.Estado = os.Estado;
                try
                {
                    db.ObraSocial.Add(nuevo);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool Editar(ObraSocialDTO os)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                ObraSocial modificado = db.ObraSocial
                    .Where(el => el.Id == os.Id)
                    .First();
                modificado.Nombre = os.Nombre;
                modificado.Estado = os.Estado;
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
