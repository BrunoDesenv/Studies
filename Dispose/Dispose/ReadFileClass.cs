using Microsoft.Win32.SafeHandles;
using System;
using System.Runtime.InteropServices;

namespace Dispose
{
    public class ReadFileClass : IDisposable
    {
        Boolean disposed = false;

        SafeHandle safeHandle = new SafeFileHandle(IntPtr.Zero, true);

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(Boolean disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                safeHandle.Dispose();
                Console.WriteLine("Freeing managed resources.");
            }

            Console.WriteLine("Freeing unmanaged resources.");

            disposed = true;
        }
    }
}
