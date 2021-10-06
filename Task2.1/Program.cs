﻿using System;

namespace Task2._1
{
    class Program
    {
        /*2.1 Дано натуральное число n (n < 27). Найти все трехзначные числа,
        * сумма цифр которых равна п. Операции деления, целочисленного деления
        * и определения остатка не использовать.*/

        public static void SumDigits(int num)
        {
           
            Console.WriteLine("--Все трехзначные числа, сумма цифр которых равна {0}:--", num);
            for (int i = 1; i < 10; i++)//подбор первой цифрры, которая может быть в диапазоне 1-9
            {
                for (int j = 0; j < 10; j++)//подбор второй цифрры, который может быть в диапазоне 0-9
                {
                  for (int n = 0; n < 10; n++)//подбор третьей цифрры, который может быть в диапазоне 0-9
                    {

                        if (i + j + n == num)//проверка: равна ли сумма 3 цифр введённому числу
                        {
                            Console.WriteLine("{0}{1}{2}", i, j, n);//вывод трёхзначного числа по цифрам
                        } 
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int num;
            do//корректный ввод натурального числа меньше 27
            {
                Console.Write("Введите натуральное число < 27:");
                num = int.Parse(Console.ReadLine());
            } while (num <= 0 || num >= 27);
            SumDigits(num);
        }
    }
}