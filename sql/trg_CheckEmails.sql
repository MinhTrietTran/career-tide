
CREATE TRIGGER trg_CheckEmails
ON Account
FOR INSERT, UPDATE
AS
BEGIN
    DECLARE @Email VARCHAR(100), @UserRole VARCHAR(10);
    SELECT @Email = Email, @UserRole = UserRole FROM inserted;

    IF @UserRole = 'Employer'
    BEGIN
        IF NOT EXISTS (SELECT 1 FROM Representative WHERE WorkEmail = @Email)
        BEGIN
            RAISERROR ('Email does not exist in Representative table', 16, 1);
            ROLLBACK;
        END
    END
    ELSE IF @UserRole = 'Applicant'
    BEGIN
        IF NOT EXISTS (SELECT 1 FROM Applicant WHERE ApplicantEmail = @Email)
        BEGIN
            RAISERROR ('Email does not exist in Applicant table', 16, 1);
            ROLLBACK;
        END
    END
    ELSE IF @UserRole = 'Admin'
    BEGIN 
        RETURN;
    END
END;
