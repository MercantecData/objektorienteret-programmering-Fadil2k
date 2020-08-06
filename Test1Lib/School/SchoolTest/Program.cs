using System;
using System.Collections.Generic;
using School;

namespace SchoolTest
{
    class Program
    {
        static void Main(string[] args)
        {


            DB db = new DB(new List<Student>(), new List<Employee>(), new List<Team>());

            db.Add("Banditterne", "Undervisning i kagesmagning");
            db.Add("Lars", 22.50m, false);

            string lars = "lars";
            Student s = db.findStudent(lars);


            Console.Write(db.assignedTeams(s));
        }
    }
}
