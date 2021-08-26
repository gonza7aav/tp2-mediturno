CREATE PROCEDURE [dbo].[ObtenerUltimoTurno]
AS
	SELECT TOP 1
		CONCAT(pm.Apellidos, ' ', pm.Nombres) AS 'Medico',
		CONCAT(pp.Apellidos, ' ', pp.Nombres) AS 'Paciente',
		CONCAT(DAY(Turno.FechaHora), '/', MONTH(Turno.FechaHora), '/', YEAR(Turno.FechaHora)) AS 'Dia',
		CONCAT(DATEPART(hh, Turno.FechaHora), ':', DATEPART(mi, Turno.FechaHora))AS 'Hora',
		CONCAT(Cobertura.Descripcion, ' - ', ObraSocial.Nombre) AS 'Cobertura'
	FROM Turno
	JOIN Medico ON Turno.MedicoId = Medico.Id
	JOIN Empleado ON Medico.EmpleadoId = Empleado.Id
	JOIN Persona pm ON Empleado.PersonaId = pm.Id
	JOIN Paciente ON Turno.PacienteId = Paciente.Id
	JOIN Persona pp ON Paciente.PersonaId = pp.Id
	JOIN Cobertura ON Turno.CoberturaId = Cobertura.Id
	JOIN ObraSocial ON Cobertura.ObraSocialId = ObraSocial.Id
	ORDER BY Turno.Id DESC
RETURN 0