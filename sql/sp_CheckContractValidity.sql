CREATE PROCEDURE sp_CheckContractValidity
@Employer INT
AS
BEGIN
    SET NOCOUNT ON;

    DECLARE @CurrentDate DATE = GETDATE();  -- Lấy ngày hiện tại

    IF EXISTS (
        SELECT 1
        FROM Constract
        WHERE EndDate >= @CurrentDate AND Employer = @Employer
    )
    BEGIN
        SELECT 1 AS ContractIsValid;  -- Trả về 1 nếu có hợp đồng hợp lệ
    END
    ELSE
    BEGIN
        SELECT 0 AS ContractIsValid;  -- Trả về 0 nếu không có hợp đồng hợp lệ
    END
END;
GO
