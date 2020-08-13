using System;
using System.Collections.Generic;

namespace Test1Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            //Opgave 1
            Console.WriteLine("Opgave 1 Output");
            AbstractClass AC;

            AC = new Abstract1();

            AC.AbstractMethod();

            AC = new Abstract2();

            AC.AbstractMethod();

            AC = new Abstract3();

            AC.AbstractMethod();
            Console.WriteLine("-----------------");
            //

            //Opgave 2
            Console.WriteLine("Opgave 2 Output");


            Console.WriteLine("-----------------");
            //

            //Opgave 3
            Console.WriteLine("Opgave 3 Output");
            List<Person> Persons = new List<Person>();

            Persons.Add(new Person("Lars", 22, Person.Gender.Male));
            Persons.Add(new Person("Bente", 52, Person.Gender.Female));
            Persons.Add(new Person("Lisbeth", 27, Person.Gender.Female));
            Persons.Add(new Person("Carsten", 17, Person.Gender.Male));

            Persons.Sort();
            Persons.ForEach(Person => Console.WriteLine(Person));


            Console.WriteLine("-----------------");
            //
        }
    }
}
