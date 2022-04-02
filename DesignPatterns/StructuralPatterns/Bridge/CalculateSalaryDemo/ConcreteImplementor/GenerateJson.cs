using CalculateSalaryDemo.Domain;
using CalculateSalaryDemo.Implementor;
using System;
using System.IO;
using System.Text.Json;

namespace CalculateSalaryDemo.ConcreteImplementor
{
    public class GenerateJson : IGenerateFile
    {
        private string nameFile = "SalaryEmployee.json";

        public void RecordFile(Employee employee)
        {
            var employeeSerialize = JsonSerializer.Serialize(employee);

            File.WriteAllText(nameFile, employeeSerialize);

            Console.WriteLine($"Salary to the employee: {employee.Name} " +
                              $"generated with success: {nameFile} \n");
        }
    }
}
