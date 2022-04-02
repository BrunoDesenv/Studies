using CalculateSalaryDemo.ConcreteImplementor;
using CalculateSalaryDemo.Domain;
using CalculateSalaryDemo.RefinedAbstration;
using System;

namespace CalculateSalaryDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculateSalary calculateSalary = new CalculateSalary(new GenerateXML);

            Employee employee = new Employee
            {
                Id = 101,
                Name = "Bruno",
                BaseSalary = 3000,
                Incentive = 2000
            };

            calculateSalary.ProcessSalaryEmployee(employee);

            employee.Incentive = 2500;

            calculateSalary = new CalculateSalary(new GenerateJson());

            calculateSalary.ProcessSalaryEmployee(employee);

            Console.ReadKey();
        }
    }
}
