using System;

namespace FirstProjectCharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[3];
            array1[0] = 4;
            array1[1] = array1[0] * array1[0];
            array1[2] = array1[0] + array1[1];

            float[] array2 = new float[3];
            array2[0] = 2.3F;
            array2[1] = array2[0] * array2[0];
            array2[2] = array2[0] + array2[1];

            long[] array3 = new long[3];
            array3[0] = (long)(array1[0] + array2[0]);
            array3[1] = (long)(array1[1] + array2[1]);
            array3[2] = (long)(array1[2] + array2[2]);

            Console.WriteLine("Result array1[0]= {0}", array1[0]);
            Console.WriteLine("Result array1[1]= {0}", array1[1]);
            Console.WriteLine("Result array1[2]= {0}", array1[2]);
            Console.WriteLine("Result array2[0]= {0}", array2[0]);
            Console.WriteLine("Result array2[1]= {0}", array2[1]);
            Console.WriteLine("Result array2[2]= {0}", array2[2]);
            Console.WriteLine("Result array3[0]= {0}", array3[0]);
            Console.WriteLine("Result array3[1]= {0}", array3[1]);
            Console.WriteLine("Result array3[2]= {0}", array3[2]);
        }
    }
}
