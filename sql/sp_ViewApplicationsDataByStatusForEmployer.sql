Use [CareerTide]
go
CREATE PROCEDURE sp_ViewApplicationsDataByStatusForEmployer
	@VacancyID INT , 
	@UserRole NVARCHAR(10),
	@ApplicationStatus VARCHAR(100)
AS
BEGIN
	IF  (@UserRole = 'Employer')
	BEGIN
		if (@ApplicationStatus != 'All')
		begin
				select * 
				from Applications
				where ApplicationStatus = @ApplicationStatus AND Vacancy = @VacancyID;
		end
		ELSE 
		BEGIN
				select * 
				from Applications
				where Vacancy = @VacancyID;
		END
	END
   
END
