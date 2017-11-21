using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 1
            Console.WriteLine("Hello!");
            Console.WriteLine("My name is Dias!");
            Console.ReadLine();


            //Задание 2
            Console.Write("Введите первое число: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите второе число: ");
            int y = int.Parse(Console.ReadLine());
            int sum = x + y;
            Console.Write("Сумма двух чисел равна - " + sum);
            Console.Read();
             
        }
    }
}
