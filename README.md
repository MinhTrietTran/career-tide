# career-tide
## Description
Application windows desktop for managing recruitment progress.

## Installation
### System requirements:
- NuGet.Framework 6.10.0
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)
- [.NET Framework](https://dotnet.microsoft.com/download/dotnet-framework) version 4.8.
- [Microsoft Sql Server 2022](https://www.microsoft.com/en-us/sql-server/sql-server-2022) (SSMS for optional)
### Installation steps:
Follow these steps to install and run the application:

1. **Download**
   - Clone the repository from GitHub:
   - Alternatively, download the ZIP file and extract it to your desired location.
2. **Build the Solution**
   - Open the solution file (`CareerTide.sln`) in Visual Studio.

3. **Restore Packages**
   - Restore NuGet packages if necessary

4. **Build and Run**
   - Build the solution.
   - Set the startup project to `GUI` (or your WinForms project).
   - Press `F5` or click on the "Start" button in Visual Studio to run the application.

5. **Configuration (if applicable)**
   - Change the connection string in DAO:Connection.cs to fix with your server.
## Folder Structure
### Description of Folders

- **GUI**: This folder contains the graphical user interface (WinForms) project. It typically includes forms, controls, and other UI-related components.
  
- **BUS**: Business logic layer where the application's business rules and logic are implemented. This layer acts as an intermediary between the GUI and DAO layers.

- **DAO**: Data Access Objects (DAOs) encapsulate the logic required to access and manipulate data from the database. They provide methods for CRUD (Create, Read, Update, Delete) operations.

### sql Folder

- **sql**: This folder contains SQL scripts used for setting up and maintaining the database. It includes schema creation scripts, table definitions, stored procedures, and other database-related scripts.
### Testfiles Folder
- Used to store file test in pdf,png,..
### Notes

- Ensure to maintain the separation of concerns between the GUI, BUS, DTO, and DAO layers to adhere to the principles of layered architecture.
- Modify the folder structure description according to your specific project's organization and naming conventions.
## Contact
For support, please contact [fb.com/trietchan].
