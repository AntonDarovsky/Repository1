using System;
using System.Collections.Generic;

namespace TestApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] array1 = new char[6] { 'a', 'b', 'c', 'a', 'a', 'b' };

            Dictionary<char, int> counter = new Dictionary<char, int>();

            for (int i = 0; i < array1.Length; i++){
                if (counter.ContainsKey(array1[i]))
                {
                    counter[array1[i]] = counter[array1[i]] + 1;
                } else
                {
                    counter[array1[i]] = 1;
                }
            }

            int max = 0;

            foreach (var item in counter)
            {
                if (item.Value > max)
                {
                    max = item.Value;
                }
            };

            Console.WriteLine(max);
        }
    }
}
