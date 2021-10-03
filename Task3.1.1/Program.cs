using System;

namespace Task3._1._1
{
    class Program
    {
        /*3.1.1 В одномерном целочисленном массиве переставить элементы в обратном порядке, 
 * не используя других массивов*/
        public static void Swap(ref int[] arr)
        {
            int temp = 0;
            for (int i = 0; i < arr.Length / 2; i++)/*зеркальная замена значений, 
                если длина массива - нечётное число, значение, которое находится посредине, не меняет своё положение*/
            {
                temp = arr[i];
                arr[i] = arr[arr.Length - i - 1];
                arr[arr.Length - i - 1] = temp;
            }
        }

        static void Main(string[] args)
        {
            const int N = 7;
            int[] arr = new int[N];

            for (int i = 0; i < N; i++)//заполнение массива
            {
                Console.Write("Введите {0} число: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Swap(ref arr);//передача параметра по ссылке
            Console.WriteLine("Элементы массива в обратном порядке: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ", arr[i]);
            }
        }
    }
}
