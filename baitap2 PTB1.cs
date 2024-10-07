using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai_2
{
    public class baitap2
    {
        public static string GPTrinhBac1(double a, double b)
        {
            string ketqua = "";
            if (a == 0 && b == 0)
                ketqua = " phuong trinh vo so nghiem !!!";
            else
                if (a == 0)
                ketqua = " phuong trinh vo nghiem !!!";
            else
                ketqua="nghiem x="+(-b/a);
            return ketqua;

        }
        static void Main(string[] args)
        {
            double a, b;
            Console.Write("nhap he so a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("nhap he so b: ");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine(" ket qua: " + GPTrinhBac1(a,b));
            Console.ReadKey();

        }
    }
}
