CREATE PROCEDURE [dbo].[ObtenerPeriodo]
	@desde DATETIME,
	@hasta DATETIME
AS
	SELECT CONCAT(DAY(@desde), '/', MONTH(@desde), '/', YEAR(@desde),
		' - ', DAY(@hasta), '/', MONTH(@hasta), '/', YEAR(@hasta)) AS 'Periodo'
RETURN