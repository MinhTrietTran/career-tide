Use [CareerTide]
go
CREATE PROCEDURE sp_ViewApplicationsDataByStatusForApplicant
	@ApplicantEmail VARCHAR(100),
	@UserRole NVARCHAR(10),
	@ApplicationStatus VARCHAR(100)
AS
BEGIN
	IF  (@UserRole = 'Applicant')
	BEGIN
		if (@ApplicationStatus != 'All')
		begin
				select * 
				from Applications
				where ApplicationStatus = @ApplicationStatus AND Applicant = @ApplicantEmail;
		end
		ELSE 
		BEGIN
				select * 
				from Applications
				where  Applicant = @ApplicantEmail;
		END
	END
END
