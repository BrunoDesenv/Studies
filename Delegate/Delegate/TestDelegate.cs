using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    class TestDelegate
    {
        public delegate void Test();
        private Test testDelegate;

        public void Start()
        {
            Console.WriteLine("Add the method in delegate.");
            testDelegate = MyTestDelegation;
            testDelegate += MySecondTestDelegation;
            testDelegate();

            Console.WriteLine("Removing the method in deledate.");
            testDelegate -= MyTestDelegation;
            testDelegate();
            testDelegate -= MySecondTestDelegation;

            Console.WriteLine("Executing a anonymous method.");
            testDelegate = delegate { Console.WriteLine("Anonymous method works."); };

            Console.WriteLine("Executing with Lambda.");
            testDelegate = () =>  Console.WriteLine("Anonymous method works.");
        }

        public static void MyTestDelegation()
        {
            Console.WriteLine("My first test executed with success.");
        }

        public static void MySecondTestDelegation()
        {
            Console.WriteLine("My second test executed with success.");
        }

    }
}
