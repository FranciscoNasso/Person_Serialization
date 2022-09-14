using System;
using System.Text.Json;

namespace Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Diego", "Lugano");
            Console.WriteLine(person.ConvertToJson());

            Person person1 = new Person("{\"Name\":\"Diego\",\"FamilyName\":\"Godín\"}");
            Console.WriteLine(person.ConvertToJson());
        }
    }
}