using System;

namespace Task1._1
{
    //Номер по списку - 3
    class Program
    {
        /*1.1 Написать программу, которая введет 5 значений и посчитает 
             произведение чисел, делящихся без остатка на 7 или 3.*/
        public static void Multiplication()
        {
            int num; 
            int mul = 1;
            for (int i = 1; i <= 5; i++) //ввод 5 значений
            {
                Console.Write("Введите {0} значение: ", i);
                num = int.Parse(Console.ReadLine());//перевод введённой строки в int
                if (num % 7 == 0 || num % 3 == 0) //проверка  на деление без остатка на 7 или 3
                {
                    mul *= num;//если условие выполнено, то значение умножается
                }
            }
            if (mul != 1)//проверка были ли значения, которые делились без остатка
            {
                Console.WriteLine("Произведение чисел, делящихся без остатка на 7 или 3: " + mul);
            }
            else
            {
                Console.WriteLine("Нет чисел, которые делятся без остатка на 7 или 3!");
            }
        }

        static void Main(string[] args)
        {
            Multiplication();
        }
    }
}
