using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    public class Counter
    {
        public delegate void CallBack(int i);
        public void Running(CallBack callBack)
        {
            for (int i = 0; i < 10000; i++)
            {
                callBack(i);
            }
        }
    }
}
