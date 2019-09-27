using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите скорость первого автомобиля");
            int V1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите скорость второго автомобиля");
            int V2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите расстояние между автомобилями");
            int S = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите количество часов, которое должно пройти");
            int T = Convert.ToInt32(Console.ReadLine());
            int S1 = V1 * T + V2 * T + S;
            Console.WriteLine("Ответ:{0} км", S1);
        }
    }
}
