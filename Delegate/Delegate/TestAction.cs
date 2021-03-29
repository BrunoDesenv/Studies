using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    public class TestAction
    {
        private Action testAction;
        private Action<int, float> testActionWithParameters;
        public void Start()
        {
            testAction = () =>
            {
                Console.WriteLine("Action executed with success.");
            };

            testActionWithParameters = (int total, float value) =>
            {
                float totalValue = 0;
                for (int i = 0; i < total; i++)
                {
                    totalValue += value;
                }

                Console.WriteLine(totalValue);
            };
        
            testAction();
            Console.WriteLine("Test action with parameters");
            testActionWithParameters(10, 23);
        }

    }
}
