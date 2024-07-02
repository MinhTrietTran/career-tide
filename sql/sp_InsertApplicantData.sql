CREATE PROCEDURE sp_InsertApplicantData
    @ApplicantName NVARCHAR(100),
    @ApplicantEmail VARCHAR(100),
    @Pwd VARCHAR(100)
AS
BEGIN
    -- Bắt đầu một transaction
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Thực hiện INSERT vào bảng Applicant
        INSERT INTO Applicant(ApplicantName, ApplicantEmail)
        VALUES (@ApplicantName, @ApplicantEmail);

        -- Thực hiện INSERT vào bảng Account
        INSERT INTO Account (Email, Pwd, UserRole)
        VALUES (@ApplicantEmail, @Pwd, 'Applicant');

        -- Commit transaction nếu không có lỗi
        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        -- Rollback transaction nếu có lỗi
        ROLLBACK TRANSACTION;

        -- Hiển thị lỗi
        DECLARE @ErrorMessage NVARCHAR(4000);
        DECLARE @ErrorSeverity INT;
        DECLARE @ErrorState INT;

        SELECT 
            @ErrorMessage = ERROR_MESSAGE(),
            @ErrorSeverity = ERROR_SEVERITY(),
            @ErrorState = ERROR_STATE();

        RAISERROR (@ErrorMessage, @ErrorSeverity, @ErrorState);
    END CATCH
END;
