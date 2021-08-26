namespace MediTurno.Entidades
{
    public class HistoriaClinicaDTO
    {
        public int Id;
        public TurnoDTO Turno;
        public string Descripcion;
        public string Archivo;

        public HistoriaClinicaDTO(int _id, TurnoDTO _turno, string _descripcion,
            string _archivo)
        {
            Id = _id;
            Turno = _turno;
            Descripcion = _descripcion;
            Archivo = _archivo;
        }

        public HistoriaClinicaDTO(TurnoDTO _turno, string _descripcion, string _archivo)
        {
            Turno = _turno;
            Descripcion = _descripcion;
            Archivo = _archivo;
        }
    }
}
