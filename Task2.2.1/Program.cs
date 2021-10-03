using System;

namespace Task2._2._1
{
    class Program
    {
        /*2.2.1 Дано натуральное число.  Определить, есть ли в нем цифры а и b.*/
        public static void ContainsDigits(int num)
        { 
            Console.Write("Введите 1 цифру: ");
            int a = int.Parse(Console.ReadLine());//перевод введённой строки в int
            Console.Write("Введите 2 цифру: ");
            int b = int.Parse(Console.ReadLine());//перевод введённой строки в int
            bool check_a = false;
            bool check_b = false;
            
            while (num > 0)
            {
                if (num % 10 == a)//проверка равна ли цифра a 
                {
                    check_a = true;//число содержит цифру а
                }
                else if (num % 10 == b)//проверка равна ли цифра b 
                {
                    check_b = true;//число содержит цифру b
                }
                num /= 10;//уменьшение разряда путём деления на 10
            }
            if (check_a && check_b)//если число содержит обе цифры
            {
                Console.Write("Число содержит цифры {0} и {1}", a, b);
            }
            else
            {
                Console.Write("Число не содержит цифры {0} и {1}", a, b);
            }
        }
        static void Main(string[] args)
        {
            int num;
            do//корректный ввод натурального числа
            {
                Console.Write("Введите натуральное число:");
                num = int.Parse(Console.ReadLine());
            } while (num <= 0);
            ContainsDigits(num);//передача параметра по значению
        }
    }
}
