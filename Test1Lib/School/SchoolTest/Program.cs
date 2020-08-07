using System;
using System.Collections.Generic;
using School;

namespace SchoolTest
{
    class Program
    {
        static void Main(string[] args)
        {


            DB db = new DB("Bandit skolen", new List<Student>(), new List<Employee>(), new List<Team>());

            db.Add("Banditterne", "Undervisning i kagesmagning");
            db.Add("benny", 22.50m, false);
            db.Add("Lars", 12);

      
            Student s = db.findStudent("Lars");


            
        }
    }
}
