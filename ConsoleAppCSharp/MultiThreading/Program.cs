using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = Console.ReadLine();
            Console.WriteLine(key);
            Thread t = new Thread(() => Go("o"));
            Thread t2 = new Thread(() => Go("i"));
            t.Start();
            t2.Start();
            //t.Join();
            Thread.Sleep(TimeSpan.FromMinutes(1)); // sleep for 1 minutes
            //Thread.Sleep(500); // sleep for 500 milliseconds 
            Thread.Sleep(0);            Thread.Yield();            Go("i");
            Console.WriteLine("Thread t has ended!");
           


            //using (var process1 = new Process())
            //{
            //    // E:\C\C#\ConsoleAppCSharp\ConsoleAppCSharp\bin\Debug\ConsoleAppCSharp.exe
            //    process1.StartInfo.FileName = @"..\..\..\ConsoleAppCSharp\bin\Debug\ConsoleAppCSharp.exe";
            //    process1.Start();

            //    // Close process by sending a close message to its main window.
            //    process1.CloseMainWindow();
            //    // Free resources associated with process.
            //    process1.Close();
            //}

            Console.WriteLine("MainApp");
            Console.ReadKey();
        }

        static void Go(string input)
        {
            for (int i = 0; i < 1000; i++) Console.Write(input);
        }
    }
}
