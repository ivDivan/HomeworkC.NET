using Class08Homework.EmployeeApp.Domain.Enums;
namespace Class08Homework.EmployeeApp.Domain.Models
{
    public class CEO : Employee
    {
        public Employee[] Employees { get; set; }
        private int _shares { get; set; }
        private double _sharesPrice { get; set; }       

        public CEO()
        {
            Role = Role.Manager;
        }

        public CEO(string firstName, string lastName, double salary, Employee[] employees, int shares) : base(firstName, lastName, Role.Manager, salary)
        {
            Employees = employees;
            _shares = shares;
            _sharesPrice = 0;
        }

        public void AddSharesPrice(double sharesPrice)
        {
            _sharesPrice = sharesPrice;
        }

        public override double GetSalary()
        {
            Salary = Salary + _shares * _sharesPrice;
            return Salary;
        }

        public void PrintEmployees()
        {
            Console.WriteLine("Employees:");
            foreach (Employee employee in Employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}");
            }
        }
    }
}
