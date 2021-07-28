using System;

namespace ConsoleAppLesson_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Enter the " + (i+1) + " number");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("");

            // индексы

            Console.WriteLine("The last number of the array is " + array[^1]);

            Console.WriteLine("");

            //используя символ '^' мы указываем, что хотим получить элементы массива не с начала, а с конца. Так же индексация с конца начинается не с 0, а с 1

            //диапазоны

            int[] array_2 = array[1..4];

            // используя диапазон array[1..4] мы указали, что хотим записать в массив array_2 элементы из массива array с первого по четвертый (четвертый не включается)

            for (int i = 0; i < array_2.Length; i++)
            {
                Console.WriteLine((i + 1) + " number from second array is - " + array_2[i]);
            }

            Console.WriteLine("");

            int[] array_3 = array[..7];

            // если мы не указываем левую границу, то диапазон будет от начала и до указанной правой границы
            // аналогичная ситуация если не указать правую границу и указать левую
            // если не указать обе границы, то просто один массив запишеться в другой

            for (int i = 0; i < array_3.Length; i++)
            {
                Console.WriteLine((i + 1) + " number from third array is - " + array_3[i]);
            }

            Console.WriteLine("");

        }
    }
}
