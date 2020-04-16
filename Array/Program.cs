using System;

using static System.Console;

namespace ConsoleArrayElementsEqualZero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Найти в массиве всё элементы равные нулю.
            // Скопировать эти элементы в другой массив

            const int SIZE = 6;
            int[] arrayElements = new int[SIZE]{0, 5, 0, 5, 3, 0};
            int[] zeroElements = new int[SIZE];

           /*Random random = new Random();
            for (int i = 0; i < SIZE; i++)
            {
                arrayElements[i] = random.Next(0, 0);
            }*/

            int zero = 0;
            for (int i = 0; i < SIZE; i++)
            {
                if(arrayElements[i] == 0)
                {
                    zeroElements[zero] = arrayElements[i];
                    zero++;
                }
               
            }
            for (int i = 0; i < zero; i++)
            {
                Write($"{zeroElements[i]} \t");
            }

            WriteLine("\n");
            WriteLine($"There are {zero} zero(s) elements in the array");
            ReadKey();
        }
    }
}
