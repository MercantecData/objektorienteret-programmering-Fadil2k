using System.Collections.Generic;

namespace School
{
    public class Student
    {
        private readonly int id;

        private readonly List<Team> teamsAssigned = new List<Team>();
        private int age;
        private string name;

        public Student(int id, string name, int age, List<Team> teamsAssigned)
        {
            this.id = id;
            this.name = name;
            this.age = age;
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

        //Get age
        public int getAge()
        {
            return age;
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

        //Edit age
        public void Edit(int age)
        {
            this.age = age;
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