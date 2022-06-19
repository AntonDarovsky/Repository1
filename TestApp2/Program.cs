using System;
using System.Linq;

namespace TestApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 5, 2, 1, 4, 5, 8 };

            int max = array1[0];
            int min = array1[0];
            for(int i = 1; i<array1.Length;i++)
            {
                if (array1[i] < min)
                {
                    min = array1[i];
                }
               else if (array1[i] > max)
                {
                    max = array1[i];
                }

            }
            int maxIndex = Array.IndexOf(array1, max);
            int minIndex = Array.IndexOf(array1, min);

            array1[minIndex] = max;
            array1[maxIndex] = min;

            Console.WriteLine("Result = {0}", string.Join(", ", array1));

        }
    }
}
