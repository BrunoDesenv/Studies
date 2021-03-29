using System;

namespace Delegate
{
    class Program
    {

        static void Main(string[] args)
        {
            TestDelegate testDelegate = new TestDelegate();
            testDelegate.Start();

            Counter counter = new Counter();
            counter.Running(CallBack);

            TestAction testAction = new TestAction();
            testAction.Start();
        }


        static void CallBack(int i)
        {
            Console.WriteLine(i);
        }
    }
}
