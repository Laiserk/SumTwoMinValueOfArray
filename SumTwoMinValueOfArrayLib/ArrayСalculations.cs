using System;

namespace ArrayProcessingLib
{
    public class ArrayСalculations
    {
        public double SumTwoMinValues(double[] array) 
        {
            int min1, min2, tmp;
            if (array[0] < array[1])
            {
                min1 = 0;
                min2 = 1;
            }
            else
            {
                min1 = 1;
                min2 = 0;
            }
            for(int i = 2; i<array.Length; i++)
            {
                if(array[i] < array[min1])
                {
                    tmp = min1;
                    min1 = i;
                    if (array[tmp] < array[min2])
                        min2 = tmp;
                }
                else
                {
                    if (array[i] < array[min2])
                        min2 = i;
                }
            }
            
            return array[min1] + array[min2];
        }
    }
}
