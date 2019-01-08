using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many hours of sleep you get last night ? ");
            int hoursOfSleep = int.Parse(Console.ReadLine());
            string sleepStatus = "";
            if(hoursOfSleep > 7)
            {
                sleepStatus = "Good Sleep";
            }
            else
            {
                sleepStatus = "Bad Sleep";
            }

            Console.WriteLine(" Got " + sleepStatus);
           
            Console.ReadKey();
        }
    }
}
