CREATE PROCEDURE [dbo].[ObtenerNombreCompleto]
	@id INT
AS
	SELECT CONCAT(Persona.Apellidos, ' ', Persona.Nombres) AS 'Nombre'
	FROM Persona
	WHERE Persona.Id = @id
	ORDER BY Persona.Apellidos, Persona.Nombres ASC
RETURN