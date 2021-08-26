namespace MediTurno.Entidades
{
    public class PacienteDTO
    {
        public int Id;
        public PersonaDTO Persona;

        public PacienteDTO(int _id, PersonaDTO _persona)
        {
            Id = _id;
            Persona = _persona;
        }

        public PacienteDTO(PersonaDTO _persona)
        {
            Persona = _persona;
        }
    }
}
