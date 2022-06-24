using System;

namespace Task2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfNumbers = {5, 12, 19, 26, 33, 40, 47, 54, 61, 68, 75, 82, 89, 96};
            int amountOfNumbersInArray = 14;

            //Более удобное условие цикла.
            for (int i = 0; i < amountOfNumbersInArray; i++)
            {
                Console.WriteLine(arrayOfNumbers[i]);
            }
        }
    }
}
