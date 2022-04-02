namespace CalculateSalaryDemo.Domain
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal BaseSalary { get; set; }
        public decimal Incentive { get; set; }
        public decimal TotalSalary { get; set; }
    }
}
