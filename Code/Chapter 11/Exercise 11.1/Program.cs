using System;
using static System.Console;

namespace Exercise___11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("1.) What type would you use for the property that represents a table, for");
            WriteLine("example, the Products property of a database context?");
            WriteLine("DbSet<Product>");
            WriteLine();
            WriteLine("2.) What type would you use for the property that represents a one-to-");
            WriteLine("many relationship, for example, the Products property of a Category entity?");
            WriteLine("Navigation property for related rows.");
            WriteLine("public virtual ICollection<Product> Products");
            WriteLine("this.Products = new HashSet<Product>();");
            WriteLine();
            WriteLine("3.) What is the EF Core convention for primary keys?");
            WriteLine("EF Core will create the primary key column for the property named Id or <Entity Class Name>Id (case insensitive).");
            WriteLine();
            WriteLine("4.) When would you use an annotation attribute in an entity class?");
            WriteLine("Used to override default conventions in EF Core. They only provide a subset of configuration options. Fluent API provides a full set.");
            WriteLine();
            WriteLine("5.) Why might you choose the Fluent API in preference to annotation attributes?");
            WriteLine("Same reason as the answer to 4.), but also, to keep the code less cluttered with annotations.");
            WriteLine();
            WriteLine("6.) What does a transaction isolation level of Serializable mean?");
            WriteLine("Applies key-range locks to prevent any action that would affect the results, including inserts and deletes. Integrity problems allowed = none.");
            WriteLine();
            WriteLine("7.) What does the DbContext.SaveChanges() method return?");
            WriteLine("The number of state entries written to the database.");
            WriteLine();
            WriteLine("8.) What is the difference between eager loading and explicit loading?");
            WriteLine("Eager loading = all entities are loaded at once.");
            WriteLine("Explicit loading =  Load the entity at that point in code.");
            WriteLine();
            WriteLine("9.) How should you define an EF Core entity class to match the following table?");
            WriteLine("CREATE TABLE Employees(");
            WriteLine("\tEmpID INT IDENTITY,");
            WriteLine("\tFirstName NVARCHAR(40) NOT NULL,");
            WriteLine("\tSalary Money");
            WriteLine(")");
            WriteLine();
            WriteLine("public class Employee");
            WriteLine("{");
            WriteLine("\tpublic int EmpID { get; set; }");
            WriteLine("\t[Required]");
            WriteLine("\t[StringLength(40)]");
            WriteLine("\tpublic string FirstName { get; set; }");
            WriteLine("\t[Column(\"Salary\", TypeName =\"Money\")]");
            WriteLine("}");
            WriteLine();
            WriteLine("10.) What benefit do you get from declaring entity navigation properties as virtual?");
            WriteLine("EF will, at runtime, create a new class (dynamic proxy) dervied from your class and uses it instead of your original class.");
            WriteLine("This new dynamically created class contains logic to load the navigation property when accessed for the first time.");
            WriteLine("This is referred to as lazy loading. It enables EF to avoid loading an entire tree of dependent objects which are not needed from the database");
        }
    }
}
