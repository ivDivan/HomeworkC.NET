using Class08Homework.EmployeeApp.Domain.Enums;

namespace Class08Homework.EmployeeApp.Domain.Models
{
    public class Manager : Employee
    {
        private double _bonus {  get; set; }

        public Manager()
        {
            _bonus = 0;
            Role = Role.Manager;
        }

        public Manager(string firstName,  string lastName, double salary) : base(firstName, lastName, Role.Manager, salary)
        {
            _bonus = 0;
        }

        public void AddBonus(double bonus)
        {
            _bonus += bonus;
        }

        public override double GetSalary()
        {
            Salary = Salary + _bonus;
            return Salary;
        }
    }
}
