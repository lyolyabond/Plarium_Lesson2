using System;

namespace Task1._2
{
    class Program
    {
        /*1.2 Предприниматель 1 марта открыл счет в банке, вложив 1000 руб. 
         * Через каждый месяц размер вклада увеличивается на 2% от имеющейся суммы.
         * Определить:
           а) прирост суммы вклада за первый, второй, ..., десятый месяц;
           б) сумму вклада через три, четыре, ..., двенадцать месяцев.*/

        public static void Bank()
        {
            decimal sum = 1000;
            decimal gain = 0;
            Console.WriteLine("--Прирост суммы вклада--");
            for (int i = 1; i <= 10; i++)
            {
                gain = sum * 0.02m;//прирост суммы
                sum += gain;//изменение суммы путём добавление прироста
                Console.WriteLine("за {0} месяц: " + Math.Round(gain, 2), i);//вывод прироста с 1 по 10 месяц
            }
            sum = 1000;
            Console.WriteLine("\n--Сумма вклада--");
            for (int i = 1; i <= 12; i++)
            {
                sum += sum * 0.02m;//вычисление суммы вклада через каждый месяц
                if (i > 2)//вывод суммы с 3 по 12 месяц
                {
                    if (i == 3 || i == 4)
                        Console.WriteLine("через {0} месяца: " + Math.Round(sum, 2), i);
                    else
                        Console.WriteLine("через {0} месяцев: " + Math.Round(sum, 2), i);
                }
            }
        }
        static void Main(string[] args)
        {
            Bank();
        }
    }
}
