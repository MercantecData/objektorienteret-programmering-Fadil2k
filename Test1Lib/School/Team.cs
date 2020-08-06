using System;
using System.Collections.Generic;

namespace School
{
    public class Team
    { 
        private int id;
        private string name;
        private string description;
        public List<Employee> Employees = new List<Employee>();
        public List<Student> Students = new List<Student>();

        public Team(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
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

        //Get description
        public string getDesc()
        {
            return this.description;
        }

        //Add a student
        public void Add(Student student)
        {
            student.Add(this);
            Students.Add(student);
        }

        //Remove a student
        public void Remove(Student student)
        {
            student.Remove(this);
            Students.Remove(student);
        }

        //Add a employee
        public void Add(Employee employee)
        {
            employee.Add(this);
            Employees.Add(employee);
        }

        //Remove a employee
        public void Remove(Employee employee)
        {
            employee.Remove(this);
            Employees.Remove(employee);
        }
    }
}
