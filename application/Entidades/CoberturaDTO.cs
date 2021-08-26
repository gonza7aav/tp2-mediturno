namespace MediTurno.Entidades
{
    public class CoberturaDTO
    {
        public int Id;
        public ObraSocialDTO ObraSocial;
        public string Descripcion;
        public bool Estado;

        public CoberturaDTO(int _id, ObraSocialDTO _obraSocial, string _descripcion, bool? _estado)
        {
            Id = _id;
            ObraSocial = _obraSocial;
            Descripcion = _descripcion;
            Estado = _estado.HasValue? _estado.Value: true;
        }

        public CoberturaDTO(ObraSocialDTO _obraSocial, string _descripcion, bool _estado)
        {
            ObraSocial = _obraSocial;
            Descripcion = _descripcion;
            Estado = _estado;
        }
    }
}
