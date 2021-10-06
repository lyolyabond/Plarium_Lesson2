using System;

namespace Task2._2._3
{
    class Program
    {
        /*2.2.3 Дано натуральное число.Найти число, получаемое удалением из исходного всех цифр а*/
        public static void DeleteDigits(int num)
        {
            Console.Write("Введите цифру: ");//цифра, которую нужно удалить из числа
            int a = int.Parse(Console.ReadLine());
             int i = 0;
             int temp = num;
             while (temp > 0)//подсчёт разрядов числа
             {
                 temp /= 10;//уменьшение количества разрядов
                 i++;
             }
             temp = 0;

             for (int j = 1; j <= i; j++)
             {
                 if (num % 10 != a)//если цифра числа не равна a
                 {
                     temp += num % 10 * (int)Math.Pow(10, j - 1);//запись цифры в число 
                     num /= 10;
                 }
                 else
                 {
                     j--;
                     i--;//уменьшение количества разрядов т.к. присутсвует цифра a
                     num /= 10;
                 }
             }
           
            Console.WriteLine("Число без цифр {0}: " + temp, a);
        }
        static void Main(string[] args)
        {
            int num;
             do//корректный ввод натурального числа
             {
                 Console.Write("Введите натуральное число:");
                 num = int.Parse(Console.ReadLine());
             } while (num <= 0);
            DeleteDigits(num);//передача параметра по значению
        }
    }
}
