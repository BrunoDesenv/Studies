using CalculateSalaryDemo.Abstraction;
using CalculateSalaryDemo.Domain;
using CalculateSalaryDemo.Implementor;
using System;

namespace CalculateSalaryDemo.RefinedAbstration
{
    public class CalculateSalary : AbstractionGenerateFile
    {
        public CalculateSalary(IGenerateFile generateFile): base(generateFile)
        {

        }

        public void ProcessSalaryEmployee(Employee employee)
        {
            employee.TotalSalary = employee.BaseSalary + employee.Incentive;

            Console.WriteLine($"Value of total of salary to the employee {employee.Id}" +
                              $": R$ {employee.TotalSalary}");

            generateFile.RecordFile(employee);
        }

    }
}
