using Class08Homework.EmployeeApp.Domain.Enums;
namespace Class08Homework.EmployeeApp.Domain.Models
{
    public class Contractor : Employee
    {
        private int _workHours {  get; set; }
        private double _payPerHour { get; set; }
        public Manager Responsible { get; set; }

        public Contractor()
        {
            Salary = 0;
            Role = Role.Other;
        }

        public Contractor(string firstName, string lastName, int workHours, double payPerHour, Manager responsible) : base(firstName, lastName, Role.Other, 0)
        {
            _workHours = workHours;
            _payPerHour = payPerHour;
            Responsible = responsible;
        }

        public override double GetSalary()
        {
            Salary = _workHours * _payPerHour;
            return Salary;
        }

        public string CurrentPosition()
        {
            return Responsible.Role.ToString();
        }
    }
}
