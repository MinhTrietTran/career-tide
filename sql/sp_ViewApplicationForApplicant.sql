CREATE PROCEDURE sp_ViewApplicationForApplicant
	@UserName VARCHAR(100)
AS
BEGIN
	BEGIN
		SELECT apps.ApplicationID, a.ApplicantName AS Candidate_Name, v.Position AS Position, e.CompanyName AS Company_Name, apps.ApplicationStatus AS Status, apps.CoverLetter
		FROM Applications apps JOIN Applicant a ON apps.Applicant = a.ApplicantEmail
		JOIN Vacancy v ON apps.Vacancy = v.VacancyID
		JOIN Employer e ON v.Employer = e.EmployerID
		WHERE apps.Applicant = @UserName;
	END
END
GO