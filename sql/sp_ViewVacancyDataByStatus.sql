Use [CareerTide]
go
CREATE PROCEDURE sp_ViewVacancyDataByStatus
	@UserRole NVARCHAR(10),
	@VacancyStatus VARCHAR(100)
AS
BEGIN
	IF @UserRole = 'Admin'
	BEGIN
		if (@VacancyStatus not like '')
		begin 
			select * 
			from Vacancy
			where VacancyID = @VacancyStatus;
		end
		else 
			begin
			select * 
			from Vacancy;
		end
	END
	ELSE 
	BEGIN
		if (@VacancyStatus not like '')
		begin 
			if (@UserRole = 'Employer')
			begin 
				select * 
				from Vacancy
				where VacancyID = @VacancyStatus;
			end
			else 
			begin
				 select * 
				from Vacancy
				where VacancyStatus = 'Opening';
			end
		end
		else 
			begin
			select * 
			from Vacancy;
		end
		
	END
   
END
