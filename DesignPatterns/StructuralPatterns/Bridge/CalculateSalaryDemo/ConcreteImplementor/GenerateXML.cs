using CalculateSalaryDemo.Domain;
using System;
using System.IO;
using System.Xml.Serialization;

namespace CalculateSalaryDemo.ConcreteImplementor
{
    public class GenerateXML
    {
        private string nameFile = "SalaryEmployee.json";
        private XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
        private FileStream fileStream { get; set; }

        public void RecordFile(Employee employee)
        {
            fileStream = new FileStream(nameFile, FileMode.OpenOrCreate);

            xmlSerializer.Serialize(fileStream, employee);

            Console.WriteLine($"Salary to the employee: {employee.Name} " +
                              $"generated with success: {nameFile} \n");
        }
    }
}
