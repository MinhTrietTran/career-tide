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
	@VacancyStatus VARCHAR(100),
	@result bit output
AS
BEGIN
    -- Bắt đầu một transaction
    BEGIN TRANSACTION;

    BEGIN TRY
		declare @currentStatus VARCHAR(100);
		declare @remainDay int;

		select @currentStatus = V.VacancyStatus, @remainDay = DATEDIFF(day, V.OpenDate, GETDATE())
		from Vacancy V
		where VacancyID = @VacancyID;

		if (@currentStatus = 'Opening') -- Đã đăng
		begin
			if (@remainDay <=3) -- trong vòng 3 ngày có thể sửa
			begin
				update Vacancy 
				set Position=@Position, Number=@Number, OpenDate=@OpenDate, CloseDate=@CloseDate, VacancyDescription=@VacancyDescription, PostType=@PostType, Cost=@Cost, VacancyStatus=@VacancyStatus
				where VacancyID = @VacancyID;

				set @result =1;
			end
			else -- quá 3 ngày thì cút
			begin
				set @result = 0;
			end
		end
		else -- chưa đăng có thể sửa thoải mái
			begin
				-- Thực hiện update vào bảng Vacancy
				update Vacancy 
				set Position=@Position, Number=@Number, OpenDate=@OpenDate, CloseDate=@CloseDate, VacancyDescription=@VacancyDescription, PostType=@PostType, Cost=@Cost, VacancyStatus=@VacancyStatus
				where VacancyID = @VacancyID;

				set @result =1;
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
