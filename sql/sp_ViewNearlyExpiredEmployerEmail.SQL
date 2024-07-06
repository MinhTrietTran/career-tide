Use [CareerTide]
go
CREATE PROCEDURE sp_ViewNearlyExpiredEmployerEmail
AS
BEGIN
	SELECT EM.Representative
	from (select * 
	from Vacancy v
	where DATEDIFF(Day, getDate(), v.CloseDate) <=3 and 0 <= DATEDIFF(Day, getDate(), v.CloseDate)) AS VC JOIN 
	 (SELECT Representative, EmployerID
	FROM Employer ) as EM
	ON VC.Employer = em.EmployerID
END
