Use [CareerTide]
go
CREATE PROCEDURE sp_ViewVacancyDataByStatus
	@UserRole NVARCHAR(10),
	@VacancyStatus VARCHAR(100)
AS
BEGIN
	IF @UserRole = 'Admin'
	BEGIN
		if (@VacancyStatus != 'All')
		begin 
			select * 
			from Vacancy
			where VacancyStatus = @VacancyStatus;
		end
		else 
			begin
			select * 
			from Vacancy;
		end
	END
	ELSE IF  (@UserRole = 'Employer')
	BEGIN
		if (@VacancyStatus != 'All')
		begin
				select * 
				from Vacancy
				where VacancyStatus = @VacancyStatus AND VacancyStatus != 'Closed';
		end
		ELSE 
		BEGIN
				select * 
				from Vacancy
				where VacancyStatus != 'Closed';
		END
	END
	ELSE 
	BEGIN
		select * 
		from Vacancy
		where VacancyStatus = 'Opening';
	END
   
END
