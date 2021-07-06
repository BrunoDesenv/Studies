using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();
            process.StartInfo.FileName = "cmd.exe";
            //process.StartInfo.CreateNoWindow = true;
            //process.StartInfo.RedirectStandardInput = true;
            //process.StartInfo.RedirectStandardOutput = true;
            //process.StartInfo.UseShellExecute = false;
            process.Start();

            process.StandardInput.WriteLine("ipconfig");

           
            process.StandardInput.Flush();
            process.StandardInput.Close();
            process.WaitForExit();

            Console.WriteLine(process.StandardOutput.ReadToEnd());
            Console.ReadKey();
        }
    }
}
