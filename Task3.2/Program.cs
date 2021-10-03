using System;

namespace Task3._2
{
    class Program
    {
        /*3.2 Дана целочисленная прямоугольная матрица. Определить:
         количество столбцов, содержащих хотя бы один нулевой элемент;
        номер строки, в которой находится самая длинная серия одинаковых элементов.*/
        public static void Matrix()
        {
            const int n = 4;//количество строк матрицы
            const int m = 5;//количество столбцов матрицы
            int[,] arr = new int[n, m];
            Random rand = new Random();

            for (int i = 0; i < n; i++)//заполнение элементов рандомными значениями от 0 до 10
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = rand.Next(0, 10);
                    if (arr[i, j] == 0)//выделение цветом нулей
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("{0} ", arr[i, j]);

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("{0} ", arr[i, j]);
                    }
                }
                Console.WriteLine();
            }
            int count = 0;

            for (int i = 0; i < m; i++)//проход по столбцам
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[j, i] == 0)
                    {
                        count++;//подсчёт количества столбцов с 0
                        break;
                    }
                }
            }
            int sameElements = 0;
            int temp = 0;
            int index = -1;
            for (int i = 0; i < n; i++)//проход по строкам
            {
                for (int j = 0; j < m - 1; j++)
                {
                    if (arr[i, j] == arr[i, j + 1])
                    {
                        sameElements++;//подсёт количества одинаковых элементах подряд в строке

                    }
                }
                if (sameElements > temp)//сравнение количества
                {
                    temp = sameElements;
                    index = i;
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Количество столбцов, которые содержат 0: " + count);
            if (index != -1)
            {
                Console.WriteLine("Номер строки, в которой находится самая длинная серия одинаковых элементов: " + (index + 1));
            }
            else Console.WriteLine("В матрице нет строки с серией одинаковых элементов!");
        }
        static void Main(string[] args)
        {
            Matrix();
        }
    }
}
