USE MASTER
GO
DROP DATABASE CareerTide
GO
CREATE DATABASE CareerTide
GO
USE CareerTide
GO

-- TAO BANG VA RANG BUOC KHOA CHINH
CREATE TABLE Representative
(
	FullName NVARCHAR(100) NOT NULL,
	WorkTittle NVARCHAR(100) NOT NULL,
	WorkEmail VARCHAR(100) NOT NULL,
	PhoneNumber VARCHAR(100) NOT NULL
	CONSTRAINT PK_Representative PRIMARY KEY(WorkEmail)
)

CREATE TABLE Employer
(
	EmployerID INT IDENTITY(1,1) NOT NULL,
	CompanyName NVARCHAR(100) NOT NULL,
	CompanyLocation NVARCHAR(100) NOT NULL,
	TaxCode VARCHAR(100) NOT NULL,
	Representative VARCHAR(100)
	CONSTRAINT PK_Employer PRIMARY KEY(EmployerID)
)

CREATE TABLE Applicant
(
	ApplicantName NVARCHAR(100) NOT NULL,
	ApplicantEmail VARCHAR(100) NOT NULL,
	CONSTRAINT PK_Applicant PRIMARY KEY(ApplicantEmail)
)

CREATE TABLE Account
(	
	Email VARCHAR(100),
	Pwd VARCHAR(100),
	UserRole VARCHAR(10) CHECK(UserRole IN ('Admin','Employer','Applicant')) NOT NULL
	CONSTRAINT PK_Account PRIMARY KEY(Email)
)

CREATE TABLE Constract
(
	ConstractID INT IDENTITY(1,1) NOT NULL,
	StartDate DATE NOT NULL,
	EndDate DATE NOT NULL,
	ConstractInfo NVARCHAR(4000) NOT NULL,
	Employer INT
	CONSTRAINT PK_Constract PRIMARY KEY(ConstractID)
)

CREATE TABLE Vacancy
(	
	VacancyID INT IDENTITY(1,1) NOT NULL,
	Position NVARCHAR(100) NOT NULL,
	Number INT NOT NULL,
	OpenDate DATE NOT NULL,
	CloseDate DATE NOT NULL,
	VacancyDescription NVARCHAR(4000) NOT NULL,
	PostType VARCHAR(10) CHECK(PostType IN('Newspaper', 'Banner', 'Website')) NOT NULL,
	Cost FLOAT(53) NOT NULL, 
	VacancyStatus VARCHAR(100) NOT NULL,
	Employer INT
	CONSTRAINT PK_Vacancy PRIMARY KEY(VacancyID)
)

CREATE TABLE Payment
(	
	PaymentID INT IDENTITY(1,1) NOT NULL,
	Amount FLOAT(53) NOT NULL,
	PaymentType VARCHAR(10) CHECK(PaymentType IN('Cash','Ebanking')) NOT NULL,
	Vacancy INT
	CONSTRAINT PK_Payment PRIMARY KEY(PaymentID)
)

CREATE TABLE Applications
(	
	ApplicationID INT IDENTITY(1,1) NOT NULL,
	CoverLetter NVARCHAR(4000) NOT NULL,
	CV VARBINARY(MAX),
	AcademicTranscript VARBINARY(MAX),
	ApplicationStatus VARCHAR(100) NOT NULL,
	Applicant VARCHAR(100),
	Vacancy INT,
	CONSTRAINT PK_Applications PRIMARY KEY(ApplicationID)
)

CREATE TABLE Certificate
(	
	CertificateID INT IDENTITY(1,1) NOT NULL,
	CertificateFile VARBINARY(MAX),
	Applications INT
	CONSTRAINT PK_Certificate PRIMARY KEY(CertificateID)
)

-- TAO RANG BUOC KHOA NGOAI
ALTER TABLE Employer
ADD CONSTRAINT FK_Employer_Representative
FOREIGN KEY (Representative)
REFERENCES Representative(WorkEmail) ON DELETE CASCADE

ALTER TABLE Account
ADD CONSTRAINT FK_Account_Representative
FOREIGN KEY (Email)
REFERENCES Representative(WorkEmail) ON DELETE CASCADE

ALTER TABLE Account
ADD CONSTRAINT FK_Account_Applicant
FOREIGN KEY (Email)
REFERENCES Applicant(ApplicantEmail) ON DELETE CASCADE

ALTER TABLE Constract
ADD CONSTRAINT FK_Constract_Employer
FOREIGN KEY (Employer)
REFERENCES Employer(EmployerID) ON DELETE CASCADE

ALTER TABLE Vacancy
ADD CONSTRAINT FK_Vacancy_Employer
FOREIGN KEY (Employer)
REFERENCES Employer(EmployerID) ON DELETE CASCADE

ALTER TABLE Payment
ADD CONSTRAINT FK_Payment_Vacancy
FOREIGN KEY (Vacancy)
REFERENCES Vacancy(VacancyID) ON DELETE CASCADE

ALTER TABLE Applications
ADD CONSTRAINT FK_Applications_Applicant
FOREIGN KEY (Applicant)
REFERENCES Applicant(ApplicantEmail) ON DELETE CASCADE

ALTER TABLE Applications
ADD CONSTRAINT FK_Applications_Vacancy
FOREIGN KEY (Vacancy)
REFERENCES Vacancy(VacancyID) ON DELETE CASCADE

ALTER TABLE Certificate
ADD CONSTRAINT FK_Certificate_Applications
FOREIGN KEY (Applications)
REFERENCES Applications(ApplicationID)






