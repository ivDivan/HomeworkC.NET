using Class08Homework.EmployeeApp.Domain.Enums;

namespace Class08Homework.EmployeeApp.Domain.Models
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Role Role { get; set; }
        protected double Salary { get; set; }

        public Employee()
        {

        }

        public Employee(string firstName, string lastName, Role role, double salary)
        {
            if(string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
            {
                throw new ArgumentNullException("Ai caramba!!! First Name or Last Name can't be empty...");
            }
            FirstName = firstName;
            LastName = lastName;
            Role = role;
            Salary = salary;
        }

        public virtual double GetSalary()
        {
            return Salary;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"{FirstName} {LastName}'s salary is {Salary}");
        }
    }
}
