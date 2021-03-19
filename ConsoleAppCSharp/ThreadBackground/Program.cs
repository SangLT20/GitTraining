using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadBackground
{
    public class Printer
    {
        public void PrintNumbers()
        {
            Console.WriteLine("=> {0} is executing PrintNumbers()", Thread.CurrentThread.Name);

            Console.WriteLine("your number :");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0},", i);
                Thread.Sleep(200);
            }
            Console.WriteLine();

            //Console.ReadLine();
        }
    }

    class Program
    {
        public static void MethodA()
        {
            for (int i = 0; i < 2000; i++)
            {
                Thread.Sleep(100);
                Console.Write("0");
            }

            Console.ReadLine();
        }

        static void Main(string[] args)
        {
            Console.WriteLine("***** The Amazing Thread App *****\n");
            Console.Write("Do you want [1] or [2] threads? ");
            string threadCount = Console.ReadLine();

            Thread primaryThread = Thread.CurrentThread;
            primaryThread.Name = "Primary";

            Thread threadSecond = new Thread(MethodA);
            threadSecond.Start();

            Console.WriteLine("=> {0} is executing main():", Thread.CurrentThread.Name);

            Printer p = new Printer();

            switch (threadCount)
            {
                case "2":
                    Thread backgroundThread = new Thread(new ThreadStart(p.PrintNumbers));
                    backgroundThread.Name = "secondary";
                    backgroundThread.IsBackground = true;
                    backgroundThread.Start();
                    break;
                case "1":
                    p.PrintNumbers();
                    break;
                default:
                    Console.WriteLine("I don't know what you want...you get 1 thread.");
                    goto case "1";
            }
            Console.WriteLine("I'm busy!", "Work on main thread...");

        }
    }
}
