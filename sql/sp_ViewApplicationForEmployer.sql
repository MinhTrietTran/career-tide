CREATE PROCEDURE sp_ViewApplicationForEmployer
	@UserName VARCHAR(100)
AS
BEGIN
	BEGIN
		SELECT apps.ApplicationID, a.ApplicantName AS Candidate_Name, apps.Applicant AS Email, v.Position AS Position, e.CompanyName AS Company_Name, apps.ApplicationStatus AS Result, apps.CoverLetter
		FROM Applications apps JOIN Applicant a ON apps.Applicant = a.ApplicantEmail
		JOIN Vacancy v ON apps.Vacancy = v.VacancyID
		JOIN Employer e ON v.Employer = e.EmployerID
		WHERE e.Representative = @UserName AND apps.ApplicationStatus != 'Pending';
	END
END
GO