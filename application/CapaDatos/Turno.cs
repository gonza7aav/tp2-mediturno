//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MediTurno.CapaDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class Turno
    {
        public Turno()
        {
            this.HistoriaClinica = new HashSet<HistoriaClinica>();
        }
    
        public int Id { get; set; }
        public int MedicoId { get; set; }
        public int PacienteId { get; set; }
        public System.DateTime FechaHora { get; set; }
        public int CoberturaId { get; set; }
        public int EstadoId { get; set; }
    
        public virtual Cobertura Cobertura { get; set; }
        public virtual ICollection<HistoriaClinica> HistoriaClinica { get; set; }
        public virtual Medico Medico { get; set; }
        public virtual Paciente Paciente { get; set; }
        public virtual TurnoEstado TurnoEstado { get; set; }
    }
}
