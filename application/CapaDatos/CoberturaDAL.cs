using MediTurno.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MediTurno.CapaDatos
{
    public class CoberturaDAL
    {
        public static List<CoberturaDTO> Buscar()
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<CoberturaDTO> res = new List<CoberturaDTO>();
                var query = db.Cobertura
                    .OrderBy(el => el.ObraSocial.Nombre)
                    .ThenBy(el => el.Descripcion);
                foreach (Cobertura temp in query)
                {
                    res.Add(new CoberturaDTO(
                        temp.Id,
                        new ObraSocialDTO(
                            temp.ObraSocial.Id,
                            temp.ObraSocial.Nombre,
                            temp.ObraSocial.Estado),
                        temp.Descripcion,
                        temp.Estado));
                }
                return res;
            }
        }

        public static CoberturaDTO Buscar(int id)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                var query = db.Cobertura
                    .Where(el => el.Id == id)
                    .First();
                return new CoberturaDTO(
                    query.Id,
                    new ObraSocialDTO(
                        query.ObraSocial.Id,
                        query.ObraSocial.Nombre,
                        query.ObraSocial.Estado),
                    query.Descripcion,
                    query.Estado);
            }
        }

        public static List<CoberturaDTO> Buscar(string apenom)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<CoberturaDTO> res = new List<CoberturaDTO>();
                var query = db.Cobertura
                    .Where(el => el.ObraSocial.Nombre.Contains(apenom) || el.Descripcion.Contains(apenom))
                    .OrderBy(el => el.ObraSocial.Nombre)
                    .ThenBy(el => el.Descripcion);
                foreach (Cobertura temp in query)
                {
                    res.Add(new CoberturaDTO(
                        temp.Id,
                        new ObraSocialDTO(
                            temp.ObraSocial.Id,
                            temp.ObraSocial.Nombre,
                            temp.ObraSocial.Estado),
                        temp.Descripcion,
                        temp.Estado));
                }
                return res;
            }
        }

        public static bool Guardar(CoberturaDTO cob)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                Cobertura nuevo = new Cobertura();
                nuevo.ObraSocialId = cob.ObraSocial.Id;
                nuevo.Descripcion = cob.Descripcion;
                nuevo.Estado = cob.Estado;
                try
                {
                    db.Cobertura.Add(nuevo);
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }

        public static bool Editar(CoberturaDTO cob)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                Cobertura modificado = db.Cobertura
                    .Where(el => el.Id == cob.Id)
                    .First();
                modificado.ObraSocialId = cob.ObraSocial.Id;
                modificado.Descripcion = cob.Descripcion;
                modificado.Estado = cob.Estado;
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
