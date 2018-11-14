using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_of_math
{
    class Program
    {
        static void power(int m , int n)
        {
            int a = 1;
            for(int i=1 ; i<=n ; i++)
            {
                a = a * m;
            }
            Console.WriteLine($"The result is : {a}");
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Please enter number : ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Please enter power of number : ");
            b = int.Parse(Console.ReadLine());
            power(a, b);
            Console.ReadKey();
        }
    }
}
