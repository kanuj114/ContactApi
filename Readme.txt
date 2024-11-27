Core WebApi :-
*************
We are creating the Architecture of the project :-
****************************************************
1. Fluent API Pattern. 
Ans. a) It is Primarily meant for applying in Code first Approach.
     b) It provides list of classes and method to define the well formedness of any table.
     c)  
2. Fluent Model Validation.
3. Exception Handling.
4. Code First/DB First [Code First Preferable for Interview].
5. Architecture of IOC [Inversion Of Control].
6. Dependency Injection.
7. Instance Management.
   a)Per Call
   b)Per Session
   c)Singleton  
8. Attribute Routing
9. How to Deploy .netCore Application on Azure**.
10. Have yo implemented Extension Method in .NetCore.   
11. Dynamic Migration
12. DTO**[Data Transfer Object]
13. Automapper**
14. TPL [Task Parallel Library]
 
 public interface IContactsOperation
    {
        int Add (Contacts Item);
        List<Contacts>GetAll();
        Contacts Find(string key);
        int Remove(string Id);
        int Update(Contacts Item);
        bool CheckValidUserKey(string reqkey);
    }   //Above Code are Poor Approach : Not recommended on project level. apply TPL here


    1. Working on Models to define entities.
    2. We should not add any extra notation while defining the entities which can break 
       down the SRP(Single Responsibility Principle).
-------------------------------------------------------------------------------------------------------
 We are implementing Fluent API Pattern to define the schema of the table in code first approach.     
 Finally, we have define the Mapper for context class.
 a) Contacts
 b) ContactMapper

 Remark : Now we need to associate Contacts with ContactMapper, So that when we apply Migration table
 -------  will be created with proper structure.
 Solution :- We have DbContext Class and we need to override OnModelCreating() function 

 Agenda :- 
 *******
 Practical implementation of IOC and Dependency Injection. // Most asked question on Interview

 -> Steps of implementing IOC and DI on .NetCore 8.0 
 1) Remove the OnConfiguring() function from ContactsDbContext class.
 2) Register the ContactsDbContext class in program.cs file with the help of builder.Services Object.[Especially in 8.0 version]
 3) Now apply constructor chaining in ContactsDbContext class**.
 4) Provide the connection string in appsettings.json File.

 Remark:- We are not going to create an object of ContactsDbContext class by new() operator to be said Tight Coupling.
 ********
 Afterall Benefits:- 
 *********************
 1) Loose Coupling
 2) Improved memory Management
 3) Improved Performance or Health Monitoring

 Topic:-
 *******
 Instance Management
 1) Per Call
 2) Per Session
 3) Singleton

 1) Need to implement Fluent Model.
 2) Authentication/Authorization known as security by custom middleware.
 3) Extension Method**.
 4) Need to deploy CoreWebApi application on Azure and ensures that use Azure SQL database**.


Need to apply Fluent model validation





    