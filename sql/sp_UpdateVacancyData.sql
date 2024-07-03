USE [CareerTide]
go
CREATE PROCEDURE sp_UpdateVacancyData
	@VacancyID INT,
    @Position NVARCHAR(100),
    @Number INT,
    @OpenDate DATE,
	@CloseDate DATE,
	@VacancyDescription NVARCHAR(4000),
	@PostType VARCHAR(10),
	@Cost FLOAT(53),
	@VacancyStatus VARCHAR(100)
AS
BEGIN
    -- Bắt đầu một transaction
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Thực hiện INSERT vào bảng Certificate
        update Vacancy 
		set Position=@Position, Number=@Number, OpenDate=@OpenDate, CloseDate=@CloseDate, VacancyDescription=@VacancyDescription, PostType=@PostType, Cost=@Cost, VacancyStatus=@VacancyStatus
        where VacancyID = @VacancyID;

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
