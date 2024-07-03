CREATE PROCEDURE sp_InsertVacancyDataTriet
    @Position VARCHAR(100),
    @Number INT,
    @OpenDate DATE,
    @CloseDate DATE,
    @VacancyDescription NVARCHAR(4000),
    @PostType VARCHAR(10),
    @Employer INT
AS
BEGIN
    -- Bắt đầu một transaction
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Thực hiện INSERT vào bảng Vacancy
        INSERT INTO Vacancy(Position, Number, OpenDate, CloseDate, VacancyDescription, PostType, Cost, VacancyStatus, Employer)
        VALUES (@Position, @Number, @OpenDate, @CloseDate, @VacancyDescription,@PostType,DATEDIFF(DAY,@OpenDate,@CloseDate)*10.0,'Pending',@Employer);


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
