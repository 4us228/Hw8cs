using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hw8cs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
           
            Type type = typeof(DateTime);
            PropertyInfo property1 = type.GetProperty("Now");
            if (property1.CanRead)
            {
                DateTime time=(DateTime)property1.GetValue(DateTime.Now);
                Console.WriteLine($"Time now -> {time} ");
            }
            PropertyInfo property2 = type.GetProperty("UtcNow");
            if (property2.CanRead)
            {
                DateTime time=(DateTime)property2.GetValue(DateTime.UtcNow);
                Console.WriteLine($"UtcNow -> {time} ");
            }
            PropertyInfo property3 = type.GetProperty("Today");
            if (property3.CanRead)
            {
                DateTime time=(DateTime)property3.GetValue(DateTime.Today);
                Console.WriteLine($"Today -> {time} ");
            }


            Console.ReadLine();
        }
    }
}
