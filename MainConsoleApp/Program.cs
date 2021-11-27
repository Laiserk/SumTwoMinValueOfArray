using System;
using ArrayProcessingLib;
namespace MainConsoleApp
{
    class Program
    {
        public static double[] BuildArray()
        {
            var rand = new Random();
            int len = rand.Next(5, 20);
            double[] array = new double[len];
            
            for (int i = 0; i < array.Length; i++)
            {     
                array[i] = Math.Round(rand.NextDouble(), 2) + rand.Next(1, 10);
            }

            return array;
        }
        static void Main(string[] args)
        {
            double[] arr = BuildArray();

            foreach(double item in arr)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();

            var ac = new ArrayСalculations();
            Console.WriteLine(ac.SumTwoMinValues(arr));

            Console.ReadKey();
        }
    }
}
