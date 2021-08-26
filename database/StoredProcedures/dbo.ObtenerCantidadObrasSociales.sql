CREATE PROCEDURE [dbo].[ObtenerCantidadObrasSociales]
	@desde DATETIME,
	@hasta DATETIME
AS
	SELECT
		ObraSocial.Nombre AS 'Obra Social',
		COUNT(*) AS 'Cantidad'
	FROM Turno
	JOIN Cobertura ON Turno.CoberturaId = Cobertura.Id
	JOIN ObraSocial ON Cobertura.ObraSocialId = ObraSocial.Id
	WHERE
		@desde < Turno.FechaHora AND
		Turno.FechaHora < @hasta AND
		Turno.EstadoId IN (1,2,3)
	GROUP BY ObraSocial.Nombre
	ORDER BY COUNT(*) ASC
RETURN 0