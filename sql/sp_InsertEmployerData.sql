CREATE PROCEDURE sp_InsertEmployerData
    @FullName NVARCHAR(100),
    @WorkTittle NVARCHAR(100),
    @WorkEmail VARCHAR(100),
    @PhoneNumber VARCHAR(100),
    @CompanyName NVARCHAR(100),
    @CompanyLocation NVARCHAR(100),
    @TaxCode VARCHAR(20)
AS
BEGIN
    -- Bắt đầu một transaction
    BEGIN TRANSACTION;

    BEGIN TRY
        -- Thực hiện INSERT vào bảng Representative
        INSERT INTO Representative (FullName, WorkTittle, WorkEmail, PhoneNumber)
        VALUES (@FullName, @WorkTittle, @WorkEmail, @PhoneNumber);

        -- Thực hiện INSERT vào bảng Employer
        INSERT INTO Employer (CompanyName, CompanyLocation, TaxCode, Representative)
        VALUES (@CompanyName, @CompanyLocation, @TaxCode, @WorkEmail);

        -- Thực hiện INSERT vào bảng Account
        INSERT INTO Account (Email, Pwd, UserRole)
        VALUES (@WorkEmail, @PhoneNumber, 'Employer');

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
