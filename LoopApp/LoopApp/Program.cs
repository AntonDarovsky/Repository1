using System;

namespace LoopApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[6] { 1, 2, 3, 4, 5, 6};
            int[] array2= new int[6];
            for (int i = array1.Length - 1; i>= 0; i--)
            { 

                array2[(array1.Length - 1) - i] = array1[i];
            }
       
            Console.WriteLine(string.Join( ", ",array2));
       
       
        }
    }
}
