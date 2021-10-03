using System;

namespace Task2._2._2
{
    class Program
    {
        /*2.2.2 Дано натуральное число. Найти число, получаемое при прочтении его цифр справа налево*/
        public static void ReverseDigit(ref int num)
        {
            int i = 0;
            int temp = num;
            while (temp > 0)
            {
                temp /= 10;
                i++;//подсчёт количества разрядов числа num
            }
            temp = 0;
            if (i > 1)
            {
                for (int j = i; j > 0; j--)
                {
                    temp += num % 10 * (int)Math.Pow(10, j - 1);//вычисление каждого разряда и умножение на 10 в соответствующей степене
                    num /= 10;//уменьшение разрядов
                }
            }
            else temp = num;
            num = temp; //для примера передачи переменной по ссылке
        }
        static void Main(string[] args)
        {
            int num =0;
            do//корректныый ввод натурального числа
            {
                Console.Write("Введите натуральное число:");
                num = int.Parse(Console.ReadLine());
            } while (num <= 0);

            ReverseDigit(ref num);//передача параметра по ссылке
            Console.WriteLine("Число, получаемое при прочтении его цифр справа налево: " + num);
            //значение num после выполнения ReverseDigit(ref num) изменилось
        }
    }
}
