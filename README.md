# ProductManagementService

1. Tools Used to develop API : Visual studio 2017, ASP.NET CORE 2.2
2. For API documentation, added swagger support
3. Tested all HTTP actions provided in tests.postman and all of them are successfull
4. For Database used SQL Server Management studio 18 and in service made use of EntityFramework.
5. Connection string to database(OnlineMarketing) was configured in appsettings.json
6. For entity framework to automatically create database and table in SQL Server please run below commands one after another in package manager console(we can find this in Tools tab->Nuget Package Manager -> Package Manager Console) in Visual Studio.
   1. Command - 'Add-Migration'
      Once we type in above command it will propmt to enter name, give some name for e.g. initial migration
   2. Once above command runs successfully type another Command 'Update-Database'
   3. After executing above command, Products table and database OnlineMarketing will be created automatically in SQL server
7. Then we can cheeck for sample tests in tests.postman

 
