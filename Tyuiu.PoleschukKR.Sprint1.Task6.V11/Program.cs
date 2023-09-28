using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PoleschukKR.Sprint1.Task6.V11.Lib;

namespace Tyuiu.PoleschukKR.Sprint1.Task6.V11
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт 1 | Выполнил: Полещук К.Р. | ИИПб-23-1";
            //Длина строки 75 символов
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Алгоритмы линейной структуры. Class Math                          *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #11                                                             *");
            Console.WriteLine("* Выполнил: Полещук Кирилл Романович | ИИПб-23-1                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, которая проверяет, что в тексте, введенном          *");
            Console.WriteLine("* пользователем, первая буква строки входит в нее еще раз.                *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Введите текст: ");
            string str = Console.ReadLine();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine(ds.CheckeFirstLetterRepetition(str));
            Console.ReadKey();
        }
    }
}
