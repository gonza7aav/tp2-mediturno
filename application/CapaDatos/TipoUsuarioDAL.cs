using MediTurno.Entidades;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace MediTurno.CapaDatos
{
    public class TipoUsuarioDAL
    {
        public static List<TipoUsuarioDTO> Buscar()
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                List<TipoUsuarioDTO> res = new List<TipoUsuarioDTO>();
                var query = db.TipoUsuario
                    .OrderBy(el => el.Descripcion);
                foreach (TipoUsuario temp in query)
                {
                    res.Add(new TipoUsuarioDTO(
                        temp.Id,
                        temp.Descripcion));
                }
                return res;
            }
        }

        public static TipoUsuarioDTO Buscar(int id)
        {
            using (MediTurnoEntities db = new MediTurnoEntities())
            {
                var query = db.TipoUsuario
                    .Where(el => el.Id == id)
                    .First();
                return new TipoUsuarioDTO(
                    query.Id,
                    query.Descripcion);
            }
        }
    }
}
