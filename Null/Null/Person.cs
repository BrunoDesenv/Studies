namespace Null
{
    public class Person
    {
        public Detail Details { get; set; }
    }

#nullable enable
    public class Detail
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
    }
}
