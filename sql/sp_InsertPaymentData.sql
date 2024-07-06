USE [CareerTide]
go
CREATE PROCEDURE sp_InsertPaymentData
    @Amount FLOAT(53),
    @PaymentType VARCHAR(10),
	@Vacancy INT,
	@result bit OUTPUT
AS
BEGIN
    -- Bắt đầu một transaction
    BEGIN TRANSACTION;

    BEGIN TRY
		declare @postingDuration INT;
		declare @totalCost FLOAT(53);

		SELECT @postingDuration = DATEDIFF(day, V.OpenDate, V.CloseDate), @totalCost = v.Cost 
		FROM Vacancy 
		V WHERE VacancyID = @Vacancy;

        -- Thực hiện INSERT vào bảng Payment
		if @postingDuration <=30  -- Trả 1 lần
		begin
			if (@Amount < @totalCost) -- Deo đủ tiền
			begin
				set @result = 0;
			end
			else -- Đủ tiền
			begin
				insert into Payment (Amount, PaymentType, Vacancy)
				VALUES (@Amount, @PaymentType, @Vacancy);

				set @result = 1;
			end
		end
		ELSE -- trả góp
		begin 
			if (@Amount <@totalCost * 0.3) -- check phải lần cuối ko
			BEGIN
				declare @count int;
				select @count = count(p.PaymentID)
				from Vacancy v JOIN Payment p 
				ON v.VacancyID = p.Vacancy

				if (@count >= 3 and @Amount >= @totalCost *0.1) -- đóng lần cuối chỉ cần 10%
				begin
					INSERT INTO Payment (Amount, PaymentType, Vacancy)
					VALUES (@Amount, @PaymentType, @Vacancy);
					set @result = 1;
				end
				else 
				begin
					set @result = 0; -- deo đủ tiền
				end
			END
			ELSE -- đủ tiền trả góp
			BEGIN
				INSERT INTO Payment (Amount, PaymentType, Vacancy)
				VALUES (@Amount, @PaymentType, @Vacancy);
				set @result = 1;
			END
		end

        

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
