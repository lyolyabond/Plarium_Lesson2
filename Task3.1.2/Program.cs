using System;

namespace Task3._1._2
{
    class Program
    {
        /*3.1.2 Найти количество элементов массива, встречающихся в нем один раз. */
        public static void OccurOnce(int[] arr, out int count_out)//пример передачи параметра с модификатором out
        {
            int count = 0;
            int countOnce = 0;
            count_out = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (i != j)
                    {
                        if (arr[i] == arr[j])//сравнивание одного элемента с каждым
                        {
                            continue;
                        }
                        else countOnce++;
                    }
                }
                if (countOnce == arr.Length - 1)//если элемент встречается один раз, то значение countOnce должно быть равно длине массива-1
                {
                    count_out = ++count;//добавление количества элементов, которые встречаются один раз
                }
                countOnce = 0;
            }
        }

        static void Main(string[] args)
        {
            int count_out;
            const int N = 7;
            int[] arr = new int[N];
            
            for (int i = 0; i < N; i++)
            {
                Console.Write("Введите {0} число: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            
            OccurOnce(arr, out count_out);//передача параметров по значению и с модификатором  out

            Console.WriteLine("\nКоличество элементов, которые встречаются 1 раз: " + count_out);
        }
          
    }
}
