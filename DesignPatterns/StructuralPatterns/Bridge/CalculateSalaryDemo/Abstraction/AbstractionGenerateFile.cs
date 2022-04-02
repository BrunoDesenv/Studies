using CalculateSalaryDemo.Domain;
using CalculateSalaryDemo.Implementor;

namespace CalculateSalaryDemo.Abstraction
{
    public abstract class AbstractionGenerateFile
    {
        protected IGenerateFile generateFile { get; set; }

        protected AbstractionGenerateFile(IGenerateFile generateFile)
        {
            this.generateFile = generateFile;
        }

        public virtual void GenerateFile(Employee employee)
        {
            generateFile.RecordFile(employee);
        }
    }
}
