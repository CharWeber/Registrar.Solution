# Registrar

A University registrar that tracks departments, courses, and students.

### by Charlie Weber, Ben Wilson, and Anna Clarke

## Technologies Used

* _C#_
* _ASP.NET Core MVC_
* _.NET 5_
* _NuGet_
* _Microsoft.EntityFrameworkCore_
* _Dotnet EntityFramework Tool_
* _Microsoft.EntityFrameworkCore.Design_


## Description
This web application will allow the user to create departments, courses, and students. The user will be able to add courses to departments, add students to courses, and add students to departments. All models have full CRUD functionality. There are three many to many relationships. User has the ability to mark a course as complete and check if a department has no completed courses.


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
* _open new terminal and run SQL 

        $ mysql -uroot -p{your_password})_
* _open MySQL Workbench_
* _In terminal, navigate into Registrar.Solution/Registrar/ and enter the command $ dotnet restore, to install necessary packages_
* _enter this command to build the program

       $ dotnet build to build program_
* _enter command to build your database_

        $ dotnet ef database update,
* _check MySql Workbench to make sure the registrars database has been built_
* _enter command $ dotnet run, to view program in your browser_

  

## Known Bugs

* _NA_

## License
_[GPL](https://opensource.org/licenses/gpl-license)_

## Contact Information

Anna Clarke: <anclarkie@gmail.com>  
Ben Wilson: <benjaminw1030@gmail.com>  
Charles Weber <charlesweber@gmail.com>

## Photos
Photo by <a href="https://unsplash.com/@willvanw?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText">Will van Wingerden</a> on <a href="https://unsplash.com/s/photos/library?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText">Unsplash</a>

Photo by <a href="https://unsplash.com/@mrthetrain?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText">Joshua Hoehne</a> on <a href="https://unsplash.com/s/photos/graduation?utm_source=unsplash&utm_medium=referral&utm_content=creditCopyText">Unsplash</a>