CREATE PROCEDURE [dbo].[ObtenerTurnos]
	@desde DATETIME,
	@hasta DATETIME
AS
	SELECT
		CONCAT(pm.Apellidos, ' ', pm.Nombres) AS 'Medico',
		CONCAT(pp.Apellidos, ' ', pp.Nombres) AS 'Paciente',
		CONCAT(Cobertura.Descripcion, ' - ', ObraSocial.Nombre) AS 'Cobertura',
		CONCAT(DAY(Turno.FechaHora), '/', MONTH(Turno.FechaHora), '/', YEAR(Turno.FechaHora)) AS 'Dia',
		CONCAT(DATEPART(hh, Turno.FechaHora), ':', DATEPART(mi, Turno.FechaHora))AS 'Hora'
	FROM Turno
	JOIN Medico ON Turno.MedicoId = Medico.Id
	JOIN Empleado ON Medico.EmpleadoId = Empleado.Id
	JOIN Persona pm ON Empleado.PersonaId = pm.Id
	JOIN Paciente ON Turno.PacienteId = Paciente.Id
	JOIN Persona pp ON Paciente.PersonaId = pp.Id
	JOIN Cobertura ON Turno.CoberturaId = Cobertura.Id
	JOIN ObraSocial ON Cobertura.ObraSocialId = ObraSocial.Id
	WHERE
		@desde < Turno.FechaHora AND
		Turno.FechaHora < @hasta
	ORDER BY Turno.FechaHora ASC
RETURN