namespace MediTurno.Entidades
{
    public class ObraSocialDTO
    {
        public int Id;
        public string Nombre;
        public bool Estado;

        public ObraSocialDTO(int _id, string _nombre, bool? _estado)
        {
            Id = _id;
            Nombre = _nombre;
            Estado = _estado.HasValue? _estado.Value : true;
        }

        public ObraSocialDTO(string _nombre, bool _estado)
        {
            Nombre = _nombre;
            Estado = _estado;
        }
    }
}
