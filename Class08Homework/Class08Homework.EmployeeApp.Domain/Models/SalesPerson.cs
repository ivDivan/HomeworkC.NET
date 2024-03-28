using Class08Homework.EmployeeApp.Domain.Enums;
namespace Class08Homework.EmployeeApp.Domain.Models

{
    public class SalesPerson : Employee
    {
        private double _successSaleRevenue {  get; set; }

        public SalesPerson()
        {
            Salary = 500;
            Role = Role.Sales;
        }

        public SalesPerson(string firstName, string lastName, double revenue) : base(firstName, lastName, Role.Sales, 500)
        {
            _successSaleRevenue = revenue;
        }

        public void AddSuccessSalerevenue(double successSaleRevenue)
        {
            _successSaleRevenue += successSaleRevenue;
        }

        public override double GetSalary()
        {
           if (_successSaleRevenue <= 2000)
            {
                Salary = Salary + 500;
                return Salary;
            }
           else if(_successSaleRevenue > 2000 &&  _successSaleRevenue <= 5000)
            {
                Salary = Salary + 1000;
                return Salary;
            }
            else
            {
                Salary = Salary + 1500;
                return Salary;
            }
        }
    }
}
