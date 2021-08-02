using System;
using DesignPattern;
using static System.Console;
namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Builder Pattern
            // WriteLine("Please enter list of columns to select in comma seperated");
            // var colName = ReadLine();
            // WriteLine("Please enter a table from where you would like to fetch data");
            // var tableName = ReadLine();
            // WriteLine("If there is any condition that you would like to mention");
            // var condition = ReadLine();
            // var finalQuery = new SQLBuilder().AddSelect(colName).AddTable(tableName).AddCondition(condition).Build();
            // WriteLine(finalQuery);
            # endregion
            #region Factory Pattern
            //Code for Factory Pattern
            // var person = PersonFactory.CreatePerson("Vinoth");
            // Console.WriteLine($"Id : {person.Id} and Name : {person.Name}");
            // var person1 = PersonFactory.CreatePerson("Lavanya");
            // Console.WriteLine($"Id : {person1.Id} and Name : {person1.Name}");
            // var person2 = PersonFactory.CreatePerson("Suresh");
            // Console.WriteLine($"Id : {person2.Id} and Name : {person2.Name}");
            // var person3 = PersonFactory.CreatePerson("Suganthi");
            // Console.WriteLine($"Id : {person3.Id} and Name : {person3.Name}");
            #endregion
            WriteLine("Hello World!");
        }
    }
}
