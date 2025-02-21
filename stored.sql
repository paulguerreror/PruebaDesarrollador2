CREATE PROCEDURE sp_ConsultarPersonas
AS
BEGIN
    SELECT Id, NombreCompleto, NumeroIdentificacionCompleto, Email, FechaCreacion
    FROM Personas
    ORDER BY FechaCreacion DESC;
END;