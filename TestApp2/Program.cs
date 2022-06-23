using System;
using System.Linq;

namespace TestApp2
{
    class Program
    {
        static int SwapMaxandMin(int[] array)
        {  
            int max = array[0];
            int min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                else if (array[i] > max)
                {
                    max = array[i];
                }

            }
            int maxIndex = Array.IndexOf(array, max);
            int minIndex = Array.IndexOf(array, min);

            array[minIndex] = max;
            array[maxIndex] = min;
          

            

            return maxIndex;
        }
         
        static void Main(string[] args)
        {
            
            int[] array2 = { 1, 3, 5, 8, 4, 2 };
            
            int[] array3 = { 6, 3, 5, 8, 9, 2 };
            SwapMaxandMin(array3);
            SwapMaxandMin(array2);
            int[] array5 = { 6, 3, 5, 8, 9, 1 };
            SwapMaxandMin(array5);
            Console.WriteLine("Result = {0}", string.Join(", ", array2));
            Console.WriteLine("Result = {0}", string.Join(", ", array3));
            Console.WriteLine("Result = {0}", string.Join(", ", array5));
        }
    }
    
}
