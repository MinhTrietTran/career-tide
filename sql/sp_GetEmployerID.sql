CREATE PROCEDURE sp_GetEmployerID
    @RepresentativeEmail VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @EmployerID INT;

    SELECT @EmployerID = e.EmployerID
    FROM Employer e
    INNER JOIN Representative r ON e.Representative = r.WorkEmail
    WHERE r.WorkEmail = @RepresentativeEmail;

    SELECT @EmployerID AS EmployerID;
END;
