using System;
using ArrayProcessingLib;
namespace MainConsoleApp
{
    class Program
    {
        public static string[] BuildArray()
        {
            var rand = new Random();
            int len = rand.Next(5, 20);
            string[] array = new string[len];
            
            for (int i = 0; i < array.Length; i++)
            {
                int sign = rand.Next(-1, 1);
                array[i] = (sign != 0 ? sign * Math.Round(rand.NextDouble() + rand.Next(0, 10), 3) : Math.Round(rand.NextDouble() + rand.Next(0, 10), 3)).ToString();
            }

            return array;
        }
        static void Main(string[] args)
        {
            string[] arr = BuildArray();

            foreach(var item in arr)
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
