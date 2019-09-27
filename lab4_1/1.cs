using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double PI = 3.14, x;
            Console.WriteLine("Введите значение угла в градусах");
            int a = Convert.ToInt32(Console.ReadLine());
            x = a * PI / 180;
            Console.WriteLine("Ответ: {0} рад.", x);
        }
    }
}
