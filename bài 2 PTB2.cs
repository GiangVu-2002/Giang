using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTB2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;
            int c = 1;
            int delta = b * b - 4 * a * c;
            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("phuong trinh co hai nghiem phan biet:");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else if (delta == 0)
            {
                double x = (double)-b / (2 * a);
                Console.WriteLine("phuong trinh co nghiem kep: x = " + x);
            }
            else
            {
                Console.WriteLine("phuong trinh vo nghiem (Delta < 0)");
            }
            Console.WriteLine("\n");
            Console.ReadKey();
        }
    }
}
