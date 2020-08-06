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

        //Get ID
        public int getID()
        {
            return this.id;
        }

        //Get name
        public string getName()
        {
            return this.name;
        }

        //Get salary
        public decimal getSalary()
        {
            return this.salary;
        }

        //Get paid status
        public bool getPaid()
        {
            return this.paid;
        }

        // Get assigned teams
        public List<Team> getTeams()
        {
            return teamsAssigned;
        }

        //Edit name
        public void Edit(string name)
        {
            this.name = name;
        }
        //Edit salary
        public void Edit(decimal salary)
        {
            this.salary = salary;
        }
        //Edit if the employee have been paid
        public void Edit(bool paid)
        {
            this.paid = paid;
        }

        //Add team
        public void Add(Team team)
        {
            this.teamsAssigned.Add(team);
        }

        //Remove team
        public void Remove(Team team)
        {
            this.teamsAssigned.Remove(team);
        }


    }
}
