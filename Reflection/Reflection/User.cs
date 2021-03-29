namespace Reflection
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }
        public User(string name, string lastName, string age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
        }
        public string GetFullName()
        {
            return Name + " " + LastName;
        }
    }
}
