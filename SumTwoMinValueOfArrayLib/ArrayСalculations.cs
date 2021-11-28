using System;

namespace ArrayProcessingLib
{
    public class ArrayСalculations
    {
        public string CheckArray(string[] array)
        {
            if (array.Length == 0)
                return "Array is empty";

            double digit;
            for (var i = 0; i < array.Length; i++)
            {
                if (!double.TryParse(array[i], out digit))
                    return "Some values cannot be processed";
            }
            return "correctly";
        }

        public string SumTwoMinValues(string[] array)
        {
            if (CheckArray(array) != "correctly")
                return CheckArray(array);

            int min1, min2, tmp;
            double[] darray = new double[array.Length];

            for (var i = 0; i < array.Length; i++)
            {
                darray[i] = double.Parse(array[i]);
            }
            if (darray[0] < darray[1])
            {
                min1 = 0;
                min2 = 1;
            }
            else
            {
                min1 = 1;
                min2 = 0;
            }

            for (int i = 2; i < array.Length; i++)
            {
                if (darray[i] < darray[min1])
                {
                    tmp = min1;
                    min1 = i;
                    if (darray[tmp] < darray[min2])
                        min2 = tmp;
                }
                else
                {
                    if (darray[i] < darray[min2])
                        min2 = i;
                }
            }

            return Math.Round(darray[min1] + darray[min2], 3).ToString();
        }
    }
}
