using System;
using System.Collections.Generic;

namespace School
{
    public class DB
    {
        //Student list
        private List<Student> Students = new List<Student>();
        private int StudentID; //Auto increment

        //Employee list
        private List<Employee> Employees = new List<Employee>();
        private int EmployeeID; //Auto increment

        //Teams list
        private List<Team> Teams = new List<Team>();
        private int TeamID; //Auto increment

        public DB(List<Student> Students, List<Employee> Employees, List<Team> Teams)
        {
            this.Students = Students;
            this.Employees = Employees;
            this.Teams = Teams;
        }

        //Add new student
        public void Add(string name, int age)
        {
            Student student = new Student(StudentID, name, age, new List<Team>());
            Students.Add(student);

            StudentID++;
        }
        //Add new employee
        public void Add(string name, decimal salary, bool paid)
        {
            Employee employee = new Employee(EmployeeID, name, salary, paid, new List<Team>());
            Employees.Add(employee);

            EmployeeID++;
        }
    }
}
