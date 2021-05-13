using System;
using System.Collections.Generic;
using System.Text;

namespace Dispose
{
    public class DisposableTest : IDisposable
    {
        private bool isDisposed = false;

        public void Print(string message)
        {
            Console.WriteLine("Hello " + message);
        }

        ~DisposableTest()
        {
            Console.WriteLine("Destructor/Finalize of DisposableTest");
            Dispose(false);
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        protected void Dispose(bool dispose)
        {
            if (!isDisposed)
            {
                if (dispose)
                {
                    // to cleanup managed objects  
                }
                // To cleanup unmanaged resources/objects  
                isDisposed = true;
            }
        }
    }
}
