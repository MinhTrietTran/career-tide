-- Du lieu test cua minh triet tran
-- Admin
INSERT INTO Account(Email, Pwd, UserRole)
VALUES ('tmtdzbodoithe@gmail.com','1','Admin')

-- Employer
INSERT INTO Representative(FullName, WorkTittle, WorkEmail, PhoneNumber)
VALUES (N'Nguyễn Minh Thuận', 'HR Head','employertest@gmail.com', '0123456789')
INSERT INTO Employer(CompanyName, CompanyLocation, TaxCode, Representative)
VALUES ('CONG TY MA', N'Làng Lắk Kon Ku', '1111111111', 'employertest@gmail.com')

INSERT INTO Account(Email, Pwd, UserRole)
VALUES ('employertest@gmail.com','1','Employer')

-- Applicant
INSERT INTO Applicant(ApplicantName, ApplicantEmail)
VALUES ('Lăng Phương Phương', 'applicanttest@gmail.com')

INSERT INTO Account(Email, Pwd, UserRole)
VALUES ('applicanttest@gmail', '1', 'Applicant')

