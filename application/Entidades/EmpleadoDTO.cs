using System;

namespace MediTurno.Entidades
{
    public class EmpleadoDTO
    {
        public int Id;
        public PersonaDTO Persona;
        public string Cuil;
        public string Usuario;
        public string Contraseña;
        public DateTime FechaIngreso;
        public TipoUsuarioDTO TipoUsuario;
        public bool Activo;

        public EmpleadoDTO(int _id, PersonaDTO _persona, string _cuil,
            string _usuario, string _contraseña, DateTime _fechaIngreso,
            TipoUsuarioDTO _tipoUsuario, bool _activo)
        {
            Id = _id;
            Persona = _persona;
            Cuil = _cuil;
            Usuario = _usuario;
            Contraseña = _contraseña;
            FechaIngreso = _fechaIngreso;
            TipoUsuario = _tipoUsuario;
            Activo = _activo;
        }

        public EmpleadoDTO(PersonaDTO _persona, string _cuil, string _usuario,
            string _contraseña, DateTime _fechaIngreso, TipoUsuarioDTO _tipoUsuario,
            bool _activo)
        {
            Persona = _persona;
            Cuil = _cuil;
            Usuario = _usuario;
            Contraseña = _contraseña;
            FechaIngreso = _fechaIngreso;
            TipoUsuario = _tipoUsuario;
            Activo = _activo;
        }
    }
}
