# PierresTreat's.Solution

### By Tom/Usarneme


A C#/MVC/MySQL app which shows connections between Treats and Flavors in Pierre's Bakery. Includes accounts via Identity Framework. Registered users may Create, Update, and Delete both Flavors and Treats as well as create and delete associations between the two. Everyone may view all Flavors, Treats, and associations.

---

## Technologies Used

1. C#
2. .NET
3. ASP .NET Core
4. Entity Framework
5. MySQL
6. JavaScript
7. Razor Templates
8. HTML5/CSS3
9. Identity Framework for Auth(entication/orization)

---


### Requirements

1. C#/.NET - packages and instructions for installation for your OS are available at [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)
2. MySql installed and running - [instructions available here](https://dev.mysql.com/doc/mysql-installation-excerpt/5.7/en/)
3. Entity Framework CLI for creating the Database from the included migrations files: `dotnet tool install --global dotnet-ef`
4. A web browser of your choice, such as [Firefox](https://www.mozilla.org/en-US/firefox/new/)

---

### Installation Instructions

1. Clone this repository `git clone https://github.com/Usarneme/PierresTreats.Solution`
2. Enter the project directory `cd PierresTreats.Solution/PierresTreats/`
3. Install dependencies with `dotnet restore`
4. Create a file called appsettings.json that contains your connection string for your MySql installation; `touch appsettings.json` then, for example, `nano appsettings.json` and then paste the following into this file:
> {
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=[DB SCHEMA NAME];uid=[DB USER];pwd=[DB PASSWORD];"
  },
  "AllowedHosts": "*"
}

NOTE: [DB SCHEMA NAME], [DB USER] and [DB PASSWORD] will of course need to be replaced with your chosen db schema name, user name, and password for MySql

5. Create the database via EntityFrameWork migrations tool `dotnet ef database update`
6. Start the web server with `dotnet run`
7. Visit the website in your browser of choice (see console for details), typically at http://localhost:5000/

NOTE: If you have trouble accessing the website it is likely because your browser is warning you about an invalid SSL certificate. This project redirects you to an HTTPS site at port 5001 by default. Please check your browser's website for instructions on bypassing this warning; for example in Firefox you must Click on the Advanced button and then the "I understand the risks, take me to the site" link that will appear below the warning text. This app uses the default C# SSL certificate because this is a learning project; were it hosted on a real website it would require a real SSL cert to comply with browser security requirements.

---

### License

GPLv3 - No Copyright

---

### Bugs

No known issues at this time. Please submit a pull request/add to the issue tracker above if you find something out of place.

Thanks!