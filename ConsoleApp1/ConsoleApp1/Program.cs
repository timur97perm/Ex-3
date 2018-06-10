using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool succ = false;
            double y, x = 0;
            Console.WriteLine("Введите переменные");
           do
            {
                Console.WriteLine("Введите переменную y");
                succ = double.TryParse(Console.ReadLine(), out y);
                if (!succ)  Console.WriteLine("Ошибка - необходимо ввести число.");
            } while (!succ);

            do
            {
                Console.WriteLine("Введите переменную x");
                succ = double.TryParse(Console.ReadLine(), out x);
                if (!succ)  Console.WriteLine("Ошибка - необходимо ввести целое число.");
            } while (!succ);

            if (((x >= 0 && y >= 0) && (y + 2 * x <= 1)) || ((x >= 0 && y <= 0) && (y - 2 * x <= -1)
                || ((x <= 0 && y >= 0) && (y + 2 * x <= -1)) || ((x <= 0 && y <= 0) && (y - 2 * x < 1))))
                {
                Console.WriteLine("Точка принадлежит заданной области");
                }
            else Console.WriteLine("Точка не принадлежит заданной области");
            Console.WriteLine("Нажмите любую кнопку для выхода из программы");
            Console.ReadKey();


        }
    }
}
