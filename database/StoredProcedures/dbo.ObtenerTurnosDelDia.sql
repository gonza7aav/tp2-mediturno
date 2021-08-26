CREATE PROCEDURE [dbo].[ObtenerTurnosDelDia]
	@med int,
	@dia DATETIME
AS
	SELECT 
		CONCAT(DATEPART(hh, Turno.FechaHora), ':', DATEPART(mi, Turno.FechaHora))AS 'Hora',
		CONCAT(Persona.Apellidos, ' ', Persona.Nombres) AS 'Paciente',
		Persona.Dni AS 'DNI',
		DATEDIFF(YEAR, Persona.FechaNacimiento, GETDATE()) AS 'Edad',
		Persona.CorreoElectronico AS 'Correo Electronico',
		Persona.Telefono AS 'Telefono',
		Persona.Sexo AS 'Sexo',
		CONCAT(Cobertura.Descripcion, ' - ', ObraSocial.Nombre) AS 'Cobertura'
	FROM Turno
	JOIN Paciente ON Turno.PacienteId = Paciente.Id
	JOIN Persona ON Paciente.PersonaId = Persona.Id
	JOIN Cobertura ON Turno.CoberturaId = Cobertura.Id
	JOIN ObraSocial ON Cobertura.ObraSocialId = ObraSocial.Id
	WHERE
		Turno.MedicoId = @med AND
		DAY(Turno.FechaHora) = DAY(@dia) AND
		MONTH(Turno.FechaHora) = MONTH(@dia) AND
		YEAR(Turno.FechaHora) = YEAR(@dia) AND
		Turno.EstadoId IN (1,2)
RETURN 0