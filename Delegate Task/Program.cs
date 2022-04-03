using System;
using System.Collections.Generic;
using System.Linq;

namespace Delegate_Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Action<double> action = getProductNumber;

            action(1);
        }
        public static void getProductNumber(double x)
        {
            int count = 0;
            double[] array = { 10, 25, 36, 59, 78, 92 };
            double total = default(double);            
            foreach (var item in array)
            {
                total += item;
                count++;
                
            }
            Console.WriteLine("Arrayin cemi");
            Console.WriteLine(total);

            Console.WriteLine("\nCount");
            Console.WriteLine(count);

        }
        

        
    }
}
