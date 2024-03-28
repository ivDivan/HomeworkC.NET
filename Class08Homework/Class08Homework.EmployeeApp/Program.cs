using Class08Homework.EmployeeApp.Domain.Models;

Manager manager1 = new Manager("Mile", "Kitic", 500);
Manager manager2 = new Manager("Masinka", "Lukic", 750);
SalesPerson salesPerson = new SalesPerson("Bajo", "Roganovic", 7500);
Contractor contractor1 = new Contractor("Jasar", "Ahmedovski", 20, 350, manager1);
Contractor contractor2 = new Contractor("Ipce", "Ahmedovski", 24, 400, manager2);
CEO ceo = new CEO("Haris", "Dzinovic", 1000, new Employee[] { manager1, manager2, salesPerson, contractor1, contractor2 }, 10);


ceo.AddSharesPrice(250);
ceo.GetSalary();
ceo.PrintInfo();
ceo.PrintEmployees();