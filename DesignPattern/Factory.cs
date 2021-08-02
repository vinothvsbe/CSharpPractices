using System;
using System.Collections.Generic;
namespace DesignPattern
{
    /*
    * Factory class helps in creating multiple types of same object.
    * Best example is creating Pizza with different types
    */
    public class Person
    {
        public int Id { get; set; } 
        public string Name { get; set; }

        public Person(int id , string name)
        {
            Id = id;
            Name = name;
        }
    }

    public static class PersonFactory{
        private static int latestId = 0;
        public static Person CreatePerson(string name)
        {
            var person = new Person(latestId,name);
            latestId++;
            return person;
        }
    }
}