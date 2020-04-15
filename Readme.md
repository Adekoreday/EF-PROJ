###LIST OF COMMANDS USED IN THIS PROJECT

//To start the MSSQL instance
    docker start sql1 

//to add the migration to SamuriApp.Data project setting The console app as the runtime project
    dotnet ef migrations add init -s ../ConsoleApp/ 

// to update the database with the created Migrations
dotnet ef database update --verbose -s ../ConsoleApp/