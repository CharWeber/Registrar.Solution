# Registrarararara

### by charlie ben and Anna Clarke

<p align="center">
  <img src="/">  
</p>

## Technologies Used

* _C#_
* _ASP.NET Core MVC_
* _.NET 5_
* _NuGet_
* _Microsoft.EntityFrameworkCore_
* _Dotnet EntityFramework Tool_
* _Microsoft.EntityFrameworkCore.Design_


## Description

This web application will allow users to create horror subgenres to organize their horror movie watch list. They can then add movies to each subgenre, giving each one a rating, number of stars, release year etc. Users can edit movies and search for a movie by title.

### Technology Requirements

* [.NET 5](https://dotnet.microsoft.com/download/dotnet/5.0)
* A text editor like [VS Code](https://code.visualstudio.com/)

## Setup/Installation Requirements

* _Clone this repository to your desktop_
* _Open in text editor_
* _Create appsettings.json in /Registrar/ directory_
* _Copy this code into appsettings.json, replacing YOUR_PASSWORD with your MySQL password:_
```
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=registrar;uid=root;pwd=YOUR_PASSWORD;"
  }
}
```
* _
* _open new terminal and run SQL ($ mysql -uroot -p{your_password})_
* _open MySQL Workbench_
* _In terminal, navigate into Registrar.Solution/Registrar/ and enter the command $ dotnet restore, to install necessary packages_
* _enter command $ dotnet build, to build program_
* _enter command $ dotnet run, to view program in your browser_

  

## Known Bugs

* _NA_

## License
_[GPL](https://opensource.org/licenses/gpl-license)_

## Contact Information