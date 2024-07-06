CREATE PROCEDURE sp_InsertPaymentData
    @Amount FLOAT(53),
    @PaymentType VARCHAR(10),
	@Vacancy INT,
	@result BIT OUTPUT
AS
BEGIN
    -- Bắt đầu một transaction
    BEGIN TRANSACTION;

    BEGIN TRY
		DECLARE @postingDuration INT;
		DECLARE @totalCost FLOAT(53);
		DECLARE @RemainingCost FLOAT(53);

		-- Lấy giá trị RemainingCost từ hàm fn_GetRemainingCost
		SET @RemainingCost = [dbo].[fn_GetRemainingCost](@Vacancy);

		-- Lấy postingDuration và totalCost từ bảng Vacancy
		SELECT @postingDuration = DATEDIFF(day, OpenDate, CloseDate), @totalCost = Cost
		FROM Vacancy
		WHERE VacancyID = @Vacancy;

        -- Thực hiện INSERT vào bảng Payment
		IF @postingDuration <= 30  -- Trả 1 lần
		BEGIN
			IF @Amount < @totalCost  -- Không đủ tiền
			BEGIN
				SET @result = 0; -- Không đủ tiền để thanh toán một lần
			END
			ELSE  -- Đủ tiền
			BEGIN
				INSERT INTO Payment (Amount, PaymentType, Vacancy)
				VALUES (@Amount, @PaymentType, @Vacancy);

				SET @result = 1; -- Thanh toán thành công
			END
		END
		ELSE  -- Trả góp
		BEGIN
			IF @RemainingCost < @totalCost * 0.3  -- Kiểm tra có phải thanh toán cuối không (remaining < 30% cost)
			BEGIN
				IF @Amount >= @RemainingCost  -- Điều kiện thanh toán cuối cùng
				BEGIN
					INSERT INTO Payment (Amount, PaymentType, Vacancy)
					VALUES (@Amount, @PaymentType, @Vacancy);

					SET @result = 1; -- Thanh toán cuối cùng thành công
				END
				ELSE
				BEGIN
					SET @result = 0;  -- Không đủ tiền cho thanh toán cuối cùng
				END
			END
			ELSE  -- Không phải thanh toán cuối, phải đóng trên 30% tổng chi phí
			BEGIN
				IF @Amount < @totalCost * 0.3  -- Không đủ tiền
				BEGIN
					SET @result = 0; -- Không đủ tiền để thanh toán trả góp
				END
				ELSE  -- Đủ tiền
				BEGIN
					INSERT INTO Payment (Amount, PaymentType, Vacancy)
					VALUES (@Amount, @PaymentType, @Vacancy);

					SET @result = 1; -- Thanh toán trả góp thành công
				END
			END
		END

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