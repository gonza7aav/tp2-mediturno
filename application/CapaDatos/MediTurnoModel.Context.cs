﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class MediTurnoEntities : DbContext
    {
        public MediTurnoEntities()
            : base("name=MediTurnoEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Cobertura> Cobertura { get; set; }
        public DbSet<Empleado> Empleado { get; set; }
        public DbSet<Especialidad> Especialidad { get; set; }
        public DbSet<HistoriaClinica> HistoriaClinica { get; set; }
        public DbSet<Medico> Medico { get; set; }
        public DbSet<ObraSocial> ObraSocial { get; set; }
        public DbSet<Paciente> Paciente { get; set; }
        public DbSet<Persona> Persona { get; set; }
        public DbSet<TipoUsuario> TipoUsuario { get; set; }
        public DbSet<Turno> Turno { get; set; }
        public DbSet<TurnoEstado> TurnoEstado { get; set; }
    
        public virtual ObjectResult<ObtenerCantidadEspecialidades_Result> ObtenerCantidadEspecialidades(Nullable<System.DateTime> desde, Nullable<System.DateTime> hasta)
        {
            var desdeParameter = desde.HasValue ?
                new ObjectParameter("desde", desde) :
                new ObjectParameter("desde", typeof(System.DateTime));
    
            var hastaParameter = hasta.HasValue ?
                new ObjectParameter("hasta", hasta) :
                new ObjectParameter("hasta", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ObtenerCantidadEspecialidades_Result>("ObtenerCantidadEspecialidades", desdeParameter, hastaParameter);
        }
    
        public virtual ObjectResult<ObtenerNombreCompleto_Result> ObtenerNombreCompleto(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ObtenerNombreCompleto_Result>("ObtenerNombreCompleto", idParameter);
        }
    
        public virtual ObjectResult<ObtenerMedicosSolicitados_Result> ObtenerMedicosSolicitados(Nullable<System.DateTime> desde, Nullable<System.DateTime> hasta, Nullable<int> top)
        {
            var desdeParameter = desde.HasValue ?
                new ObjectParameter("desde", desde) :
                new ObjectParameter("desde", typeof(System.DateTime));
    
            var hastaParameter = hasta.HasValue ?
                new ObjectParameter("hasta", hasta) :
                new ObjectParameter("hasta", typeof(System.DateTime));
    
            var topParameter = top.HasValue ?
                new ObjectParameter("top", top) :
                new ObjectParameter("top", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ObtenerMedicosSolicitados_Result>("ObtenerMedicosSolicitados", desdeParameter, hastaParameter, topParameter);
        }
    
        public virtual ObjectResult<ObtenerPeriodo_Result> ObtenerPeriodo(Nullable<System.DateTime> desde, Nullable<System.DateTime> hasta)
        {
            var desdeParameter = desde.HasValue ?
                new ObjectParameter("desde", desde) :
                new ObjectParameter("desde", typeof(System.DateTime));
    
            var hastaParameter = hasta.HasValue ?
                new ObjectParameter("hasta", hasta) :
                new ObjectParameter("hasta", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ObtenerPeriodo_Result>("ObtenerPeriodo", desdeParameter, hastaParameter);
        }
    
        public virtual ObjectResult<ObtenerTurnos_Result> ObtenerTurnos(Nullable<System.DateTime> desde, Nullable<System.DateTime> hasta)
        {
            var desdeParameter = desde.HasValue ?
                new ObjectParameter("desde", desde) :
                new ObjectParameter("desde", typeof(System.DateTime));
    
            var hastaParameter = hasta.HasValue ?
                new ObjectParameter("hasta", hasta) :
                new ObjectParameter("hasta", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ObtenerTurnos_Result>("ObtenerTurnos", desdeParameter, hastaParameter);
        }
    
        public virtual ObjectResult<ObtenerCantidadCoberturas_Result> ObtenerCantidadCoberturas(Nullable<System.DateTime> desde, Nullable<System.DateTime> hasta)
        {
            var desdeParameter = desde.HasValue ?
                new ObjectParameter("desde", desde) :
                new ObjectParameter("desde", typeof(System.DateTime));
    
            var hastaParameter = hasta.HasValue ?
                new ObjectParameter("hasta", hasta) :
                new ObjectParameter("hasta", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ObtenerCantidadCoberturas_Result>("ObtenerCantidadCoberturas", desdeParameter, hastaParameter);
        }
    
        public virtual ObjectResult<ObtenerCartillaMedica_Result> ObtenerCartillaMedica()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ObtenerCartillaMedica_Result>("ObtenerCartillaMedica");
        }
    
        public virtual ObjectResult<ObtenerTurnosDelDia_Result> ObtenerTurnosDelDia(Nullable<int> med, Nullable<System.DateTime> dia)
        {
            var medParameter = med.HasValue ?
                new ObjectParameter("med", med) :
                new ObjectParameter("med", typeof(int));
    
            var diaParameter = dia.HasValue ?
                new ObjectParameter("dia", dia) :
                new ObjectParameter("dia", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ObtenerTurnosDelDia_Result>("ObtenerTurnosDelDia", medParameter, diaParameter);
        }
    
        public virtual ObjectResult<ObtenerFechaActual_Result> ObtenerFechaActual()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ObtenerFechaActual_Result>("ObtenerFechaActual");
        }
    
        public virtual ObjectResult<ObtenerUltimoTurno_Result> ObtenerUltimoTurno()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ObtenerUltimoTurno_Result>("ObtenerUltimoTurno");
        }
    
        public virtual ObjectResult<ObtenerCantidadObrasSociales_Result> ObtenerCantidadObrasSociales(Nullable<System.DateTime> desde, Nullable<System.DateTime> hasta)
        {
            var desdeParameter = desde.HasValue ?
                new ObjectParameter("desde", desde) :
                new ObjectParameter("desde", typeof(System.DateTime));
    
            var hastaParameter = hasta.HasValue ?
                new ObjectParameter("hasta", hasta) :
                new ObjectParameter("hasta", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ObtenerCantidadObrasSociales_Result>("ObtenerCantidadObrasSociales", desdeParameter, hastaParameter);
        }
    
        public virtual ObjectResult<ObtenerHistoriasClinicas_Result> ObtenerHistoriasClinicas(Nullable<int> medico, Nullable<int> paciente)
        {
            var medicoParameter = medico.HasValue ?
                new ObjectParameter("medico", medico) :
                new ObjectParameter("medico", typeof(int));
    
            var pacienteParameter = paciente.HasValue ?
                new ObjectParameter("paciente", paciente) :
                new ObjectParameter("paciente", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<ObtenerHistoriasClinicas_Result>("ObtenerHistoriasClinicas", medicoParameter, pacienteParameter);
        }
    }
}