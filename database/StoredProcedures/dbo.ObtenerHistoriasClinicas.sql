CREATE PROCEDURE [dbo].[ObtenerHistoriasClinicas]
	@medico INT,
	@paciente INT
AS
	SELECT 
		CONCAT(DAY(Turno.FechaHora), '/', MONTH(Turno.FechaHora), '/', YEAR(Turno.FechaHora)) AS 'Dia',
		CONCAT(DATEPART(hh, Turno.FechaHora), ':', DATEPART(mi, Turno.FechaHora))AS 'Hora',
		HistoriaClinica.Descripcion AS 'Historia Clinica'
	FROM HistoriaClinica
	JOIN Turno ON HistoriaClinica.TurnoId = Turno.Id
	WHERE
		Turno.MedicoId = @medico AND
		Turno.PacienteId = @paciente
RETURN 0