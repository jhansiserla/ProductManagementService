# ProductManagementService

1. Tools Used to develop API : Visual studio 2017, ASP.NET CORE 2.2
2. For API documentation, added swagger support
3. Tested all HTTP actions provided in tests.postman and all of them are successfull
4. For Database used SQL Server Management studio 18 and in service made use of EntityFramework.
5. Connection string to database(OnlineMarketing) was configured in appsettings.json
6. Below is the query to CREATE TABLE in database(OnlineMarketing)

 CREATE TABLE [Products] (
          [Productcode] int NOT NULL IDENTITY,
          [Name] nvarchar(max) NOT NULL,
          [Price] decimal(18,2) NOT NULL,
          CONSTRAINT [PK_Products] PRIMARY KEY ([Productcode])
      );
      
 7. 
 
 
