using System;
using System.Collections.Generic;
using System.Text;

namespace Reflection
{
    public class MyClass
    {
        public GenericClass<MyClass> myGenericObject;
        public MyClass()
        {
            myGenericObject = new GenericClass<MyClass>(this);
        }
    }
}
