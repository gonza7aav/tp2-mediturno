CREATE PROCEDURE [dbo].[ObtenerCartillaMedica]
AS
	SELECT 
		CONCAT(Persona.Apellidos, ' ', Persona.Nombres) AS 'Medico',
		Medico.Matricula AS 'Matricula',
		Especialidad.Descripcion AS 'Especialidad',
		Persona.CorreoElectronico AS 'Correo Electronico',
		Persona.Telefono AS 'Telefono'
	FROM Medico
	JOIN Empleado ON Medico.EmpleadoId = Empleado.Id
	JOIN Persona ON Empleado.PersonaId = Persona.Id
	JOIN Especialidad ON Medico.EspecialidadId = Especialidad.Id
	WHERE Empleado.Activo = 1
	ORDER BY Persona.Apellidos, Persona.Nombres ASC
RETURN 0