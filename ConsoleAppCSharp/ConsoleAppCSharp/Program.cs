using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace ConsoleAppCSharp
{
    class Program
    {
        protected static readonly ILog log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = Encoding.UTF8;
                Dictionary<string, string> diction = new Dictionary<string, string>();
                diction.Add("a", "sssss");
                diction.Add("b", "fsahfalkfhasl");
                diction.Add("c", "sfafaf");
                foreach (KeyValuePair<string, string> item in diction)
                {
                    Console.WriteLine("Ma; " + item.Key + "Value: " + item.Value);

                }
            }
            catch(Exception e)
            {
                log.Error($"Log exception {e.Message}, {e.StackTrace}");
                Console.WriteLine($"Has exception: {e.Message}");
            }
            Console.ReadLine();
        }
    }
}
