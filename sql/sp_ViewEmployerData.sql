CREATE PROCEDURE sp_ViewEmployerData
    @UserRole NVARCHAR(10)
AS
BEGIN
    IF @UserRole = 'Admin'
    BEGIN
        SELECT 
            e.CompanyName AS Name,
            e.CompanyLocation AS Location,
            e.TaxCode,
            COUNT(v.VacancyID) AS JobCount,
			DATEDIFF(DAY, GETDATE(), c.EndDate) AS ContractDaysRemaining
        FROM 
            Employer e
        LEFT JOIN 
            Vacancy v ON e.EmployerID = v.Employer
            AND v.OpenDate <= GETDATE() AND (v.CloseDate >= GETDATE())
			AND v.VacancyStatus = 'Open'
		LEFT JOIN
			Constract c ON e.EmployerID = c.Employer
			AND (c.EndDate >= GETDATE() )
        GROUP BY 
            e.CompanyName, e.CompanyLocation, e.TaxCode, c.EndDate
    END
    ELSE
    BEGIN
        SELECT 
            e.CompanyName AS Name,
            e.CompanyLocation AS Location,
            COUNT(v.VacancyID) AS JobCount
        FROM 
            Employer e
        LEFT JOIN 
            Vacancy v ON e.EmployerID = v.Employer
            AND v.OpenDate <= GETDATE() AND (v.CloseDate >= GETDATE())
			AND v.VacancyStatus = 'Open'
        GROUP BY 
            e.CompanyName, e.CompanyLocation
    END
END
