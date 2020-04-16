using System;

using static System.Console;

namespace ConsoleClassWorkFourteenth
{
    class Program
    {
        static void Main(string[] args)
        {


            // Random random = new Random();

            /* for (int i = 0; i < 5; i++)
             {
                 arrayOne[i] = random.Next(0, 100);

         }

             for (int i = 0; i< 5; i++)
             {
                 arrayTwo[i] = random.Next(0, 100);
             }


             for (int i = 0; i < 5; i++)
             {
                 arrayOne[i] = random.Next(0, 100);
                 arrayTwo[i] = random.Next(0, 100);
             }

             */
            /*
           for (int i = 0; i < 5; i++)
           {
               arrayThree[i] = arrayOne[i];
           }
           for (int i = 5; i < 10; i++)
           {
               arrayThree[i] = arrayTwo[i -5];
           }
           for (int i = 0; i < 5; i++)
           {
               arrayThree[i +5] = arrayTwo[i];
           }
           */

            int[] arrayOne = new int[5] { 1, 2, 3, 4, 5 };
            int[] arrayTwo = new int[5] { 1, 2, 3, 4, 6 };

            int[] arrayThree = new int[10];


            // 1. find even elements
            // 2. copy to third array
            // 1 1 2 1 6 1
            // NULL NULL 2 2 4

            // b[0] = a[2]
            // b[1] = a[4]
            // 
            //

            int enumerator = 0;
            
            for (int i = 0; i < 5; i++)
            {
                if (arrayOne[i] % 2 == 0) // to calculate even numbers before sending them to the 3rd array.
                {
                    enumerator++; // enumerator = enumeratoe + 1;

                }
            }
            
            int counter = 0;
            for (int i = 0; i < 5; i++)
            {
                if(arrayTwo[i] % 2 != 0)
                {
                    arrayThree[counter] = arrayTwo[i];
                    counter++;
                }
            }

            WriteLine($"There are {counter} odd numbers in your array!");
            for (int i = 0; i < counter; i++)
            {
                Write($"{arrayThree[i]}\t");
            }
            WriteLine();
            // 1 1 0 2 2 2 2 
            // counter = 2
            // 1 1 

            for (int i = 0; i < 10; i++)
            {
                Write($"{arrayThree[i]}\t");
            }
            WriteLine();

            WriteLine($"There are {enumerator} even numbers in your array!"); // WriteLine($"Count even numbers - {enumerator}");
            
            /*
            for (int i = 0; i<5; i++)
			{
                if (arrayTwo[i] % 2 == 0)
                {
                    arrayThree[i + i + 1] = arrayTwo[i];
                }
			}
                for (int z = 0; z < 10; z++)
                {
                    WriteLine($"Elements of third array after interluding: {arrayThree[z]}");
                }
            }
            
           
            //1
            //  arrayThree[0/*i+i = (0+0)*///] = arrayOne[0/*i=0*/]; // = 1
                                           // arrayThree[1/*i+i+1 = (0+0+1)*/] = arrayTwo[0/*i=0*/]; // = 5
                                           //2
                                           //  arrayThree[2/*i+i = (1+1)*/] = arrayOne[1/*i=0*/]; // = 2
                                           //  arrayThree[3/*i+i+1 = (1+1+1)*/] = arrayTwo[1/*i=1*/]; // = 4
                                           //3
                                           // arrayThree[4/*i+i = (2+2)*/] = arrayOne[2/*i=2*/]; // = 3
                                           // arrayThree[5/*i+i+1 = (2+2+1)*/] = arrayTwo[2/*i=2*/]; // = 3


            ReadKey();
        }
    }
}
