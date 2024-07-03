﻿USE [CareerTide]
go
CREATE PROCEDURE sp_InsertPaymentData
    @Amount FLOAT(53),
    @PaymentType VARCHAR(10),
	@Vacancy INT
AS
BEGIN
    -- Bắt đầu một transaction
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Thực hiện INSERT vào bảng Certificate
        INSERT INTO Payment (Amount, PaymentType, Vacancy)
        VALUES (@Amount, @PaymentType, @Vacancy);

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
