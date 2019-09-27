using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите коэффициент A");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите число B");
            int B = Convert.ToInt32(Console.ReadLine());
            int X = -B / A;
            Console.WriteLine("Ответ:{0}", X);

        }
    }
}
