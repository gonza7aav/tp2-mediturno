CREATE PROCEDURE [dbo].[ObtenerCantidadEspecialidades]
	@desde DATETIME,
	@hasta DATETIME
AS
	SELECT
		Especialidad.Descripcion AS 'Especialidad',
		COUNT(*) AS 'Cantidad'
	FROM Turno
	JOIN Medico ON Turno.MedicoId = Medico.Id
	JOIN Especialidad ON Medico.EspecialidadId = Especialidad.Id
	WHERE
		@desde < Turno.FechaHora AND
		Turno.FechaHora < @hasta
	GROUP BY Especialidad.Descripcion
	ORDER BY COUNT(*) DESC
RETURN