USE [CareerTide]
GO

Create PROCEDURE sp_UpdateApplicationData
(
	@ApplicationID INT,
    @CoverLetter NVARCHAR(4000),
    @CV VARBINARY(MAX),
    @AcademicTranscript VARBINARY(MAX),
    @ApplicationStatus VARCHAR(100)
)
AS
BEGIN
    -- Bắt đầu một transaction
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Thực hiện INSERT vào bảng Applications
        Update  Applications 
		set CoverLetter=@CoverLetter, CV=@CV, AcademicTranscript=@AcademicTranscript, ApplicationStatus=@ApplicationStatus
		where ApplicationID = @ApplicationID

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
