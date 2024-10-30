using Tyuiu.AkhmedullovRR.Sprint3.Task6.V18.Lib;

namespace Tyuiu.AkhmedullovRR.Sprint3.Task6.V18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int startValue = 9, endValue = 18;
            Console.Title = "Спринт #3 | Выполнил: Ахмедуллов Р.Р. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема: Обработка целочисленной информации                                *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #18                                                             *");
            Console.WriteLine("* Выполнил: Ахмедуллов Равиль Радикович | ИСТНб-24-1                             *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Напишите программу, которая ищет среди целых чисел,                     *");
            Console.WriteLine("* принадлежащих числовому отрезку [9, 18]                                 *");
            Console.WriteLine("* сумму всех делителей меньше 10                                          *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Результат:                                                              *");
            Console.WriteLine("***************************************************************************");

            Console.Write("Сумма делителей равна " + ds.GetSumTheDivisors(startValue, endValue));
            Console.ReadLine();
        }
    }
}