# PotionShop

Mock Potion Shop Website

### Useful Links

-   [Jira Board](https://potionshoppe.atlassian.net/jira/software/projects/PS/boards/2)
-   [GitHub](https://github.com/devMichaelREdwards/PotionShoppe)

TODO: Write more on the Readme

Have installed ->
WSL2
Docker
Node.js
.Net 8

Dev environment info ->
Database: localhost:1433 (sqlserver if inside container)
API: localhost:7211 (api if inside container)

Creating the database
In docker container, run dotnet ef database update(figure out how to do not in docker???)

Updating the database
dotnet ef migrations add NameOfMigration
In docker container, run dotnet ef database update(figure out how to do not in docker???)

Adding a table to database
Create SQL patch file
Update install file
Add the table to docker database
DO NOT OVERWRITE Api.Data.PotionShoppeContext, Make needed changes from autogenerated files to this file then delete the autogenerated files

(The below command will autogenerate the file but also overwrite all models and context. Better way later maybe?)
dotnet ef dbcontext scaffold "Server=localhost;Database=PotionShoppe;User Id=PotionShoppe;Password=PotionPassword1!;Trusted_Connection=False;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -o Models --force

Dev Setup(This whole thing could be better...):
Clone the repo
dotnet dev-certs https -ep %USERPROFILE%\.aspnet\https\aspnetapp.pfx -p Password123! --trust

-   Database Setup
    `docker compose up -d --build sqlserver`
    In HeidiSQL ->
    Connect to localhost:1433
    user: sa
    password: Password123!
    run the create_db_user.sql file
    disconnect from the db as sa
    reconnect as:
    user: PotionShoppe
    password: potionPassword1!

-   Api Setup
    `docker compose up -d --build api`
    inside the api container on command line, run `dotnet ef database update`
    In Heidi SQL as PotionShoppe, run the data.sql in Database/install(needed) as well as .docker(optional)
    restart the api container(or save Program.cs)

-   Client Setup
    run `npm install` in client folder
    `docker compose up -d --build potionshoppe`
    inside docker command line run `npm install`
    uncomment out the command in docker-compose.yml
    stop and remove the container then rebuild it

        Everything works now
