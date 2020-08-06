using System;
using System.Collections.Generic;

namespace School
{
    public class Employee
    {
        private int id;
        private string name;
        private decimal salary;
        private bool paid;

        private List<Team> teamsAssigned = new List<Team>();

        public Employee(int id, string name, decimal salary, bool paid, List<Team> teamsAssigned)
        {
            this.id = id;
            this.name = name;
            this.salary = salary;
            this.paid = paid;
            this.teamsAssigned = teamsAssigned;
        }

        //Edit name
        public void Edit(string name)
        {
            this.name = name;
        }
        //Edit salary
        public void edit(decimal salary)
        {
            this.salary = salary;
        }
        //Edit if the employee have been paid
        public void Edit(bool paid)
        {
            this.paid = paid;
        }
        // Return the list of assigned teams
        public List<Team> assignedTeams()
        {
            return teamsAssigned;
        }


    }
}
