
CREATE PROCEDURE sp_ViewVacancyDataByStatus
	@UserName VARCHAR(100),
	@UserRole VARCHAR(10),
	@VacancyStatus VARCHAR(100) -- All, Peding, Open, Closed
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @EmployerID INT;

    -- Gọi stored procedure sp_GetEmployerID và lấy giá trị @EmployerID
    CREATE TABLE #TempEmployerID (EmployerID INT);
    
    INSERT INTO #TempEmployerID (EmployerID)
    EXEC sp_GetEmployerID @UserName;

    SELECT @EmployerID = EmployerID FROM #TempEmployerID;


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
				select VacancyID, Position, Number, OpenDate, CloseDate, VacancyDescription, PostType, Cost, VacancyStatus
				from Vacancy
				where Employer = @EmployerID AND VacancyStatus = @VacancyStatus AND VacancyStatus != 'Closed';
		end
		ELSE 
		BEGIN
				select VacancyID, Position, Number, OpenDate, CloseDate, VacancyDescription, PostType, Cost, VacancyStatus
				from Vacancy
				where Employer = @EmployerID AND VacancyStatus != 'Closed';
		END
	END
	ELSE 
	BEGIN
		select v.VacancyID, v.Position, v.Number, v.VacancyDescription, e.CompanyName
		from Vacancy v JOIN Employer e ON v.Employer = e.EmployerID
		where v.VacancyStatus = 'Open';
	END
   
END
GO