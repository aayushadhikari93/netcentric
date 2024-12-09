using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter two numbers to swap");
            a=Convert.ToInt32(Console.ReadLine());
            b=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Number before swapping:a={a},b={b}");
            a = a + b;
            b = a - b;
            a= a - b;
            Console.WriteLine($"Number after swapping:a={a},b={b}");
            Console.ReadLine();
            
        }
    }
}
