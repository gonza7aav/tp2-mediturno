using System;

namespace MediTurno.Entidades
{
    public class TurnoDTO
    {
        public int Id;
        public MedicoDTO Medico;
        public PacienteDTO Paciente;
        public DateTime FechaHora;
        public CoberturaDTO Cobertura;
        public TurnoEstadoDTO Estado;

        public TurnoDTO(int _id, MedicoDTO _medico, PacienteDTO _paciente,
            DateTime _fechaHora, CoberturaDTO _cobertura, TurnoEstadoDTO _estado)
        {
            Id = _id;
            Medico = _medico;
            Paciente = _paciente;
            FechaHora = _fechaHora;
            Cobertura = _cobertura;
            Estado = _estado;
        }

        public TurnoDTO(MedicoDTO _medico, PacienteDTO _paciente, DateTime _fechaHora,
            CoberturaDTO _cobertura, TurnoEstadoDTO _estado)
        {
            Medico = _medico;
            Paciente = _paciente;
            FechaHora = _fechaHora;
            Cobertura = _cobertura;
            Estado = _estado;
        }
    }
}
