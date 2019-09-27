using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите стоимость конфет");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите вес конфет в килограммах");
            int X = Convert.ToInt32(Console.ReadLine());
            int I;
            I = A / X;
            Console.WriteLine("Введите вес конфет, стоимость которого хотите узнать");
            int Y = Convert.ToInt32(Console.ReadLine());
            A = I * Y;
            Console.WriteLine("Один килограмм этих конфет стоит {0} рублей", I);
            Console.WriteLine("Стоимость {0} килограмм(а) этих конфет {1} рублей", Y, A);

        }
    }
}
