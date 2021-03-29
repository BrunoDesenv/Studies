using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Type.GetType("Reflection.User");
            Console.WriteLine(type);

            ConstructorInfo[] constructors = type.GetConstructors();
            Console.WriteLine("Getting the constructor");
            foreach (var constructor in constructors)
            {
                Console.WriteLine(constructor.Name);
            }

            Console.WriteLine();
            MethodInfo[] methods = type.GetMethods();
            Console.WriteLine("Getting the methods of class.");
            foreach (var method in methods)
            {
                Console.WriteLine(method.Name);
            }

            Console.WriteLine();
            PropertyInfo[] properties = type.GetProperties();
            Console.WriteLine("Getting the properties of class.");
            foreach (var property in properties)
            {
                Console.WriteLine("Type: {0}, Name: {1}", property.PropertyType.Name, property.Name);
            }

            Console.WriteLine();

            var myObject = new MyClass();
            Type typeGeneric = typeof(GenericClass<>);
            Type constructed = typeGeneric.MakeGenericType(typeof(MyClass));

            var myGenericObject = Activator.CreateInstance(constructed, myObject);
            Console.WriteLine("Instantiate a generic class using reflection.");
            Console.WriteLine(myGenericObject.GetType());
        }
    }
}
