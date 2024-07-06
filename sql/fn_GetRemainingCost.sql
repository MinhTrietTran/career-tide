CREATE FUNCTION fn_GetRemainingCost
(
    @VacancyID INT
)
RETURNS FLOAT
AS
BEGIN
    DECLARE @TotalCost FLOAT;
    DECLARE @TotalPaid FLOAT;
    DECLARE @RemainingCost FLOAT;

    -- Lấy tổng chi phí của vacancy
    SELECT @TotalCost = Cost
    FROM Vacancy
    WHERE VacancyID = @VacancyID;

    -- Lấy tổng số tiền đã thanh toán cho vacancy
    SELECT @TotalPaid = ISNULL(SUM(Amount), 0)
    FROM Payment
    WHERE Vacancy = @VacancyID;

    -- Tính số tiền còn lại phải trả
    SET @RemainingCost = @TotalCost - @TotalPaid;

    RETURN @RemainingCost;
END;
GO
