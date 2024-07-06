Use [CareerTide]
go
CREATE PROCEDURE sp_ViewApplicationsDataByStatusForAdmin
	@UserRole NVARCHAR(10),
	@ApplicationStatus VARCHAR(100)
AS
BEGIN
	IF @UserRole = 'Admin'
	BEGIN
		if (@ApplicationStatus != 'All')
		begin 
			select * 
			from Applications
			where ApplicationStatus = @ApplicationStatus;
		end
		else 
			begin
			select * 
			from Applications;
		end
	END
   
END
