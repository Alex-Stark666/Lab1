using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //В одномерном массиве,
            //состоящем из N целочисленных элементов
            int N = 11;
            int[] arr = new int[N];
            Random rnd = new Random();
            for (int i = 0; i < N; i++)
            {
                arr[i] = rnd.Next(-10, 21);
            }

            Console.WriteLine("Исходный массив: " + string.Join(" ", arr));

            //количество положительных элементов массива
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0) { count++; }
            }

            Console.WriteLine("Кол-во элементов > 0: " + count.ToString());

            //сумму элементов массива,
            //расположенных после последнего элемента,
            //равного нулю.
            int zero = -1;
            for (int i = 0;i < arr.Length; i++)
            {
                if (arr[i] == 0) { zero = i; } 
                else { continue; }
            }

            Console.WriteLine("Индекс последнего нуля:" + zero.ToString());

            if (zero == -1) { Console.WriteLine("Нулей нет, суммы после последнего - тоже"); }
            else
            {
                int sum = 0;
                for (int i = zero; i < arr.Length; i++)
                {
                    sum += arr[i];
                }

                Console.WriteLine("Сумма элементов после послед. нуля: " + sum.ToString());
            }

            //Преобразовать массив таким образом,
            //чтобы сначала располагались все элементы,
            //целая часть которых не превышает единицу,
            //а потом — все остальные.

            Array.Sort(arr);
            Console.WriteLine("Отсортированный массив: " + String.Join(" ", arr));

            Console.ReadKey();
        }
    }
}
