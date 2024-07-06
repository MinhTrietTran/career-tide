Use [CareerTide]
go
CREATE PROCEDURE sp_ViewNearlyExpiredVacancy
AS
BEGIN
	select * 
	from Vacancy v
	where DATEDIFF(Day, getDate(), v.CloseDate) <=3 and 0 <= DATEDIFF(Day, getDate(), v.CloseDate)
END
