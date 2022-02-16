using System;

namespace _233
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[20] { 12, 45, 78, 96, 63, 93, 85, 52, 82, 71, 74, 71, 11, 21, 58, 67, 2, 9, 7, 45 };
            int max = -100;
            int min = 100;
            int summ = 0;
            int multi = 1;
            for (int x = 0; x < array.Length; x++)
            {
                int g = array[x];
                summ += g;
                multi *= g;
                if (min > g)
                {
                    min = g;
                }
                if (max < g)
                {
                    max = g;
                }
                
                Console.Write($"{array[x]} ");
            }
            int average = summ / 20;
            Console.WriteLine(max);
            Console.WriteLine(min);
            Console.WriteLine(summ);
            Console.WriteLine(multi);
            Console.WriteLine(average);
            //с минимальным и максимальным не понял пока что + рандом 
        }
    }
}
