using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double PI = 3.14, x;
            Console.WriteLine("Введите значение угла в радианах");
            double a = Convert.ToInt32(Console.ReadLine());
            x = a * 180 / PI;
            Console.WriteLine("Ответ: {0} градусов", Math.Round(x,2));
        }
    }
}
