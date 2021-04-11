using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите c");
            double c = Convert.ToDouble(Console.ReadLine());
            
            if (Math.Pow(b,2)-4*a*c<0)
          Console.WriteLine("Уравнение не имеет корней");
            else
            Console.WriteLine("Уравнение имеет корни");
            Console.Read();
        }
    }
}
