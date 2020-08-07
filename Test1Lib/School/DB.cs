using System;
using System.Collections.Generic;

namespace School
{
    public class DB
    {
        private string schoolName;

        //Student list
        private List<Student> Students = new List<Student>();
        private int StudentID; //Auto increment

        //Employee list
        private List<Employee> Employees = new List<Employee>();
        private int EmployeeID; //Auto increment

        //Teams list
        private List<Team> Teams = new List<Team>();
        private int TeamID; //Auto increment

        public DB(string schoolName, List<Student> Students, List<Employee> Employees, List<Team> Teams)
        {
            this.schoolName = schoolName;
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

        //Add new team
        public void Add(string name, string description)
        {
            Team team = new Team(TeamID, name, description, new List<Employee>(), new List<Student>());
            Teams.Add(team);

            TeamID++;
        }


        //Remove student
        public void Remove(Student student)
        {
            Students.Remove(student);
        }

        //Remove employee
        public void Remove(Employee employee)
        {
            Employees.Remove(employee);
        }

        //Remove team
        public void Remove(Team team)
        {
            Teams.Remove(team);
        }

        //List all students
        public List<Student> listStudents()
        {
            return Students;
        }


        //List all employees
        public List<Employee> listEmployees()
        {
            return Employees;
        }

        //List all teams
        public List<Team> listTeams()
        {
            return Teams;
        }

        //List assigned students in specific team
        public List<Student> assignedStudents(Team team)
        {
            return team.assignedStudents(team);
        }

        //List assigned students in specific team
        public List<Employee> assignedEmployees(Team team)
        {
            return team.assignedEmployees(team);
        }
        //Find specific student
        public Student findStudent(string studentName)
        {
            foreach (var student in Students)
            {
                
                string name;
                name = student.getName();
                if (name == studentName)
                {

                    return student;
                    
                }
                
            }
            return null;
        }

        //Find specific employee
        public Employee findEmployee(string empName)
        {
            foreach (var employee in Employees)
            {

                string name;
                name = employee.getName();
                if (name == empName)
                {

                    return employee;

                }

            }
            return null;
        }

        //Find specific team
        public Team findTeam(string teamName)
        {
            foreach (var team in Teams)
            {

                string name;
                name = team.getName();
                if (name == teamName)
                {

                    return team;

                }

            }
            return null;
        }

        //Get paid status of employee salary
        public bool checkPay(string empName)
        {
             Employee employee = findEmployee(empName);
             return employee.getPaid();
        }

        //Find assigned teams for employee
        public List<Team> assignedTeams(Employee employee)
        {
            return employee.getTeams();
        }

        //Find assigned teams for student
        public List<Team> assignedTeams(Student student)
        {
            return student.getTeams();
        }

        //Find number for enrolled students
        public int studentCount()
        {
            return StudentID;
        }

        //Find number for employees hired
        public int employeeCount()
        {
            return EmployeeID;
        }



    }
}

