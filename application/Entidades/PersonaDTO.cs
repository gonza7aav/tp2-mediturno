using System;

namespace MediTurno.Entidades
{
    public class PersonaDTO
    {
        public int Id;
        public string Dni;
        public string Apellidos;
        public string Nombres;
        public DateTime FechaNacimiento;
        public string Sexo;
        public string CorreoElectronico;
        public string Telefono;

        public PersonaDTO(int _id, string _dni, string _apellidos,
            string _nombres, DateTime _fechaNacimiento, string _sexo,
            string _correoElectronico, string _telefono)
        {
            Id = _id;
            Dni = _dni;
            Apellidos = _apellidos;
            Nombres = _nombres;
            FechaNacimiento = _fechaNacimiento;
            Sexo = _sexo;
            CorreoElectronico = _correoElectronico;
            Telefono = _telefono;
        }

        public PersonaDTO(string _dni, string _apellidos, string _nombres,
            DateTime _fechaNacimiento, string _sexo, string _correoElectronico,
            string _telefono)
        {
            Dni = _dni;
            Apellidos = _apellidos;
            Nombres = _nombres;
            FechaNacimiento = _fechaNacimiento;
            Sexo = _sexo;
            CorreoElectronico = _correoElectronico;
            Telefono = _telefono;
        }
    }
}
