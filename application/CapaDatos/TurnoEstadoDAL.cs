using MediTurno.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MediTurno.CapaDatos
{
    public class TurnoEstadoDAL
    {
        private static MediTurnoEntities db = new MediTurnoEntities();

        public static List<TurnoEstadoDTO> Buscar()
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<TurnoEstadoDTO> res = new List<TurnoEstadoDTO>();
                var query = db.TurnoEstado
                    .OrderBy(el => el.Descripcion);
                foreach (TurnoEstado temp in query)
                {
                    res.Add(new TurnoEstadoDTO(
                        temp.Id,
                        temp.Descripcion));
                }
                return res;
            }
        }

        public static TurnoEstadoDTO Buscar(int id)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                var query = db.TurnoEstado
                    .Where(el => el.Id == id)
                    .First();
                return new TurnoEstadoDTO(
                    query.Id,
                    query.Descripcion);
            }
        }
    }
}
