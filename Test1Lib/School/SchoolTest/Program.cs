using System;
using System.Collections.Generic;
using School;

namespace SchoolTest
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var db = new DB("Bandit skolen", new List<Student>(), new List<Employee>(), new List<Team>());

            db.Add("Banditterne", "Undervisning i kagesmagning");
            db.Add("benny", 22.50m, false);
            db.Add("Lars", 12);


            var s = db.findStudent("Lars");
            var e = db.findEmployee("benny");

            Console.WriteLine(e.getName());
        }
    }
}