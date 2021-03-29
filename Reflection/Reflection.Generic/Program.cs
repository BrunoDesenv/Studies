using System;
using System.Reflection;

namespace Reflection.Generic
{
    class Program
    {
        static void Main(string[] args)
        {
            DoSomething(typeof(string), "ADDRESS");
        }

        static void DoSomething(Type type, string address)
        {
            object result = null;

            Type memory = typeof(Memory);
            MethodInfo method =  memory.GetMethod(nameof(Memory.Read));
            MethodInfo genericMethodInfo = method.MakeGenericMethod(type);

            result = genericMethodInfo.Invoke(null, new object[] { address });
            
            Console.WriteLine($"Result value is: { result }");
            Console.WriteLine($"Result type is: { result?.GetType() }");
        }

        //We don't control this class
        class Memory
        {
            public static T Read<T>(string address)
            {
                var type = typeof(T);

                if (type == typeof(double))
                {
                    return ConvertType<T>(150.53);
                }

                if (type == typeof(int))
                {
                    return ConvertType<T>(237);
                }

                if (type == typeof(string))
                {
                    return ConvertType<T>("This is a string value");
                }

                if (type == typeof(bool))
                {
                    return ConvertType<T>(true);
                }
                return default(T);
            }

            private static T ConvertType<T>(object value)
            {
                return (T)(value);
            }
        }
    }
}
