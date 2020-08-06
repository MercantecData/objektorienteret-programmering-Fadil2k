using System;
using System.Collections.Generic;

namespace School
{
    public class Student
    {
        private int id;
        private string name;
        private int age;

        private List<Team> teamsAssigned = new List<Team>();

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
            return this.id;
        }

        //Get name
        public string getName()
        {
            return this.name;
        }

        //Get age
        public int getAge()
        {
            return this.age;
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

    }
}
