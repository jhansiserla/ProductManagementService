# ProductManagementService

1. Tools Used to develop API : Visual studio 2017, ASP.NET CORE 2.2
2. For API documentation, added swagger support
3. Tested all HTTP actions provided in tests.postman and all of them are successfull
4. For Database used SQL Server Management studio 18 and in service made use of EntityFramework.
5. Connection string to database(OnlineMarketing) was configured in appsettings.json
6. For entity framework to automatically create database and table please run below commands one after another in package manager console
   1. Add-Migration
      Once we type in above command it will propmt to enter name, give some name for e.g. initial migration
   2. Once above command runs successfully type another command Update-Database
   3. After executing above command, Products table will be created automatically in database OnlineMarketing.
7. Then we can cheeck for sample tests in tests.postman
 
 
