20250121 

1800: Modified the h1 class display "Hi Jayaprakash Visvanathan, Welcome to St Clair College"

1805: Added the Controller in the existing HelloWorld Project "HelloWorld"

1810: Public Class Name changed as per the Project Name to create the webpage "HelloWorldController"

1813: Return value modified with the string as Index "This Webpage was created by Jayaprakash in Microsoft Visual Studio"

1820: Included the string and numTimes in the public string Welcome "public string Welcome(string name, int numTimes = 1)"

1832: Modified the return value as "return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}")"

1840: Comment the numTimes and replaced with ID "public string Welcome(string name, int ID = 1)"

1850: Return the values with the name and ID " return HtmlEncoder.Default.Encode($"Hello {name}, ID: {ID}");"

20250122 

0920: The project name is not correct as the Tutorial so that I have to create a new project with the name as MvcMovie and follow the previous steps to complete the Webpage which has been created.

0922: Replaced the h1 class display "Hi Jayaprakash Visvanathan, Welcome to St Clair College"

0940: I have included the IActionResult as the public file in the public class file HelloWorldController 

0945: Now I need to add the Razor View files with the file extension of .cshtml in the HelloWorldController class file

0950: To create a View right click on the View folder to create the HelloWorld folder then Add View then Razor View - Empty the Index.cshtml file will be created

0955: Modify the paragraph which has to be shown in the Webpage

1000: Modify the _Layout.cshtml file to the year to 2025

1010: Include the new public IActionResult Welcome with the sample content

1012: Able to check the output with the Name with 5 times

1015: Added the welcome.cshtml file under the View with HelloWorld folder

1017: Add the Scaffold movie pages under the folder Controllers using the predefined Entity Frameworks and select the Model Class and Database Provider

1022: Initial migration for the Database under the Tools then NuGet Package Manager > Package Manager Console to Migrate the Database

Add-Migration InitialCreate
Update-Database

1024: 20250122153203_InitialCreate.cs Database has been created

1025: Once the Scaffold Database has been done need to test the app

1030: Update-Database with the exception was thrown "SqlException: Cannot open database "MvcMovieContext-1" requested by the login. The login failed."

1031: Under the folder Data/MvcMovieContext.cs update the details for the database class content

1033: Create the Intial Create class with the Timestamp Migrations/20250122153203_InitialCreate.cs

20250128

1600: I have modified the Data/MvcMovieContext.cs file 

1615: Added the DB Details in the appsetting.json file as per the DB Connection "Server=(localdb)\\mssqllocaldb;Database=MvcMovieContext-3ff7190a-2149-4f61-ad60-815618459ddd;Trusted_Connection=True;MultipleActiveResultSets=true"

1620: Altered the 20250122153203_InitialCreate.cs file as required changes

1627: Modified the Controllers/MoviesController.cs file as required

1632: @model public class file has been changed

1637: return View(movie); Included in the Movies - Detail file

1645: Modified the Index.cshtml file under Movie with the IEnumerable type

1650: Altered the program.cs file with the "MvcMovieContext" for var builder

1655: Examine the database "View - SQL Server Object Explorer - MvcMovieContext - Tables - dbo.Movie - View Designer the column ID is the Primary Key

Clean started at 8:16 AM...
1>------ Clean started: Project: MvcMovie, Configuration: Debug Any CPU ------
========== Clean: 1 succeeded, 0 failed, 0 skipped ==========
========== Clean completed at 8:17 AM and took 03.324 seconds ==========

20250129

0825: Have created the Database Data with the SeedData.cs as a Class file under the folder Models

0830: Modifed the Class file with static data 

0832: Included the Class file in the base program.cs class file to reflect in the Web Applcation

0835: Can able to view the changes in the application. So Part 5 Completed

Build started at 8:38 AM...
1>------ Build started: Project: MvcMovie, Configuration: Debug Any CPU ------
1>MvcMovie -> C:\Users\DELL\source\repos\MvcMovie\MvcMovie\bin\Debug\net8.0\MvcMovie.dll
========== Build: 1 succeeded, 0 failed, 0 up-to-date, 0 skipped ==========
========== Build completed at 8:39 AM and took 25.138 seconds ==========

0845: Part 6 Modifying the Movies.cs file from the Model Folder with the ReleaseDate word as 2 words

0848: Included the two predefined functions

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

and added the below data

[Display(Name = "Release Date")]
[DataType(DataType.Date)]
[Column(TypeName = "decimal(18, 2)")]

0855: Tested the application able the view Release Date in 2 words

0900: Edited the Views/Movies/Index.cshtml file with the Edit, Details, and Delete for the Existing Data

0905: Recalling the pattern: "{controller=Home}/{action=Index}/{id?}"); program.cs file 

0908: Tested the App with this /Movies/Edit/4 working fine

