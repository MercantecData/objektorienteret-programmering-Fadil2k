using System.Collections.Generic;

namespace School
{
    public class Team
    {
        private readonly string description;
        private readonly List<Employee> Employees = new List<Employee>();
        private readonly int id;
        private readonly string name;
        private readonly List<Student> Students = new List<Student>();

        public Team(int id, string name, string description, List<Employee> Employees, List<Student> Students)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.Employees = Employees;
            this.Students = Students;
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

        //Get description
        public string getDesc()
        {
            return description;
        }

        //Add a student
        public void Add(Student student)
        {
            student.Add(this);
            Students.Add(student);
        }

        //Add a employee
        public void Add(Employee employee)
        {
            employee.Add(this);
            Employees.Add(employee);
        }

        //Remove a student
        public void Remove(Student student)
        {
            student.Remove(this);
            Students.Remove(student);
        }


        //Remove a employee
        public void Remove(Employee employee)
        {
            employee.Remove(this);
            Employees.Remove(employee);
        }

        //Find students assigned to team
        public List<Student> assignedStudents(Team team)
        {
            return team.Students;
        }

        //Find employees assigned to team
        public List<Employee> assignedEmployees(Team team)
        {
            return team.Employees;
        }
    }
}