# Loadout Builder

A project for creation and configuration of gaming loadouts.

## Technologies Used

- **ASP.NET Core** - Open-source framework used for building the app.
- **Entity Framework 8** - Object-Relational Mapper that maps the C# classes to relational database tables.
- **AutoMapper** - Open-source library used for mapping the model objects to viewmodels used for the views.

## Setup

1. Clone the repository.
2. Navigate to the main project folder:
   ```bash
   cd LoadoutBuilder
   ```
3. Build the project and dependencies:
   ```bash
   dotnet builds
   ```
4. Set the user secrets configuration used for connection to the database server:
   ```bash
   dotnet user-secrets set "ConnectionStrings:AppDbContext" "Data Source=<Server_name>;Database=MyDatabase;TrustServerCertificate=True;Integrated Security=True;"
   ```
5. Run the project:
   ```bash
   dotnet run
   ```
6. Using the browser, navigate to `http://localhost:<app_port>`.
