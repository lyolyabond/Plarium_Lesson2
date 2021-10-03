using System;

namespace Task3._1._3
{
    class Program
    {
        /*3.1.3 В одномерном целочисленном массиве x[1]…x[n+m], рассматриваемом 
         * как соединение двух его отрезков: начала x[1]…x[n] длины n и конца 
         * x[n]… [n+m] длины m, переставить местами начало и конец, не используя
         * дополнительных массивов.  */
            const int n = 5;//длины отрезков
            const int m = 3;
        public static void ArrayNM(ref int[] arr)
        {
            int temp = 0;

            Console.WriteLine();
            for (int i = n - 1, a = n + m - 1; i >= 0; i--, a--)//от конца первого отрезка до начала
            {
                //перемещение элементов 1 отрезка в конец и сдвиг влево элементов второго отрезка

                temp = arr[i];//временное помещение значения элемента массива 
                arr[i] = 0;
                for (int j = i; j < i + m; j++)//выполняется m раз, чтобы сдвинуть m элементов влево к началу
                {
                    arr[j] = arr[j + 1];//сдвиг влево на 1

                }
                arr[a] = temp;//присвоение значения временной переменной элементу массива(в конец)
            }
        }
        static void Main(string[] args)
        {
            int[] arr = new int[n + m];
            for (int i = 0; i < n + m; i++)
            {
                Console.Write("Введите {0} число: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            ArrayNM(ref arr);//передача параметра по ссылке
            for (int i = 0; i < n + m; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
