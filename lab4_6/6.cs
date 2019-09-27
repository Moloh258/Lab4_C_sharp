using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите A1, B1 и C1");
            int A1 = Convert.ToInt32(Console.ReadLine());
            int B1 = Convert.ToInt32(Console.ReadLine());
            int C1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите A2, B2 и C2");
            int A2 = Convert.ToInt32(Console.ReadLine());
            int B2 = Convert.ToInt32(Console.ReadLine());
            int C2 = Convert.ToInt32(Console.ReadLine());

            int D = A1 * B2 - A2 * B1;
            int x = (C1 * B2 - C2 * B1) / D;
            int y = (A1 * C2 - A2 * C1) / D;
            Console.WriteLine("x = {0}\n y = {1}", x, y);
        }
    }
}
