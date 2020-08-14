using System.Collections.Generic;

namespace School
{
    public class Employee
    {
        private readonly int id;

        private readonly List<Team> teamsAssigned = new List<Team>();
        private string name;
        private bool paid;
        private decimal salary;

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
            return id;
        }

        //Get name
        public string getName()
        {
            return name;
        }

        //Get salary
        public decimal getSalary()
        {
            return salary;
        }

        //Get paid status
        public bool getPaid()
        {
            return paid;
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
            teamsAssigned.Add(team);
        }

        //Remove team
        public void Remove(Team team)
        {
            teamsAssigned.Remove(team);
        }
    }
}