The API is built with ASP.NET CORE 9 (Latest Version)

Tools and Libraries Used:
Microsoft.EntityFrameworkCore: This is the core library for interacting with databases in Entity Framework Core, allowing for data models and query execution.
Microsoft.EntityFrameworkCore.Design: Provides design-time support for EF Core, such as for migrations.
Microsoft.EntityFrameworkCore.SqlServer: This is the provider for SQL Server in EF Core, enabling communication between the application and a SQL Server database.
Microsoft.EntityFrameworkCore.Tools: Contains tools for working with EF Core via the command line, such as dotnet ef commands for migrations and scaffolding.
BCrypt.Net-Next: A library used to hash and verify passwords securely, ensuring password protection during user authentication.
AutoMapper: A library that helps with mapping between different object models, typically between DTOs and entity models, reducing boilerplate code for object transformations.
Swashbuckle.AspNetCore.SwaggerGen: A library that generates Swagger documentation for the API, enabling easy exploration and testing of the API endpoints via Swagger UI.


Project Structure:
The project follows a clean architecture with three main layers to promote separation of concerns and maintainability:
Presentation Layer:Responsible for handling HTTP requests, returning responses, and exposing API endpoints.
Business Layer: Contains the core business logic of the application and mplements Unit of Work pattern to manage database transactions.
Data Access Layer: 
Responsible for interacting with the database. It uses Entity Framework Core for database communication.
Contains repositories for CRUD operations on data models and uses DbContext for managing database connections and transactions.

Some parts of the code also include in-code documentation.

User Configuration and Database Migration:
In the Data Access Layer, there is a UserConfiguration file that ensures the application creates a default user when the database migration is run. This user will be used in the login attempts during the initial application setup.
The default password for this user is hashed using BCrypt.Net-Next to ensure secure storage.
Password: P@ssw0rd (The plain password is provided here for setup purposes, but in the system, it will be hashed).

Running the Application:
To run the application, follow the steps below to set up your environment, apply migrations, and run the application.

Set up Microsoft SQL Server:
Before running the application, you need to set up a Microsoft SQL Server (MSSQL) instance to host the database.

Set Connection String:
Update the connection string in the appsettings.json file in the project directory.

The current connection string is:
"ConnectionStrings": {
    "Database": "Server=BH-DEV14\\SQL2019N;Database=LoginProject;Trusted_Connection=True;TrustServerCertificate=True;"
}

You can also use this structure:
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=YourDatabaseName;User Id=yourusername;Password=yourpassword;"
