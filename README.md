dotnet new webapp -o MyWebApp --no-https
cd MyWebApp

dotnet watch

dotnet new webapp -o RazorPagesSports
code -r RazorPagesSports

dotnet dev-certs https –trust
dotnet tool install --global dotnet-ef
dotnet tool install --global dotnet-aspnet-codegenerator
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Microsoft.EntityFrameworkCore.SQLite
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer
dotnet-aspnet-codegenerator razorpage -h
dotnet-aspnet-codegenerator razorpage -m Sports -dc RazorPagesMovContext -udl -outDir Pages/Movies --referenceScriptLibraries -sqlite



dotnet ef migrations add InitialCreate
dotnet ef database update

