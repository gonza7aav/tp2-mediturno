CREATE PROCEDURE [dbo].[ObtenerMedicosSolicitados]
	@desde DATETIME,
	@hasta DATETIME,
	@top INT
AS
	SELECT TOP (@top) WITH TIES
		CONCAT(Persona.Apellidos, ' ', Persona.Nombres) AS 'Medico',
		Medico.Matricula AS 'Matricula',
		Empleado.Cuil AS 'CUIL',
		DATEDIFF(YEAR, Empleado.FechaIngreso, GETDATE()) AS 'Antiguedad',
		Especialidad.Descripcion AS 'Especialidad',
		COUNT(*) AS 'Cantidad'
	FROM Turno
	JOIN Medico ON Turno.MedicoId = Medico.Id
	JOIN Empleado ON Medico.EmpleadoId = Empleado.Id
	JOIN Persona ON Empleado.PersonaId = Persona.Id
	JOIN Especialidad ON Medico.EspecialidadId = Especialidad.Id
	WHERE
		@desde < Turno.FechaHora AND
		Turno.FechaHora < @hasta
	GROUP BY
		CONCAT(Persona.Apellidos, ' ', Persona.Nombres),
		Medico.Matricula,
		Empleado.Cuil,
		DATEDIFF(YEAR, Empleado.FechaIngreso, GETDATE()),
		Especialidad.Descripcion
	ORDER BY COUNT(*) DESC
RETURN