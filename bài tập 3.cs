using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_tap_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write(" C: ");
            double C = Convert.ToDouble(Console.ReadLine());
            double K = C + 273;
            double F = (C * 18 / 10) + 32;
            Console.WriteLine($"{C} do C tuong duong {K} do K.");
            Console.WriteLine($"{C} do C tuong duong {F} do F.");
        }
    }
}
