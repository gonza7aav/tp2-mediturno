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
    
    public partial class Cobertura
    {
        public Cobertura()
        {
            this.Turno = new HashSet<Turno>();
        }
    
        public int Id { get; set; }
        public int ObraSocialId { get; set; }
        public string Descripcion { get; set; }
        public Nullable<bool> Estado { get; set; }
    
        public virtual ObraSocial ObraSocial { get; set; }
        public virtual ICollection<Turno> Turno { get; set; }
    }
}
