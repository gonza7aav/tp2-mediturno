namespace MediTurno.Entidades
{
    public class TipoUsuarioDTO
    {
        public int Id;
        public string Descripcion;

        public TipoUsuarioDTO(int _id, string _descripcion)
        {
            Id = _id;
            Descripcion = _descripcion;
        }

        public TipoUsuarioDTO(string _descripcion)
        {
            Descripcion = _descripcion;
        }
    }
}
