using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public class GenericClass<T>
    {
        T Owner { get; set; }
        public GenericClass(T owner) { 
            Owner = owner; 
        }
    }
}
