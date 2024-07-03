Use [CareerTide]
go
CREATE PROCEDURE sp_ViewOneVacancyData
    @VacancyID INT
AS
BEGIN
   select * 
   from Vacancy
   where VacancyID = @VacancyID;
END
